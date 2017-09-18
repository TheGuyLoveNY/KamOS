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
    public partial class Kam_Browser : Form
    {
        public Kam_Browser()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;


        }

        private void goButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.co.in/?gfe_rd=cr&ei=dGL_VryRDarv8wfcy5iQBg#q="+textBox1.Text);
            // webBrowser1.Navigate(textBox1.Text);  https://www.google.co.in/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");

        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            label2.Text = webBrowser1.StatusText;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            label1.Text = webBrowser1.DocumentTitle;
            textBox1.Text = webBrowser1.Url.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kam_Browser_Load(object sender, EventArgs e)
        {

        }

        private void Kam_Browser_Shown(object sender, EventArgs e)
        {            
        }

        private void button1_Click(object sender, EventArgs e)//youtube button
        {
            webBrowser1.Navigate("www.youtube.com");
        }

        private void wikiButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.wikipedia.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.facebook.com");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.amazon.com");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.flipkart.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.yahoo.in");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.snapdeal.com");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.twitter.com");
        }
    }
}
