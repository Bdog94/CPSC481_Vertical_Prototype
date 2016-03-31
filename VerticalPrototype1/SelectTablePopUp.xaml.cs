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

namespace VerticalPrototype1
{
    /// <summary>
    /// Interaction logic for SelectTablePopUp.xaml
    /// </summary>
    public partial class SelectTablePopUp : Window
    {
        public SelectTablePopUp()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.clearStackPanel();
            MainWindow.ClearCurrentOptionsStackPanel();
            MainWindow.currentOrderInterface = new CurrentOrder();
            //reset order
            MainWindow.switchToTableView();
        }
    }
}
