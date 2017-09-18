using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Diagnostics;




namespace Main_Project
{
    public partial class MainPage : Form
    {
        public bool _powerButton = true;       //its off
 
        public MainPage()
        {
            InitializeComponent();
            //disableIcons();


        }

        private void MainPage_Load(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form webBrower = new Kam_Browser();
            webBrower.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // objecttracking_openCV.HandTrack theHandForm = new objecttracking_openCV.HandTrack();
            //  theHandForm.Show();


            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Camera Mouse\\Camera Mouse 2016\\Camera Mouse 2016.exe");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HeadTracker.Form1 theHead = new HeadTracker.Form1();
            theHead.Show();
           

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form km = new KamVideoPlayer();
            km.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form theEmail = new Email();
            theEmail.Show();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");       //s is for shutdown







            /* if (_powerButton)           //if switch on
             {
                 powerButton.ImageIndex = 1;
                 enableIcons();
                 _powerButton = !_powerButton;
             }
                             //if switch off button is pressed
             else
             {
                 powerButton.ImageIndex = 0;
                 disableIcons();                 
                 _powerButton = !_powerButton;

                 this.Close();
             }*/
        }

       /* public void disableIcons()
        {
            groupBox1.Visible = groupBox2.Visible = groupBox3.Visible = groupBox4.Visible = groupBox5.Visible = groupBox6.Visible = false;
  

            headButton.Visible = handButton.Visible = false;
        }

        public void enableIcons()
        {
            groupBox1.Visible = groupBox2.Visible = groupBox3.Visible = groupBox4.Visible = groupBox5.Visible = groupBox6.Visible = true;


            headButton.Visible = handButton.Visible = true;
        }*/

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form mp3 = new MP3Player();
            mp3.Show();

            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form textEditor = new TextEditor();
            textEditor.Show();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\osk.exe");
            //Form gb = new GestureBoard();
          //  gb.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");        // r is for Restart
        }
    }
}


//*****************************NOTEs*********************
            //SendKeys.SendWait("Freak "); this is use to simulate key pressed by KEYBOARD