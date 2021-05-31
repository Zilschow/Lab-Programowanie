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
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace lab4_zad1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>


    public partial class Window1 : Window
    {
        public Student student;
        public Window1(Student student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                tbImie.Text = student.imie;
                tbNazwisko.Text = student.nazwisko;
                tbNumer.Text = student.NrIndeksu.ToString();
                tbWydzial.Text = student.wydzial;
            }
            this.student = student ?? new Student();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(tbImie.Text, @"^\p{Lu}\p{Ll}{1,12}$") ||
                !Regex.IsMatch(tbNazwisko.Text, @"^\p{Lu}\p{Ll}{1,12}$") ||
                !Regex.IsMatch(tbWydzial.Text, @"^\p{Lu}{1,12}$") ||
                !Regex.IsMatch(tbNumer.Text, @"^[0-9]{4,10}$"))
            {
                MessageBox.Show("Podano bledne dane.");
                return;
            }
            student.imie = tbImie.Text;
            student.nazwisko = tbNazwisko.Text;
            student.wydzial = tbWydzial.Text;
            student.NrIndeksu = int.Parse(tbNumer.Text);

            this.DialogResult = true;
        }
    }
}
