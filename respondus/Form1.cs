using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace respondus
{
    public partial class Form1 : Form
    {
        /* Ignore this crappy code and UI design
         I would make it better if I wasn't lazy*/
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.TopMost = true; // <--- This is litterally the "bypass", one line of code lol
            if(!webBrowser1.CanGoBack)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
            if (!webBrowser1.CanGoForward)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
            //Disables button depending on if the browser can go forward or backwards
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            } // Checks if browser can go back, and if so it will
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward(); // Make the web browser go forward
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh(); // Refresh the web browser
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text); // Search Bar
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome(); // Go to homepage (bing)
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
