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
    public partial class GestureBoard : Form
    {
        public GestureBoard()
        {
            InitializeComponent();


        }

        private void GestureBoard_Load(object sender, EventArgs e)
        {
        }

        private void button49_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button49.Text;
        }

        private void GestureBoard_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
