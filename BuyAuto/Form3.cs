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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
  

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 zakaz = new Form2();
            zakaz.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Позвоните эвакуаторщику и он привзет вам автомобиль +7-987-126-45-56" );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Позвоните эвакуаторщику и он отвезет автомобиль обратно +7-987-126-45-56" );
        }
    }
}
