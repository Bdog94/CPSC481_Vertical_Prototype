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
    /// Interaction logic for WineBeer.xaml
    /// </summary>
    public partial class WineBeer : UserControl
    {
        public WineBeer()
        {
            InitializeComponent();
            stackPanelWineAndBeer.Children.Add(MainWindow.currentOrderInterface);
            stkPanelOptions.Children.Add(MainWindow.currentOrderSelection);
            lblTable.Content = MainWindow.tableNum;
        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            stackPanelWineAndBeer.Children.Remove(MainWindow.currentOrderInterface);
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            MainWindow.switchToMenuCategoriesView();
        }

        private void SelectTableButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToTableView();
        }

        private void note_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.window = new WineBeer();
            MainWindow.switchToAddNote();
        }
    }
}
