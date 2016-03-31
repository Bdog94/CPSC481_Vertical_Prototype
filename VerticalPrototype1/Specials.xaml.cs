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

namespace VerticalPrototype1
{
    /// <summary>
    /// Interaction logic for Specials.xaml
    /// </summary>
    public partial class Specials : UserControl
    {
        public Specials()
        {
            InitializeComponent();
            stackPanelSpecials.Children.Add(MainWindow.currentOrderInterface);
            stkPanelOptions.Children.Add(MainWindow.currentOrderSelection);
            lblTable_Copy.Content = MainWindow.tableNum;
        }
        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            stackPanelSpecials.Children.Remove(MainWindow.currentOrderInterface);
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            MainWindow.switchToMenuCategoriesView();
        }

        private void SelectTableButton_Click(object sender, RoutedEventArgs e)
        {
            stackPanelSpecials.Children.Remove(MainWindow.currentOrderInterface);
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            SelectTablePopUp s = new SelectTablePopUp();
            s.Show();
        }

        private void note_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.window = new Specials();
            MainWindow.switchToAddNote();
        }

        private void Past_Orders(object sender, RoutedEventArgs e)
        {
            stkPanelOptions.Children.Clear();
            stackPanelSpecials.Children.Clear();
            MainWindow.switchToPastOrders();
        }

        
    }
}
