using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void butSuma_Click(object sender, RoutedEventArgs e)
        {
            double x = Double.Parse(liczba1.Text);
            double y = Double.Parse(liczba2.Text);

            try
            {
                //double x = Double.Parse(liczba1.Text);
                // double y = Double.Parse(liczba2.Text);

                wynik.Text = (x + y).ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Nie podano jednej z liczb", "Błąd");
                throw;
            }
        }

        private void butRoz_Click(object sender, RoutedEventArgs e)
        {
            double x = Double.Parse(liczba1.Text);
            double y = Double.Parse(liczba2.Text);
            try
            {
               //double x = Double.Parse(liczba1.Text);
               //double y = Double.Parse(liczba2.Text);

                wynik.Text = (x - y).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie podano jednej z liczb", "Błąd");
                throw;
            }
        }

        private void butIlocz_Click(object sender, RoutedEventArgs e)
        {
            double x = Double.Parse(liczba1.Text);
            double y = Double.Parse(liczba2.Text);
            try
            {
               //double x = Double.Parse(liczba1.Text);
               //double y = Double.Parse(liczba2.Text);

                wynik.Text = (x * y).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie podano jednej z liczb", "Błąd");
                throw;
            }
        }

        private void butIloraz_Click(object sender, RoutedEventArgs e)
        {
            double x = Double.Parse(liczba1.Text);
            double y = Double.Parse(liczba2.Text);
            if(x != 0 & y != 0)
            {
                try
                {
                   //double x = Double.Parse(liczba1.Text);
                   //double y = Double.Parse(liczba2.Text);

                    wynik.Text = (x / y).ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie podano jednej z liczb", "Błąd");
                    throw;
                }
            }
            else
            {
                wynik.Text = "Dzielenie przez zero jest niemożliwe";
                MessageBox.Show("Dzielenie przez zero jest niemożliwe", "Błąd logiczny");
            }
           
        }
    }
}
