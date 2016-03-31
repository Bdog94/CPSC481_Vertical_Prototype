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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class Sides: UserControl
    {
        public Sides()
        {
            InitializeComponent();
            stkPanelOptions.Children.Add(MainWindow.currentOrderSelection);
            stackPanelSides.Children.Add(MainWindow.currentOrderInterface);
            lblTable_Copy.Content = MainWindow.tableNum;
        }
        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            stackPanelSides.Children.Remove(MainWindow.currentOrderInterface);
            MainWindow.switchToMenuCategoriesView();
        }

        private void SelectTableButton_Click(object sender, RoutedEventArgs e)
        {

            SelectTablePopUp s = new SelectTablePopUp();
            s.Show();

            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            stackPanelSides.Children.Remove(MainWindow.currentOrderInterface);
            //MainWindow.switchToTableView();

        }

        private void note_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.window = new Sides();
            MainWindow.switchToAddNote();
        }

        private void Past_Orders(object sender, RoutedEventArgs e)
        {
            stkPanelOptions.Children.Clear();
            stackPanelSides.Children.Clear();
            MainWindow.switchToPastOrders();
        }
    }
}
