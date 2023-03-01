using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReader
{
    public partial class formStartSelect : Form
    {
        public formStartSelect()
        {
            InitializeComponent();
        }

        private void StartButtonToCreate_Click(object sender, EventArgs e)
        {

        }

        private void StartButtonToOpen_Click(object sender, EventArgs e)
        {

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
                StartFileName.Text = folderName;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
