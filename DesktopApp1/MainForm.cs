using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            
        }
        

        private void textBox1Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }

        }

        private void textBox2Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
        }

    }
}
