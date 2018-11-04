using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Duval
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double C1;
        double C2;
        double a;
        double b;
        double N;
        double F;


        double X;
        double C;



        public MainWindow()
        {
            InitializeComponent();
        }


        private void UIElement_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Regex.Match(e.Text, @"[0-9,]").Success))
            {
                e.Handled = true;
            }
        }


        private void Enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button1.IsDefault = true;
            }
        }
        private void Space(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }



        private void Button1_Click(object sender, RoutedEventArgs e)
        {


            {
                try
                {
                    C1 = Convert.ToDouble(TextBox1.Text);
                    C2 = Convert.ToDouble(TextBox2.Text);
                    a = Convert.ToDouble(TextBox3.Text);
                    b = Convert.ToDouble(TextBox4.Text);
                    N = Convert.ToDouble(TextBox5.Text);
                    F = Convert.ToDouble(TextBox6.Text);

                    X = (a - b);
                    C = (C1 - C2);

                    double З = F * N * (1 - (C + X) / 100);
                    double q = 1 * N * (1 - (C + X) / 100);
                    double w = F * 1 * (1 - (C + X) / 100);


                    Label4.Content = Convert.ToString(З);
                    Label5.Content = Convert.ToString(q);
                    Label6.Content = Convert.ToString(w);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Введені не всі данні або недопустимі символи");

                }
            }

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = null;
            TextBox2.Text = null;
            TextBox3.Text = null;
            TextBox4.Text = null;
            TextBox5.Text = null;
            TextBox6.Text = null;
        }
    }
}

