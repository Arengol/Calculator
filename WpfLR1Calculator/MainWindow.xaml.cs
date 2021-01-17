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

namespace WpfLR1Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string leftop = "";
        string ritop = "";
        string op = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "7";
            if (op == "") leftop += "7";
            else ritop += "7";
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "8";
            if (op == "") leftop += "8";
            else ritop += "8";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "9";
            if (op == "") leftop += "9";
            else ritop += "9";
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "4";
            if (op == "") leftop += "4";
            else ritop += "4";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "5";
            if (op == "") leftop += "5";
            else ritop += "5";
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "6";
            if (op == "") leftop += "6";
            else ritop += "6";
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "1";
            if (op == "") leftop += "1";
            else ritop += "1";
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "2";
            if (op == "") leftop += "2";
            else ritop += "2";
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "3";
            if (op == "") leftop += "3";
            else ritop += "3";
        }
        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "0";
            if (op == "") leftop += "0";
            else ritop += "0";
        }
        private void Buttonplus_Click(object sender, RoutedEventArgs e)
        {
            
            textBox.Text += " + ";
            op = "+";
        }
        private void Buttonminus_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += " - ";
            op = "-";
        }
        private void Buttonravno_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            if (op == "+")
            { 
                leftop = lr1calc.Class1.plus(leftop, ritop);
            }
            if (op == "-")
            {
                leftop = Minus.Class1.minus(leftop, ritop);
            }
            textBox.Text += leftop;
            op = "";
            ritop = "";
        }
        private void Buttonpoint_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += ",";
            if (op == "") leftop += ",";
            else ritop += ",";
        }

       
    }
}
