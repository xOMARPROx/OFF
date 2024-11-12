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

namespace FarmingFruits
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public FarmingFruitsEntities2 Farming = new FarmingFruitsEntities2();
        public UserDeatil deatil;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void UserTextMethod(object sender, TextChangedEventArgs e)
        {

        }
        private void PassTextMethod(object sender, TextChangedEventArgs e)
        {

        }
        private void ConfirmBtnMethod(object sender, RoutedEventArgs e)
        {
            using (var Check = new FarmingFruitsEntities2())
            {
                var user = Check.UserDeatils.SingleOrDefault(u => u.Usr_Name == UsrText.Text && u.Usr_Pass == PassText.Password);
                if (user != deatil)
                {
                    MessageBox.Show("done");
                    Window1 w = new Window1();
                    w.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error"); ;
                }
            }
        }
    }
}
