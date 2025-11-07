using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace System
{
    public partial class Form1 : Form
    {
        int ulit = 3;
      
        public Form1()
        {
            InitializeComponent();
           

            textBox3.PasswordChar = '*';

          



        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text;
            string lname = textBox2.Text;
            string idnum = textBox4.Text;

            string Comfirmpass = textBox3.Text;
            Comfirmpass = "12345678";

            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(idnum))
            {
                MessageBox.Show("There is missing information");
                return;
            }

            if (idnum.Length != 4 || !idnum.All(char.IsDigit))
            {
                MessageBox.Show("ID number must be exactly 4 digits.");
                textBox4.Clear();
                return;
            }
            if (Comfirmpass.Length != 8 || !Comfirmpass.All(char.IsDigit))
            {
                MessageBox.Show("Password number must be exactly 8 digits.");
               
                return;



            }


            if (textBox3.Text == Comfirmpass)
            {
                Form2 Home = new Form2();
                Home.Show();
                MessageBox.Show("Log in successful");
            }
            else
            {
                ulit--;
                if (ulit > 0)
                {
                    MessageBox.Show("Wrong password! Attempts left: " + ulit);
                    textBox3.Clear();
                    return;
                }
                else
                {
                    MessageBox.Show("Too many attempts! Access denied. The system will automatically close");
                    this.Close();
                }
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
