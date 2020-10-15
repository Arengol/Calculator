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

namespace Калькулятор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x, y, z;
            //Считаем значение из первого  lineEdit
            string S1 = TextBox.Text;
            //Переведем значение в число
            x = Convert.ToInt32(S1);
            //Считаем значение из второго LineEdit
            string S2 = TextBox1.Text;
            //Переведем значение в число
            y = Convert.ToInt32(S2);
            //Выведем результат
            z = x * y;
            TextBox2.Text = z.ToString();
        }
    }
}
