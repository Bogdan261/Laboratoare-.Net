using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double rezultat;
        double var1, var2;
        char flag=' ';
        bool virgula;

        public Form1()
        {
            InitializeComponent();
        }

       
        private void FirstNumber_TextChanged(object sender, EventArgs e)
        {
           

        }


        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Buton1_Click(object sender, EventArgs e)
        {
            if (FirstNumber.Text == "0" || FirstNumber.Text == null)
                FirstNumber.Text = "1";

            else
            FirstNumber.Text += '1';

        }

        private void Buton2_Click(object sender, EventArgs e)
        {
            if (FirstNumber.Text == "0" || FirstNumber.Text == null)
                FirstNumber.Text = "2";

            else
                FirstNumber.Text += '2';

        }

        private void Buton3_Click(object sender, EventArgs e)
        {
            if (FirstNumber.Text == "0" || FirstNumber.Text == null)
                FirstNumber.Text = "3";

            else
                FirstNumber.Text += '3';
        }

        private void Buton4_Click(object sender, EventArgs e)
        {
            if (FirstNumber.Text == "0" || FirstNumber.Text == null)
                FirstNumber.Text = "4";

            else
                FirstNumber.Text += '4';

        }

        private void Buton5_Click(object sender, EventArgs e)
        {
            if (FirstNumber.Text == "0" || FirstNumber.Text == null)
                FirstNumber.Text = "5";

            else
                FirstNumber.Text += '5';
        }

        private void Buton6_Click(object sender, EventArgs e)
        {
            if (FirstNumber.Text == "0" || FirstNumber.Text == null)
                FirstNumber.Text = "6";

            else
                FirstNumber.Text += '6';

        }

        private void Buton7_Click(object sender, EventArgs e)
        {
            if (FirstNumber.Text == "0" || FirstNumber.Text == null)
                FirstNumber.Text = "7";

            else
                FirstNumber.Text += '7';

        }

        private void Buton8_Click(object sender, EventArgs e)
        {
            if (FirstNumber.Text == "0" || FirstNumber.Text == null)
                FirstNumber.Text = "8";

            else
                FirstNumber.Text += '8';
        }

        private void Buton9_Click(object sender, EventArgs e)
        {
            if (FirstNumber.Text == "0" || FirstNumber.Text == null)
                FirstNumber.Text = "9";

            else
                FirstNumber.Text += '9';
        }

        private void Buton0_Click(object sender, EventArgs e)
        {
            if (FirstNumber.Text == null)
                FirstNumber.Text = "0";

            else
                FirstNumber.Text += '0';
        }

        private void Plus_Click(object sender, EventArgs e)
        {
          if(flag==' ')
            {
                flag = '+';

                String sir = FirstNumber.Text;
                if (sir[0] == '-')
                    var1 = -1 * Convert.ToDouble(sir.Substring(1));
                else
                    var1 = Convert.ToDouble(sir);
                FirstNumber.Text = null;
                virgula = false;
            }

        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (flag == ' ')
            {
                flag = '-';

                String sir = FirstNumber.Text;
                if (sir[0] == '-')
                    var1 = -1 * Convert.ToDouble(sir.Substring(1));
                else
                    var1 = Convert.ToDouble(sir);
                FirstNumber.Text = null;
                virgula = false;
            }

        }

        private void Inmultit_Click(object sender, EventArgs e)
        {
            if (flag == ' ')
            {
                flag = '*';

                String sir = FirstNumber.Text;
                if (sir[0] == '-')
                    var1 = -1 * Convert.ToDouble(sir.Substring(1));
                else
                    var1 = Convert.ToDouble(sir);
                FirstNumber.Text = null;
                virgula = false;
            }

        }

        private void Impartit_Click(object sender, EventArgs e)
        {
            if (flag == ' ')
            {
                flag = '/';

                String sir = FirstNumber.Text;
                if (sir[0] == '-')
                    var1 = -1 * Convert.ToDouble(sir.Substring(1));
                else
                    var1 = Convert.ToDouble(sir);
                FirstNumber.Text = null;
                virgula = false;
            }

        }


        private void Egal_Click(object sender, EventArgs e)
        {
            String sir = FirstNumber.Text;
            if (sir[0] == '-')
                var2 = -1 * Convert.ToDouble(sir.Substring(1));
            else
                var2 = Convert.ToDouble(sir);
            FirstNumber.Text = null;
            virgula = false;

            if (flag == '+' )
            {
                Result.Text = Convert.ToString(var1 + var2);
                flag = ' ';
            
            
            }
           else
             if (flag == '-')
            {
                Result.Text = Convert.ToString(var1 - var2);
                flag = ' ';


            }
            else
             if (flag == '*')
            {
                Result.Text = Convert.ToString(var1 * var2);
                flag = ' ';


            }
            else
             if (flag == '/')
            {
                Result.Text = Convert.ToString(var1 / var2);
                flag = ' ';


            }
            else
             if (flag == ' ')
            {
                FirstNumber.Text = null;
                Result.Text = Convert.ToString(var2);
            }

        }

        private void Negative_Click(object sender, EventArgs e)
        {
            if (FirstNumber.Text.Length==0)
                FirstNumber.Text = "-";


        }

        private void Clear_Click(object sender, EventArgs e)
        {
            string continut = FirstNumber.Text;
            int ultim = continut.Length;

            if (ultim != 0)
            {
                if (continut[ultim - 1] == ',')
                    virgula = false;



                FirstNumber.Text = continut.Remove(continut.Length - 1);
            }
        }

        private void Coma_Click(object sender, EventArgs e)
        {
            foreach (var i in FirstNumber.Text)
                if (i == ',')
                    virgula = true;

            if (FirstNumber.Text != null && virgula==false)
            {
                FirstNumber.Text += ",";
                virgula = true;
            }
        }

      

       
       

    }
}
