using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtDisplay.Text = "Ahoj světe";
            ///do txtdisplay s vlastnosti text mi to napise ahoj svete
         
       
            ///mam to naprogramovat tak, aby policko pak bylo zelene
            txtDisplay.BackColor = Color.Green;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            txtDisplay.Text = "";
            txtDisplay.BackColor = Color.White;
        }
    }
}
