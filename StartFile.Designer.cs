namespace FileReader
{
    partial class formStartSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStartSelect));
            buttonCreate = new Button();
            buttonOpen = new Button();
            StartGroupBox = new GroupBox();
            StartFileName = new TextBox();
            GroupBox_FilePath = new GroupBox();
            StartDynamicFolder = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            groupBox_fileName = new GroupBox();
            textBox1 = new TextBox();
            StartGroupBox.SuspendLayout();
            GroupBox_FilePath.SuspendLayout();
            groupBox_fileName.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.Cursor = Cursors.Hand;
            buttonCreate.Dock = DockStyle.Left;
            buttonCreate.Location = new Point(3, 24);
            buttonCreate.Margin = new Padding(3, 4, 3, 4);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(182, 54);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += StartButtonToCreate_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Cursor = Cursors.Hand;
            buttonOpen.Dock = DockStyle.Right;
            buttonOpen.Location = new Point(197, 24);
            buttonOpen.Margin = new Padding(3, 4, 3, 4);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(182, 54);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Открыть";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += StartButtonToOpen_Click;
            // 
            // StartGroupBox
            // 
            StartGroupBox.Controls.Add(buttonOpen);
            StartGroupBox.Controls.Add(buttonCreate);
            StartGroupBox.Dock = DockStyle.Bottom;
            StartGroupBox.Location = new Point(0, 141);
            StartGroupBox.Margin = new Padding(3, 4, 3, 4);
            StartGroupBox.Name = "StartGroupBox";
            StartGroupBox.Padding = new Padding(3, 4, 3, 4);
            StartGroupBox.Size = new Size(382, 82);
            StartGroupBox.TabIndex = 2;
            StartGroupBox.TabStop = false;
            StartGroupBox.Text = "Выбор:";
            // 
            // StartFileName
            // 
            StartFileName.Dock = DockStyle.Left;
            StartFileName.Location = new Point(3, 24);
            StartFileName.Margin = new Padding(3, 4, 3, 4);
            StartFileName.Multiline = true;
            StartFileName.Name = "StartFileName";
            StartFileName.Size = new Size(320, 58);
            StartFileName.TabIndex = 3;
            // 
            // GroupBox_FilePath
            // 
            GroupBox_FilePath.Controls.Add(StartDynamicFolder);
            GroupBox_FilePath.Controls.Add(StartFileName);
            GroupBox_FilePath.Dock = DockStyle.Top;
            GroupBox_FilePath.Location = new Point(0, 0);
            GroupBox_FilePath.Margin = new Padding(3, 4, 3, 4);
            GroupBox_FilePath.Name = "GroupBox_FilePath";
            GroupBox_FilePath.Padding = new Padding(3, 4, 3, 4);
            GroupBox_FilePath.Size = new Size(382, 86);
            GroupBox_FilePath.TabIndex = 4;
            GroupBox_FilePath.TabStop = false;
            GroupBox_FilePath.Text = "Вставьте путь к файлу:";
            // 
            // StartDynamicFolder
            // 
            StartDynamicFolder.Cursor = Cursors.Hand;
            StartDynamicFolder.Dock = DockStyle.Right;
            StartDynamicFolder.Image = (Image)resources.GetObject("StartDynamicFolder.Image");
            StartDynamicFolder.Location = new Point(329, 24);
            StartDynamicFolder.Name = "StartDynamicFolder";
            StartDynamicFolder.Size = new Size(50, 58);
            StartDynamicFolder.TabIndex = 4;
            StartDynamicFolder.UseVisualStyleBackColor = true;
            StartDynamicFolder.Click += StartDynamicFolder_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // groupBox_fileName
            // 
            groupBox_fileName.Controls.Add(textBox1);
            groupBox_fileName.Dock = DockStyle.Fill;
            groupBox_fileName.Location = new Point(0, 86);
            groupBox_fileName.Name = "groupBox_fileName";
            groupBox_fileName.Size = new Size(382, 55);
            groupBox_fileName.TabIndex = 5;
            groupBox_fileName.TabStop = false;
            groupBox_fileName.Text = "Название файла:";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Left;
            textBox1.Location = new Point(3, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 27);
            textBox1.TabIndex = 0;
            // 
            // formStartSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 223);
            Controls.Add(groupBox_fileName);
            Controls.Add(GroupBox_FilePath);
            Controls.Add(StartGroupBox);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(400, 270);
            MinimumSize = new Size(400, 270);
            Name = "formStartSelect";
            Text = "Выбор файла";
            StartGroupBox.ResumeLayout(false);
            GroupBox_FilePath.ResumeLayout(false);
            GroupBox_FilePath.PerformLayout();
            groupBox_fileName.ResumeLayout(false);
            groupBox_fileName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.GroupBox StartGroupBox;
        private System.Windows.Forms.TextBox StartFileName;
        private System.Windows.Forms.GroupBox GroupBox_FilePath;
        private FolderBrowserDialog folderBrowserDialog1;
        public Button StartDynamicFolder;
        private GroupBox groupBox_fileName;
        private TextBox textBox1;
    }
}