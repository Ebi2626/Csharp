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
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double result = 0.0d;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Sum(object sender, RoutedEventArgs e)
        {
            double val1 = Convert.ToDouble(box1.Text);
            double val2 = Convert.ToDouble(box2.Text);
            result = (double)val1 + (double)val2;

            resultBox.Content = result;
        }
        private void Button_Minus(object sender, RoutedEventArgs e)
        {
            double val1 = Convert.ToDouble(box1.Text);
            double val2 = Convert.ToDouble(box2.Text);
            result = (double)val1 - (double)val2;

            resultBox.Content = result;
        }
        private void Button_Multiply(object sender, RoutedEventArgs e)
        {
            double val1 = Convert.ToDouble(box1.Text);
            double val2 = Convert.ToDouble(box2.Text);
            result = (double)val1 * (double)val2;

            resultBox.Content = result;
        }
        private void Button_Divide(object sender, RoutedEventArgs e)
        {
            double val1 = Convert.ToDouble(box1.Text);
            double val2 = Convert.ToDouble(box2.Text);
            result = (double)val1 / (double)val2;

            resultBox.Content = result;
        }
        private void Button_Sqrt(object sender, RoutedEventArgs e)
        {
            double val1 = Convert.ToDouble(box1.Text);
            result = Math.Sqrt((double)val1);

            resultBox.Content = result;
        }

        private void box2_TextChanged(object sender, TextChangedEventArgs e)
        {            
            try {
                Convert.ToDouble(box2.Text);
            } catch (System.FormatException ex)
            {
                MessageBox.Show("Error " + ex);
                box2.Text = "";
            }
            
        }

        private void box1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Convert.ToDouble(box1.Text);
              
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Error " + ex);
                box1.Text = "";
            }

        }
    }
}
