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
    public partial class KamVideoPlayer : Form
    {
        public bool thePlay = false;
        public bool theMaxScreen = true;
        public bool theMute = true;
        public KamVideoPlayer()
        {
            InitializeComponent();
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)  //the play/pause button
        {
            if (thePlay)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                button1.ImageIndex = 13;            //pause button image
                thePlay = !thePlay;
            }

            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                button1.ImageIndex = 14;            //play button image
                thePlay = !thePlay;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
            thePlay = !thePlay;
            button1.ImageIndex = 14;            //play button image
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
            thePlay = !thePlay;
            button1.ImageIndex = 14;            //play button image
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void KamPlayer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(theMaxScreen)
            {
                try
                {
                    button7.ImageIndex = 1;     //minimize icon

                    axWindowsMediaPlayer1.fullScreen = true;
                    theMaxScreen = !theMaxScreen;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Please Play the video first!");
                }
            }
            else
            {
                try
                {
                    button7.ImageIndex = 0;     //maximize icon
                    axWindowsMediaPlayer1.fullScreen = !axWindowsMediaPlayer1.fullScreen;
                    theMaxScreen = !theMaxScreen;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Please Play the video first!");
                }

            }

        }

        private void KamPlayer_MouseMove(object sender, MouseEventArgs e)
        {
           // button7.Show();
        }

        private void KamPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)           //escape key will minimize or maximize the screen
            {
                axWindowsMediaPlayer1.fullScreen = !axWindowsMediaPlayer1.fullScreen;
            }
        }

        private void axWindowsMediaPlayer1_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {

        }

        private void axWindowsMediaPlayer1_KeyPressEvent(object sender, AxWMPLib._WMPOCXEvents_KeyPressEvent e)
        {

        }

        private void axWindowsMediaPlayer1_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        { 
               
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (theMute)
            {
                axWindowsMediaPlayer1.settings.mute = true;
                button2.ImageIndex = 21;
                theMute = !theMute;
            }

            else
            {
                axWindowsMediaPlayer1.settings.mute = false;
                button2.ImageIndex = 20;
                theMute = !theMute;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < trackBar1.Maximum)
            {
                trackBar1.Value += 10;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value > trackBar1.Minimum)
            {
                trackBar1.Value -= 10;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
