using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_Q02{
    public partial class Form1 : Form{

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PalindromeCheck CHECKER = new PalindromeCheck();

           bool IsPal = CHECKER.CheckPal(textBox1.Text);

            if (IsPal){
                textBox2.Text = (textBox1.Text + " is a palindrome.");
            }else{
                textBox2.Text = (textBox1.Text + " is not a palindrome.");
            }

        }
    }
}
