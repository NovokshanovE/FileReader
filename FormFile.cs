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
    public partial class FormFile : Form
    {
        private string filePath;
        private StreamReader streamReader;
        private string fileContent;
        public FormFile(StreamReader openFile, string path)
        {
            fileContent = string.Empty;
            InitializeComponent();
            this.filePath = path;
            this.streamReader = openFile;




            fileContent = openFile.ReadToEnd();

            textBox1.Text = fileContent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            streamReader.Close();
            string text = textBox1.Text;
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLineAsync(text);
            }

        }
    }
}
