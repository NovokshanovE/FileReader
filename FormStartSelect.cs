using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FileReader
{
    public partial class formStartSelect : Form
    {
        //private objects
        private string fileName;
        private string filePath;
        private StreamReader reader;
        //private method
        private void StartButtonToCreate_Click(object sender, EventArgs e)
        {
            filePath = textBox_FilePath.Text;
            fileName = textBox_FileName.Text;
            Dispose(true);
        }

        private void StartButtonToOpen_Click(object sender, EventArgs e)
        {
            filePath = textBox_FilePath.Text;
            fileName = textBox_FileName.Text;
            reader = new StreamReader(FilePath_Output());
            Dispose(true);
        }

        private void StartDynamicFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            string folderName;
            // если папка выбрана и нажата клавиша `OK` - значит можно получить путь к папке
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                // запишем в нашу переменную путь к папке
                folderName = folderBrowserDialog1.SelectedPath;
                textBox_FilePath.Text = folderName;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        //public method
        public formStartSelect()
        {
            InitializeComponent();
        }
        public string FilePath_Output()
        {
            return (filePath + "\\" + fileName);
        }
        public StreamReader StreamReader_Output()
        {
            return reader;
        }

    }
}
