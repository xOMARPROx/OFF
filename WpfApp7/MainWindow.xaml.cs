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

namespace WpfApp7
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(text1.Text);
                int n2 = Convert.ToInt32(text2.Text);
                int add = n1 + n2;
                label1.Content = add.ToString();
            }
            catch (Exception ex)
            {
                label1.Content = "enter your number";

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(text1.Text);
                int n2 = Convert.ToInt32(text2.Text);
                int sub = n1 - n2;
                label1.Content = sub.ToString();
            }
            catch (Exception ex)
            {
                label1.Content = "enter your number";

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(text1.Text);
                int n2 = Convert.ToInt32(text2.Text);
                int mult = n1 * n2;
                label1.Content = mult.ToString();
            }
            catch (Exception ex)
            {
                label1.Content = "enter your number";


            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(text1.Text);
                int n2 = Convert.ToInt32(text2.Text);
                int divd = n1 / n2;
                label1.Content = divd.ToString();
            }
            catch (Exception ex)
            {
                label1.Content = "no divded by zero";

            }
        }

        private void text2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void text1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
