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
    /// Interaction logic for Dessert.xaml
    /// </summary>
    public partial class Dessert : UserControl
    {
        
        public Dessert()
        {
            InitializeComponent();
            lblTable_Copy.Content = MainWindow.tableNum;
            stkPanelOptions.Children.Add(MainWindow.currentOrderSelection);
            stackPanelDessert.Children.Add(MainWindow.currentOrderInterface);
        }
        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            stackPanelDessert.Children.Remove(MainWindow.currentOrderInterface);
            MainWindow.switchToMenuCategoriesView();
        }

        private void SelectTableButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToTableView();
        }

        private void note_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.window = new Dessert();
            MainWindow.switchToAddNote();

        }
    }
}
