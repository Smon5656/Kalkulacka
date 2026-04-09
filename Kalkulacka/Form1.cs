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
        //enum je nejaky vycet, ze co za operaci tam mam
        enum enOperace { nic, plus, minus, krat, deleno, rovno};
        enOperace menAktualneVybranaOperace;

        //-----------------------------------------------------------------------------------------------------------
        //konstruktor
        //-----------------------------------------------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();

            //uvest do pocatecniho stavu
            SmazatVse();
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

            //----------------------cviceni--------------------------------------
            //pridavam 1 do toho textboxu
            //txtDisplay.Text = txtDisplay.Text + "1"; //mohu pouzit i +=
            //je to pricitani do toho text boxu
            //vsichni povinne psat komentare
            //-------------------------------------------------------------------

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
            SmazatVse();
        }

        //-------------------------------------------------
        //funkce na vraceni kalkulacky do pocatecniho stavu
        //-------------------------------------------------
        private void SmazatVse()
        {
            //vymazat udaje
            txtDisplay.Text = "0";

            //nastavim timto kalkulacku do pocatecniho stavu

            //jsem v operaci nic u tyhle funkce
            //u teto vybrane mat. operace tam proste nic v displeji nechci
            menAktualneVybranaOperace = enOperace.nic;
        }

        private void btOperace_Click(object sender, EventArgs e)
        {
            //resim, ktere tlacitko to zavolalo
            Button MojeTlacitko;
            MojeTlacitko = (Button)sender;

            //pokud text na mem tlacitku odpovida +, udelej tohle
            //if (MojeTlacitko.Text == "+")
                //menAktualneVybranaOperace = enOperace.plus;
            //ja tam nechci psat milion if podminek
                //udelam switch case
                    //je to lepsi vykonnostne

                //break je tam proto, ze nechci, aby se udelaly vsechny
                    //by to zacalo pokracovat dal
            
            //timhle vyberu operaci
            switch (MojeTlacitko.Text)
            {
                case "+":
                    menAktualneVybranaOperace = enOperace.plus;
                    break; //vyskoc z bloku ven
                case "-":
                    menAktualneVybranaOperace = enOperace.minus;
                    break;
                case "*":
                    menAktualneVybranaOperace = enOperace.krat;
                    break;
                case "/":
                    menAktualneVybranaOperace = enOperace.deleno;
                    break;
            }
        }
    }
}
