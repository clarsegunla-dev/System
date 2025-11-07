using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class Form5 : Form
    {
        private ListBox.SelectedObjectCollection selectedItems;
        private float totalf;

        public Form5(ListBox.ObjectCollection items)
        {
            InitializeComponent();

            float total = listBox1.Items.Count;
            Form5 lahat = new Form5(total);
           
            foreach (var item in items)
            {
                listBox1.Items.Add(item); // Add items to Form4 ListBox
            }
           ;

            comboBox1.Items.Add("Dine In");
            comboBox1.Items.Add("Take Out");

            comboBox2.Items.Add("Cash");
            comboBox2.Items.Add(" Credit Card");
        }

        public Form5(ListBox.SelectedObjectCollection selectedItems)
        {
            this.selectedItems = selectedItems;
        }

        public Form5(float total)
        {
            this.totalf = total;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text=="Dine In")
            {
                comboBox2.Items.Add("Cash");
                comboBox2.Items.Add(" Credit Card");

              
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Cash")
            {
             float pay= Convert.ToSingle(textBox1.Text);
                listBox1.Items.Add(comboBox1.SelectedItem);
               
                listBox1.Items.Add( "Paid:"+pay );
               








            }
            if (comboBox2.Text == "Credit Card")
            {


            }
           

        }

       

       

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
