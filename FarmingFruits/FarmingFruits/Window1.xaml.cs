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

namespace FarmingFruits
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        FarmingFruitsEntities2 fe = new FarmingFruitsEntities2();
        public Fruit f = new Fruit();
        public Window1()
        {
            InitializeComponent();
        }
        public void load()
        {
            ListSee.ItemsSource = fe.Fruits.ToList();
        }

        private void ListSee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            f = (Fruit)ListSee.SelectedItem;
        }
    }
}
