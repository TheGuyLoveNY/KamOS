using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class MP3Player : Form
    {
        public MP3Player()
        {
            InitializeComponent();
        }
        string[] f, p;

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
           // listBox1.Items.Clear();
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.URL = p[listBox1.SelectedIndex];
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            listBox1.Items.Clear();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                f = fd.SafeFileNames;
                p = fd.FileNames;
            }
            for (int i = 0; i < f.Length; i++)
            {
                listBox1.Items.Add(f[i]);
            }

        }
    }
}
