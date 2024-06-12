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

namespace Lab1._1
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
            if (double.TryParse(A.Text, out double a) && double.TryParse(B.Text, out double b))
            {
                if (sender == buttonPlus)
                {
                    textResult.Text = (a + b).ToString();
                }
                else if (sender == buttonMinus)
                {
                    textResult.Text = (a - b).ToString();
                }
                else if (sender == buttonMultiply)
                {
                    textResult.Text = (a * b).ToString();
                }
                else if (sender == buttonDivide && b != 0)
                {
                    textResult.Text = (a / b).ToString();
                }
                else
                {
                    textResult.Text = "Error: Division by zero";
                }
            }
            else
            {
                textResult.Text = "Error: Invalid input";
            }
        }
    }
}
