namespace ExifRenamer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            columnHeaderFileName = new ColumnHeader();
            columnHeaderExifDateTimeOriginal = new ColumnHeader();
            columnHeaderExifDateTime = new ColumnHeader();
            columnHeaderAfterName = new ColumnHeader();
            columnHeaderNotice = new ColumnHeader();
            label1 = new Label();
            textBoxDirPath = new TextBox();
            buttonGetFiles = new Button();
            buttonRemoveUnneededItems = new Button();
            pictureBox1 = new PictureBox();
            buttonSelectAll = new Button();
            buttonRename = new Button();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            listViewExif = new ListView();
            columnHeaderExifFieldName = new ColumnHeader();
            columnHeaderExifValue = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.AllowDrop = true;
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderFileName, columnHeaderExifDateTimeOriginal, columnHeaderExifDateTime, columnHeaderAfterName, columnHeaderNotice });
            listView1.Location = new Point(2, 30);
            listView1.Name = "listView1";
            listView1.Size = new Size(885, 293);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ItemChecked += listView1_ItemChecked;
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.DragDrop += listView1_DragDrop;
            listView1.DragEnter += listView1_DragEnter;
            listView1.KeyDown += listView1_KeyDown;
            // 
            // columnHeaderFileName
            // 
            columnHeaderFileName.Text = "元ファイル名";
            columnHeaderFileName.Width = 300;
            // 
            // columnHeaderExifDateTimeOriginal
            // 
            columnHeaderExifDateTimeOriginal.Text = "Exif.DateTimeOriginal";
            columnHeaderExifDateTimeOriginal.Width = 150;
            // 
            // columnHeaderExifDateTime
            // 
            columnHeaderExifDateTime.Text = "Exif.DateTime";
            columnHeaderExifDateTime.Width = 150;
            // 
            // columnHeaderAfterName
            // 
            columnHeaderAfterName.Text = "変更後ファイル名";
            columnHeaderAfterName.Width = 200;
            // 
            // columnHeaderNotice
            // 
            columnHeaderNotice.Text = "注釈";
            columnHeaderNotice.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 5);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "フォルダ：";
            // 
            // textBoxDirPath
            // 
            textBoxDirPath.Location = new Point(68, 3);
            textBoxDirPath.Name = "textBoxDirPath";
            textBoxDirPath.Size = new Size(482, 23);
            textBoxDirPath.TabIndex = 2;
            // 
            // buttonGetFiles
            // 
            buttonGetFiles.Location = new Point(556, 3);
            buttonGetFiles.Name = "buttonGetFiles";
            buttonGetFiles.Size = new Size(119, 22);
            buttonGetFiles.TabIndex = 3;
            buttonGetFiles.Text = "ファイル一覧取得";
            buttonGetFiles.UseVisualStyleBackColor = true;
            buttonGetFiles.Click += buttonGetFiles_Click;
            // 
            // buttonRemoveUnneededItems
            // 
            buttonRemoveUnneededItems.Location = new Point(3, 328);
            buttonRemoveUnneededItems.Name = "buttonRemoveUnneededItems";
            buttonRemoveUnneededItems.Size = new Size(129, 57);
            buttonRemoveUnneededItems.TabIndex = 4;
            buttonRemoveUnneededItems.Text = "リネーム不可・不要をリストから削除";
            buttonRemoveUnneededItems.UseVisualStyleBackColor = true;
            buttonRemoveUnneededItems.Click += buttonRemoveUnneededItems_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // buttonSelectAll
            // 
            buttonSelectAll.Location = new Point(138, 328);
            buttonSelectAll.Name = "buttonSelectAll";
            buttonSelectAll.Size = new Size(75, 57);
            buttonSelectAll.TabIndex = 6;
            buttonSelectAll.Text = "全選択";
            buttonSelectAll.UseVisualStyleBackColor = true;
            buttonSelectAll.Click += buttonSelectAll_Click;
            // 
            // buttonRename
            // 
            buttonRename.Location = new Point(219, 328);
            buttonRename.Name = "buttonRename";
            buttonRename.Size = new Size(108, 57);
            buttonRename.TabIndex = 7;
            buttonRename.Text = "リネーム";
            buttonRename.UseVisualStyleBackColor = true;
            buttonRename.Click += buttonRename_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Location = new Point(12, 11);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonRemoveUnneededItems);
            splitContainer1.Panel1.Controls.Add(buttonGetFiles);
            splitContainer1.Panel1.Controls.Add(buttonRename);
            splitContainer1.Panel1.Controls.Add(textBoxDirPath);
            splitContainer1.Panel1.Controls.Add(buttonSelectAll);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(listView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1240, 580);
            splitContainer1.SplitterDistance = 894;
            splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(listViewExif);
            splitContainer2.Size = new Size(338, 576);
            splitContainer2.SplitterDistance = 246;
            splitContainer2.TabIndex = 6;
            // 
            // listViewExif
            // 
            listViewExif.Columns.AddRange(new ColumnHeader[] { columnHeaderExifFieldName, columnHeaderExifValue });
            listViewExif.Dock = DockStyle.Fill;
            listViewExif.Location = new Point(0, 0);
            listViewExif.Name = "listViewExif";
            listViewExif.Size = new Size(338, 326);
            listViewExif.TabIndex = 0;
            listViewExif.UseCompatibleStateImageBehavior = false;
            listViewExif.View = View.Details;
            // 
            // columnHeaderExifFieldName
            // 
            columnHeaderExifFieldName.Text = "タグ";
            columnHeaderExifFieldName.Width = 200;
            // 
            // columnHeaderExifValue
            // 
            columnHeaderExifValue.Text = "値";
            columnHeaderExifValue.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 601);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "ExifDateRenamer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeaderFileName;
        private ColumnHeader columnHeaderExifDateTimeOriginal;
        private Label label1;
        private TextBox textBoxDirPath;
        private Button buttonGetFiles;
        private ColumnHeader columnHeaderExifDateTime;
        private ColumnHeader columnHeaderAfterName;
        private ColumnHeader columnHeaderNotice;
        private Button buttonRemoveUnneededItems;
        private PictureBox pictureBox1;
        private Button buttonSelectAll;
        private Button buttonRename;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ListView listViewExif;
        private ColumnHeader columnHeaderExifFieldName;
        private ColumnHeader columnHeaderExifValue;
    }
}