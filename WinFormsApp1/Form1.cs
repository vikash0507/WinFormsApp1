using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog()==DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                string[] drs = Directory.GetDirectories(fbd.SelectedPath);
                foreach(string file in files)
                {
                    listBox1.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in drs)
                {
                    listBox1.Items.Add(Path.GetDirectoryName(dir));
                }
            }
        }
    }
}
