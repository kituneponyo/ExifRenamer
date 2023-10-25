using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExifRenamer
{
    internal class Exif
    {
        public System.Drawing.Imaging.PropertyItem[] Tags { get; }

        private string dateTime = "";
        private string dateTimeOriginal = "";

        public Exif(string filePath) {

            //読み込む
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(filePath);

            this.Tags = bmp.PropertyItems;

            //Exif情報を列挙する
            foreach (System.Drawing.Imaging.PropertyItem item in bmp.PropertyItems)
            {
                //データの型を判断
                if (item.Type == 2)
                {
                    // DateTime	ファイル変更日時	0x0132
                    // DateTimeOriginal	原画像データの生成日時	0x9003
                    // DateTimeDigitized デジタルデータの作成日時    0x9004

                    //ASCII文字の場合は、文字列に変換する
                    string val = System.Text.Encoding.ASCII.GetString(item.Value);
                    val = val.Trim(new char[] { '\0' });
                    //表示する
                    //Debug.WriteLine("{0:X}:{1}:{2}", item.Id, item.Type, val);

                    
                    if (item.Id == 0x0132) { this.dateTime = val; }
                    if (item.Id == 0x9003) { this.dateTimeOriginal = val; }
                }
            }

            //Debug.WriteLine("{0}: {1}, {2}", imgFile, dateTimeOriginal, dateTime);

            bmp.Dispose();
            bmp = null;
        }

        public string DateTime
        {
            get { return this.dateTime; }
        }

        public string DateTimeOriginal
        {
            get { return this.dateTimeOriginal; }
        }
    }
}
