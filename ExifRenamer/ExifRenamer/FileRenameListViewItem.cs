using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExifRenamer
{
    internal class FileRenameListViewItem : ListViewItem
    {
        public FileInfo FileInfo { get; }
        public Exif Exif { get; }
        public string AfterFileName { get; }
        public bool NeedRename { get; }

        public string AfterFileFullName
        {
            get
            {
                return this.FileInfo.DirectoryName + "\\" + this.AfterFileName;
            }
        }

        public FileRenameListViewItem(FileInfo fi) : base() {

            this.FileInfo = fi;

            this.Exif = new Exif(fi.FullName);

            this.Text = fi.FullName;
            this.SubItems.Add(Exif.DateTimeOriginal);
            this.SubItems.Add(Exif.DateTime);

            AfterFileName = "";

            if (Exif.DateTimeOriginal != "")
            {
                AfterFileName = Exif.DateTimeOriginal.Replace(":", "-").Replace(" ", "-");
            }
            else if (Exif.DateTime != "")
            {
                AfterFileName = Exif.DateTime.Replace(":", "-").Replace(" ", "-");
            }

            if (AfterFileName != "")
            {
                AfterFileName += fi.Extension;

                if (AfterFileName != fi.Name)
                {
                    NeedRename = true;
                }
            }

            this.SubItems.Add(AfterFileName);

            if (AfterFileName == fi.Name)
            {
                this.SubItems.Add("変更なし");
            }
            else if (AfterFileName == "")
            {
                this.SubItems.Add("日付情報なし");
            }
            else if (File.Exists(this.AfterFileFullName))
            {
                this.SubItems.Add("ファイル名重複");
            }
        }
    }
}
