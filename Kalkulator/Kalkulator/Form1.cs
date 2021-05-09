using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        Double wynikValue = 0;
        String operacja = "";
        bool jestOperacja = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBoxWynik.Text == "0" || (jestOperacja))
                textBoxWynik.Clear();

            
            Button button=(Button)sender;
            jestOperacja = false;
            textBoxWynik.Text += button.Text;


        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (wynikValue != 0)
            {
                button16.PerformClick();
                operacja = button.Text;
                wynikValue = double.Parse(textBoxWynik.Text);
                jestOperacja  = true;
            }
            else
            {

               operacja = button.Text;
                wynikValue = Double.Parse(textBoxWynik.Text);
                jestOperacja = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBoxWynik.Text = "0";
            wynikValue = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch(operacja)
            {
                case "+":
                    textBoxWynik.Text = (wynikValue + Double.Parse(textBoxWynik.Text)).ToString();
                    break;
                case "-":
                    textBoxWynik.Text = (wynikValue - Double.Parse(textBoxWynik.Text)).ToString();
                    break;
                case "*":
                    textBoxWynik.Text = (wynikValue * Double.Parse(textBoxWynik.Text)).ToString();
                    break;
                case "/":
                    textBoxWynik.Text = (wynikValue / Double.Parse(textBoxWynik.Text)).ToString();
                    break;
                default:
                    break;

            }
            wynikValue = Double.Parse(textBoxWynik.Text);
        }
    }
}
