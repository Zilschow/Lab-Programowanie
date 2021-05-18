using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulatorBMI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void radMen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radKob_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (checkBox1.Checked & (radKob.Checked | radMen.Checked))
            {
                try
                {
                    float wz = float.Parse(textBox1.Text);

                    label3.Text = (wz - 100).ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie podano wzrostu", "Błąd", MessageBoxButtons.OK);
                    throw;
                }
            }
            else
            {

                if (checkBox2.Checked & radKob.Checked)
                {
                    try
                    {
                        float wz = float.Parse(textBox1.Text);

                        label3.Text = ((wz - 100) * 0.85).ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie podano wzrostu", "Błąd", MessageBoxButtons.OK);

                        throw;

                    }
                }
                else
                {
                    if (checkBox2.Checked & radMen.Checked)
                    {

                        try
                        {
                            float wz = float.Parse(textBox1.Text);

                            label3.Text = ((wz - 100) * 0.9).ToString();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Nie podano wzrostuMMM", "Błąd", MessageBoxButtons.OK);
                        }

                    }
                }

            }

        }
    }
}

