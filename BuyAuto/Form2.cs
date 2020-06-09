using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyAuto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /*private void radioButton1_CheckedChanged(object sender, EventArgs e)
       {
           RadioButton radioButton1 = (RadioButton)sender;
           if (radioButton1.Checked)
           {
               MessageBox.Show("Вы выбрали авто " + radioButton1.Text);
           }
           Form3 VF = new Form3();
           VF.Show();

   }

       private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton2 = (RadioButton)sender;
            if (radioButton2.Checked)
            {
                MessageBox.Show("Вы выбрали авто" + radioButton2.Text);
            }
            Form4 Mazda = new Form4();
            Mazda.Show();
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 head = new Form1();
            head.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 VF = new Form3();
            VF.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Mazda6 = new Form4();
            Mazda6.Show();
            this.Hide();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 Skoda = new Form5();
            Skoda.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 Chevrolet = new Form6();
            Chevrolet.Show();
            this.Hide();
        }

      
    }
}
