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
    /// Interaction logic for SoupSalads.xaml
    /// </summary>
    public partial class SoupSalads : UserControl
    {
        public SoupSalads()
        {
            InitializeComponent();
            lblTable.Content = MainWindow.tableNum;
            stackPanelSalad.Children.Add(MainWindow.currentOrderInterface);
            stkPanelOptions.Children.Add(MainWindow.currentOrderSelection);
           
        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            stackPanelSalad.Children.Remove(MainWindow.currentOrderInterface);
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            MainWindow.switchToMenuCategoriesView();
        }

        private void SelectTableButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToTableView();
        }

        private void btnSoupSalad_Click(object sender, RoutedEventArgs e)
        {
            FoodItem f = new FoodItem();
            f.FoodItemName = "Caesar Salad";
            f.FoodCustomizations = "Stuff";
            MainWindow.currentOrderInterface.addFoodItem(f);
            if (caeserDropDown.Visibility == System.Windows.Visibility.Hidden)
            {
                caeserDropDown.Visibility = System.Windows.Visibility.Visible;
            }
            else if (caeserDropDown.Visibility == System.Windows.Visibility.Visible)
            {
                caeserDropDown.Visibility = System.Windows.Visibility.Hidden;
            }
            
        }

        private void AllergySelect_Click(object sender, RoutedEventArgs e)
        {
            if (Allergies.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies.Visibility = System.Windows.Visibility.Hidden;
            }
            if (caeserDropDown.Visibility == System.Windows.Visibility.Hidden)
            {
                caeserDropDown.Visibility = System.Windows.Visibility.Visible;
            }
            else if (caeserDropDown.Visibility == System.Windows.Visibility.Visible)
            {
                caeserDropDown.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void GlutenFree_Click(object sender, RoutedEventArgs e)
        {
            if (Allergies.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void PF_Click(object sender, RoutedEventArgs e)
        {
            if (Allergies.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void Vegan_Click(object sender, RoutedEventArgs e)
        {
            if (Allergies.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void Paleo_Click(object sender, RoutedEventArgs e)
        {
            if (Allergies.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void AllergySelect_Click1(object sender, RoutedEventArgs e)
        {
            if (Allergies_1.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_1.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_1.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_1.Visibility = System.Windows.Visibility.Hidden;
            }
            if (caeserDropDown_1.Visibility == System.Windows.Visibility.Hidden)
            {
                caeserDropDown_1.Visibility = System.Windows.Visibility.Visible;
            }
            else if (caeserDropDown_1.Visibility == System.Windows.Visibility.Visible)
            {
                caeserDropDown_1.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void HouseSalad_Click(object sender, RoutedEventArgs e)
        {
            if (caeserDropDown_1.Visibility == System.Windows.Visibility.Hidden)
            {
                caeserDropDown_1.Visibility = System.Windows.Visibility.Visible;
            }
            else if (caeserDropDown_1.Visibility == System.Windows.Visibility.Visible)
            {
                caeserDropDown_1.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void GlutenFree_Click1(object sender, RoutedEventArgs e)
        {
            if (Allergies_1.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_1.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_1.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_1.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void PF_Click1(object sender, RoutedEventArgs e)
        {
            if (Allergies_1.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_1.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_1.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_1.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void Vegan_Click1(object sender, RoutedEventArgs e)
        {
            if (Allergies_1.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_1.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_1.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_1.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void Paleo_Click1(object sender, RoutedEventArgs e)
        {
            if (Allergies_1.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_1.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_1.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_1.Visibility = System.Windows.Visibility.Hidden;
            }
        }
        private void GlutenFree_Click2(object sender, RoutedEventArgs e)
        {
            if (Allergies_2.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_2.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_2.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_2.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void PF_Click2(object sender, RoutedEventArgs e)
        {
            if (Allergies_2.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_2.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_2.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_2.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void Vegan_Click2(object sender, RoutedEventArgs e)
        {
            if (Allergies_2.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_2.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_2.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_2.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void Paleo_Click2(object sender, RoutedEventArgs e)
        {
            if (Allergies_2.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_2.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_2.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_2.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void AllergySelect_Click2(object sender, RoutedEventArgs e)
        {
            if (Allergies_2.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_2.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_2.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_2.Visibility = System.Windows.Visibility.Hidden;
            }
            if (ClamSoupDropDown.Visibility == System.Windows.Visibility.Hidden)
            {
                ClamSoupDropDown.Visibility = System.Windows.Visibility.Visible;
            }
            else if (ClamSoupDropDown.Visibility == System.Windows.Visibility.Visible)
            {
                ClamSoupDropDown.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void clamChowder_Click(object sender, RoutedEventArgs e)
        {
            if (ClamSoupDropDown.Visibility == System.Windows.Visibility.Hidden)
            {
                ClamSoupDropDown.Visibility = System.Windows.Visibility.Visible;
            }
            else if (ClamSoupDropDown.Visibility == System.Windows.Visibility.Visible)
            {
                ClamSoupDropDown.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void AllergySelect3_Click(object sender, RoutedEventArgs e)
        {
            if (Allergies_3.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_3.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_3.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_3.Visibility = System.Windows.Visibility.Hidden;
            }
            if (TomatoSoupDropDown.Visibility == System.Windows.Visibility.Hidden)
            {
                TomatoSoupDropDown.Visibility = System.Windows.Visibility.Visible;
            }
            else if (TomatoSoupDropDown.Visibility == System.Windows.Visibility.Visible)
            {
                TomatoSoupDropDown.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void GlutenFree_Click3(object sender, RoutedEventArgs e)
        {
            if (Allergies_3.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_3.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_3.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_3.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void PF_Click3(object sender, RoutedEventArgs e)
        {
            if (Allergies_3.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_3.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_3.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_3.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void Vegan_Click3(object sender, RoutedEventArgs e)
        {
            if (Allergies_3.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_3.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_3.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_3.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void Paleo_Click3(object sender, RoutedEventArgs e)
        {
            if (Allergies_3.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_3.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_3.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_3.Visibility = System.Windows.Visibility.Hidden;
            }
        }
        private void AllergySelect_Click3(object sender, RoutedEventArgs e)
        {
            if (Allergies_3.Visibility == System.Windows.Visibility.Hidden)
            {
                Allergies_3.Visibility = System.Windows.Visibility.Visible;
            }
            else if (Allergies_3.Visibility == System.Windows.Visibility.Visible)
            {
                Allergies_3.Visibility = System.Windows.Visibility.Hidden;
            }
            if (TomatoSoupDropDown.Visibility == System.Windows.Visibility.Hidden)
            {
                TomatoSoupDropDown.Visibility = System.Windows.Visibility.Visible;
            }
            else if (TomatoSoupDropDown.Visibility == System.Windows.Visibility.Visible)
            {
                TomatoSoupDropDown.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void TomatoSoup_Click(object sender, RoutedEventArgs e)
        {
            if (TomatoSoupDropDown.Visibility == System.Windows.Visibility.Hidden)
            {
                TomatoSoupDropDown.Visibility = System.Windows.Visibility.Visible;
            }
            else if (TomatoSoupDropDown.Visibility == System.Windows.Visibility.Visible)
            {
                TomatoSoupDropDown.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.window = new SoupSalads();
            MainWindow.switchToAddNote();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
