using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZmieniaczKoloru
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float wielkosc = textBox1.Font.Size;

            if (radSmall.Checked)
            {
                wielkosc -= 1;
                textBox1.Font = new Font(textBox1.Font.Name, wielkosc,
                textBox1.Font.Style);

            }
            if (radBig.Checked)
            {
                wielkosc += 1;
                textBox1.Font = new Font(textBox1.Font.Name, wielkosc,
                textBox1.Font.Style);

            }
            if (radBigger.Checked)
            {
                wielkosc += 2;
                textBox1.Font = new Font(textBox1.Font.Name, wielkosc,
                textBox1.Font.Style);

            }
            if (checkBold.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            if (checkCurs.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            if (checkUnder.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            }
            if (radRed.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }
            if (radGreen.Checked)
            {
                textBox1.ForeColor = Color.Green;
            }
            if (radBlue.Checked)
            {
                textBox1.ForeColor = Color.Blue;
            }
        }
    }
}
