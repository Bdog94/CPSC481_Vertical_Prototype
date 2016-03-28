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
    /// Interaction logic for MenuCategories.xaml
    /// </summary>
    public partial class MenuCategories : UserControl
    {
        //static MainWindow m;
        public MenuCategories()
        {
            InitializeComponent();
            lblTable.Content = MainWindow.tableNum;
            //stackPanelCategories.Children.Add(MainWindow.currentOrderInterface);
            //stkPanelOptions1.Children.Add(MainWindow.currentOrderSelection);
        }

        private void SelectTableButton_Click(object sender, RoutedEventArgs e)
        {
            SelectTablePopUp s = new SelectTablePopUp();
            s.Show();
            
            //stackPanelCategories.Children.Remove(MainWindow.currentOrderInterface);
            //stkPanelOptions1.Children.Remove(MainWindow.currentOrderSelection);
        }

        private void btnSoupSalad_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToSoupSalad();
        }

        private void btnNonAlcohol_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToBeverages();
        }

        private void btnAlcohol_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToAlcohol();
        }

        private void Starters_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToStarters();
        }

        private void Meals_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToMeals();
        }

        private void dessert_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToDessert();
        }

        private void Sides_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToSides();
        }

        private void Specials_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToKids();
        }

        private void note_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.window = new MenuCategories();
            MainWindow.switchToAddNote();
        }
    }
}
