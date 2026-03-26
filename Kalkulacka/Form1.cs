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
        //-----------------------------------------------------------------------------------------------------------
        //konstruktor
        //-----------------------------------------------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }


        //-----------------------------------------------------------------------------------------------------------
        //rutina zpracuje stisknute cislo, proste zjisti tlacitko a napise do textoveho pole spravne cislo
        //-----------------------------------------------------------------------------------------------------------
        private void btCislo1_Click(object sender, EventArgs e)

        {

            //vsechna tlacitka ted funguji na tomto kvuli efektivite
            //abych to jako retard nemusel delat pro kazde tlacitko

            Button MojeTlacitko;
            MojeTlacitko = (Button)sender;


            //vymazani nuly
            if (txtDisplay.Text == "0") txtDisplay.Text = "";

            //pridavam 1 do toho textboxu
            //txtDisplay.Text = txtDisplay.Text + "1"; //mohu pouzit i +=
            //je to pricitani do toho text boxu
            //vsichni povinne psat komentare

            // pridani cisla na display
            txtDisplay.Text = txtDisplay.Text + MojeTlacitko.Text;
            //txtDisplay.Text += MojeTlacitko.Text;
        }

        //-----------------------------------------------------------------------------------------------------------
        //resetovat kalkulacku
        //-----------------------------------------------------------------------------------------------------------
        private void btSmazat_Click(object sender, EventArgs e)
        {
            //prepsani veskereho textu na disp na 0
            txtDisplay.Text = "0";
        }
    }
}
