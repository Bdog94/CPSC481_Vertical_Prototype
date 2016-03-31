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
            MainWindow.currentOptionsStackPanel = stkPanelOptions;
            MainWindow.currentOrderStackPanel = stackPanelCatag;
            stkPanelOptions.Children.Add(MainWindow.currentOrderSelection);
            stackPanelCatag.Children.Add(MainWindow.currentOrderInterface);
            lblTable.Content = MainWindow.tableNum;
            //stackPanelCategories.Children.Add(MainWindow.currentOrderInterface);
            //stkPanelOptions1.Children.Add(MainWindow.currentOrderSelection);
        }

        private void SelectTableButton_Click(object sender, RoutedEventArgs e)
        {
            SelectTablePopUp s = new SelectTablePopUp();
            s.Show();
        }

        private void btnSoupSalad_Click(object sender, RoutedEventArgs e)
        {
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            stackPanelCatag.Children.Remove(MainWindow.currentOrderInterface);
            MainWindow.switchToSoupSalad();
        }

        private void btnNonAlcohol_Click(object sender, RoutedEventArgs e)
        {
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            stackPanelCatag.Children.Remove(MainWindow.currentOrderInterface);
            MainWindow.switchToBeverages();
        }

        private void btnAlcohol_Click(object sender, RoutedEventArgs e)
        {
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            stackPanelCatag.Children.Remove(MainWindow.currentOrderInterface);
            MainWindow.switchToAlcohol();
        }

        private void Starters_Click(object sender, RoutedEventArgs e)
        {
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            stackPanelCatag.Children.Remove(MainWindow.currentOrderInterface);
            MainWindow.switchToStarters();
        }

        private void Meals_Click(object sender, RoutedEventArgs e)
        {
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            stackPanelCatag.Children.Remove(MainWindow.currentOrderInterface);
            MainWindow.switchToMeals();
        }

        private void dessert_Click(object sender, RoutedEventArgs e)
        {
            
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            stackPanelCatag.Children.Remove(MainWindow.currentOrderInterface);
            MainWindow.switchToDessert();
        }

        private void Sides_Click(object sender, RoutedEventArgs e)
        {
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            stackPanelCatag.Children.Remove(MainWindow.currentOrderInterface);
            MainWindow.switchToSides();
        }

        private void Specials_Click_1(object sender, RoutedEventArgs e)
        {
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            stackPanelCatag.Children.Remove(MainWindow.currentOrderInterface);
            MainWindow.switchToKids();
        }

        private void note_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.window = new MenuCategories();
            MainWindow.switchToAddNote();
        }

        private void PastOrders(object sender, RoutedEventArgs e)
        {

            stkPanelOptions.Children.Clear();
            stackPanelCatag.Children.Clear();
            MainWindow.switchToPastOrders();
        }

        private void addNote(object sender, KeyEventArgs e)
        {
            FoodItem food = new FoodItem();
            food.Note.Visibility = System.Windows.Visibility.Visible;
            food.Note.Text = "Note: " + MainWindow.Note;
            MainWindow.currentOrderInterface.addFoodItem(food);
           
        }
    }
}
