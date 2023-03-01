namespace FileReader
{
    partial class StartFile
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
            this.StartButtonToCreate = new System.Windows.Forms.Button();
            this.StartButtonToOpen = new System.Windows.Forms.Button();
            this.StartGroupBox = new System.Windows.Forms.GroupBox();
            this.StartFileName = new System.Windows.Forms.TextBox();
            this.StartFilePath = new System.Windows.Forms.GroupBox();
            this.StartGroupBox.SuspendLayout();
            this.StartFilePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButtonToCreate
            // 
            this.StartButtonToCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.StartButtonToCreate.Location = new System.Drawing.Point(3, 18);
            this.StartButtonToCreate.Name = "StartButtonToCreate";
            this.StartButtonToCreate.Size = new System.Drawing.Size(182, 45);
            this.StartButtonToCreate.TabIndex = 0;
            this.StartButtonToCreate.Text = "Создать";
            this.StartButtonToCreate.UseVisualStyleBackColor = true;
            this.StartButtonToCreate.Click += new System.EventHandler(this.StartButtonToCreate_Click);
            // 
            // StartButtonToOpen
            // 
            this.StartButtonToOpen.Dock = System.Windows.Forms.DockStyle.Right;
            this.StartButtonToOpen.Location = new System.Drawing.Point(197, 18);
            this.StartButtonToOpen.Name = "StartButtonToOpen";
            this.StartButtonToOpen.Size = new System.Drawing.Size(182, 45);
            this.StartButtonToOpen.TabIndex = 1;
            this.StartButtonToOpen.Text = "Открыть";
            this.StartButtonToOpen.UseVisualStyleBackColor = true;
            this.StartButtonToOpen.Click += new System.EventHandler(this.StartButtonToOpen_Click);
            // 
            // StartGroupBox
            // 
            this.StartGroupBox.Controls.Add(this.StartButtonToOpen);
            this.StartGroupBox.Controls.Add(this.StartButtonToCreate);
            this.StartGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StartGroupBox.Location = new System.Drawing.Point(0, 57);
            this.StartGroupBox.Name = "StartGroupBox";
            this.StartGroupBox.Size = new System.Drawing.Size(382, 66);
            this.StartGroupBox.TabIndex = 2;
            this.StartGroupBox.TabStop = false;
            this.StartGroupBox.Text = "Выбор:";
            // 
            // StartFileName
            // 
            this.StartFileName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StartFileName.Location = new System.Drawing.Point(3, 26);
            this.StartFileName.Name = "StartFileName";
            this.StartFileName.Size = new System.Drawing.Size(376, 22);
            this.StartFileName.TabIndex = 3;
            // 
            // StartFilePath
            // 
            this.StartFilePath.Controls.Add(this.StartFileName);
            this.StartFilePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartFilePath.Location = new System.Drawing.Point(0, 0);
            this.StartFilePath.Name = "StartFilePath";
            this.StartFilePath.Size = new System.Drawing.Size(382, 51);
            this.StartFilePath.TabIndex = 4;
            this.StartFilePath.TabStop = false;
            this.StartFilePath.Text = "Вставьте путь к файлу:";
            // 
            // StartFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 123);
            this.Controls.Add(this.StartFilePath);
            this.Controls.Add(this.StartGroupBox);
            this.MaximumSize = new System.Drawing.Size(400, 170);
            this.MinimumSize = new System.Drawing.Size(400, 170);
            this.Name = "StartFile";
            this.Text = "Выбор файла";
            this.StartGroupBox.ResumeLayout(false);
            this.StartFilePath.ResumeLayout(false);
            this.StartFilePath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButtonToCreate;
        private System.Windows.Forms.Button StartButtonToOpen;
        private System.Windows.Forms.GroupBox StartGroupBox;
        private System.Windows.Forms.TextBox StartFileName;
        private System.Windows.Forms.GroupBox StartFilePath;
    }
}