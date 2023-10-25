using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace ExifRenamer
{
    public partial class Form1 : Form
    {
        // 1つ前に選択されてたやつ
        private ListViewItem? selectedItem = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data is null)
            {
                return;
            }

            this.addImages((string[])e.Data.GetData(DataFormats.FileDrop, false));
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGetFiles_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();

            if (Directory.Exists(this.textBoxDirPath.Text))
            {
                string[] filePaths = Directory.GetFiles(this.textBoxDirPath.Text);
                this.addImages(filePaths);
            }

        }

        private void addImages(string[] filePaths)
        {
            FileInfo fi;
            string ext;

            foreach (string fileName in filePaths)
            {
                // 存在チェック
                bool isContainImage = false;
                foreach (ListViewItem item in this.listView1.Items)
                {
                    if (item.Text == fileName)
                    {
                        isContainImage = true;
                    }
                }
                if (isContainImage)
                {
                    continue;
                }

                fi = new FileInfo(fileName);
                ext = fi.Extension.ToLower();

                if (ext == ".jpg" || ext == ".jpeg" || ext == ".jpe" || ext == ".jfif")
                {
                    this.addImage(fi);
                }
            }

        }

        private void addImage(FileInfo fi)
        {
            this.listView1.Items.Add(new FileRenameListViewItem(fi));
        }

        private void buttonRemoveUnneededItems_Click(object sender, EventArgs e)
        {
            foreach (FileRenameListViewItem item in this.listView1.Items)
            {
                if (!item.NeedRename)
                {
                    item.Remove();
                }
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                // 選択中の画像と異なる画像を選択した場合、画像を変更
                if (e.Item != this.selectedItem)
                {
                    //this.pictureBox1.Load(e.Item.Text);
                    this.previewImage((FileRenameListViewItem)e.Item);
                }

                if (e.Item == this.selectedItem)
                {
                    // 選択中のアイテムを再度クリックした場合、チェックを反転
                    e.Item.Checked = !e.Item.Checked;
                }
            }
            else
            {
                this.pictureBox1.Image = null;
            }

            if (this.listView1.SelectedIndices.Count > 0)
            {
                this.selectedItem = e.Item;
            }
            else
            {
                this.selectedItem = null;
            }
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            // 1つでも未チェックがあれば、すべてをチェックする
            bool isCheckedAll = true;
            foreach (ListViewItem item in this.listView1.Items)
            {
                if (!item.Checked)
                {
                    isCheckedAll = false;
                    break;
                }
            }

            foreach (ListViewItem item in this.listView1.Items)
            {
                item.Checked = !isCheckedAll;
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                //this.pictureBox1.Load(e.Item.Text);
                this.previewImage((FileRenameListViewItem)e.Item);
            }
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("チェックしている画像をリネームします。よろしいですか？", "確認", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            int renamedCount = 0;

            foreach (FileRenameListViewItem item in this.listView1.CheckedItems)
            {
                if (!item.NeedRename)
                {
                    continue;
                }

                //MessageBox.Show(item.Text + " => " + item.FileInfo.DirectoryName + "\\" + item.AfterFileName);

                File.Move(item.Text, item.FileInfo.DirectoryName + "\\" + item.AfterFileName);

                item.Remove();

                renamedCount++;
            }

            MessageBox.Show(renamedCount.ToString() + "枚の画像をリネームしました。");

        }

        private void previewImage(FileRenameListViewItem item)
        {
            this.pictureBox1.Load(item.Text);

            this.listViewExif.Items.Clear();

            foreach (System.Drawing.Imaging.PropertyItem tag in item.Exif.Tags)
            {
                ListViewItem tagItem = new ListViewItem();
                tagItem.Text = tag.Id.ToString();

                string val = System.Text.Encoding.ASCII.GetString(tag.Value);
                val = val.Trim(new char[] { '\0' });

                tagItem.SubItems.Add(val);

                this.listViewExif.Items.Add(tagItem);
            }
        }
    }
}