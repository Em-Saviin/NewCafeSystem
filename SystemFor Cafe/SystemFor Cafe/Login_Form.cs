using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SystemFor_Cafe
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();

        }

        public void login_Form_load(object sender, EventArgs e)
        {
 
              

        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }
                        //Butyon Login 
        private void button1_Click(object sender, EventArgs e)
        {
        
            //MessageBox.Show("Login Success");
            if (txtPassword.Text == ""  ) {
                MessageBox.Show("Please Enter your Password", "Incorrect Password", MessageBoxButtons.RetryCancel);
            }
            else if( txtPassword.Text != "@1234567")
            {
                MessageBox.Show("In Correct Password", "Wrong Password", MessageBoxButtons.RetryCancel);
            }
            else if (txtPassword.Text == "@1234567")
            {
             //   MessageBox.Show("Login Success");
                 Form1 F1 = new Form1();
                F1.Show();
                
                 this.Hide();

            }
        }
                            //Change password string to symbol
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true ;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
                            //Button Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
