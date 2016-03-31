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
    /// Interaction logic for Drinks.xaml
    /// </summary>
    public partial class Drinks : UserControl
    {
        private Boolean isExtra = false;
        private Boolean isLight = false;
        public int counter = 0;
        public static FoodItem drinks;
        public Drinks()
        {
            InitializeComponent();
            MainWindow.currentOrderStackPanel = stackPanelDrinks;
            MainWindow.currentOptionsStackPanel = stkPanelOptions;
            lblTable_Copy.Content = MainWindow.tableNum;
            drinks = new FoodItem();
            stackPanelDrinks.Children.Add(MainWindow.currentOrderInterface);
            stkPanelOptions.Children.Add(MainWindow.currentOrderSelection);
        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            stackPanelDrinks.Children.Remove(MainWindow.currentOrderInterface);
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);

            MainWindow.switchToMenuCategoriesView();
        }

        private void SelectTableButton_Click(object sender, RoutedEventArgs e)
        {

            SelectTablePopUp s = new SelectTablePopUp();
            s.Show();

           // MainWindow.switchToTableView();

        }

        private void note_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.window = new Drinks();
            MainWindow.switchToAddNote();
        }

        public void drinkOrder(RoutedEventArgs e)
        {
            drinks = new FoodItem();
            Button b = e.Source as Button;
            drinks.FoodItemName = b.Content as String;
            MainWindow.currentOrderInterface.addFoodItem(drinks);
            counter = 0;
        }
        public void custom(RoutedEventArgs e)
        {
            while (counter <= 3)
            {
                Button b = e.Source as Button;
                if (counter == 0)
                {
                    if (isExtra == true)
                    {
                        drinks.FoodCustomizations = "Extra: " + b.Content as String;
                        isExtra = false;
                    }
                    else if (isLight == true)
                    {
                        drinks.FoodCustomizations = "Light: " + b.Content as String;
                        isLight = false;
                    }
                    
                    counter++;
                    break;
                }
                else if (counter == 1)
                {
                    if (isExtra == true)
                    {
                        drinks.FoodCustomizations1 = "Extra: " + b.Content as String;
                        isExtra = false;
                    }
                    else if (isLight == true)
                    {
                        drinks.FoodCustomizations1 = "Light: " + b.Content as String;
                        isLight = false;
                    }

                    counter++;
                    break;
                }
                else if (counter == 2)
                {
                    if (isExtra == true)
                    {
                        drinks.FoodCustomizations2 = "Extra: " + b.Content as String;
                        isExtra = false;
                    }
                    else if (isLight == true)
                    {
                        drinks.FoodCustomizations2 = "Light: " + b.Content as String;
                        isLight = false;
                    }
                    counter++;
                    break;
                }
                else
                {
                    counter = 0;
                    break;
                }
            }
            //Button b = e.Source as Button;
            //food.FoodCustomizations = b.Content as String;
        }



//appleJuice
        private void appleJuice_Click(object sender, RoutedEventArgs e)
        {
            if (appleJuiceDD.Visibility == System.Windows.Visibility.Hidden)
            {
                appleJuiceDD.Visibility = System.Windows.Visibility.Visible;
            }
            else if (appleJuiceDD.Visibility == System.Windows.Visibility.Visible)
            {
                appleJuiceDD.Visibility = System.Windows.Visibility.Hidden;
            }
            drinkOrder(e);
        }

        private void extraAJ_Click(object sender, RoutedEventArgs e)
        {
            appleJuiceDD.Visibility = System.Windows.Visibility.Hidden;
            ajExtraDD.Visibility = System.Windows.Visibility.Visible;
        }

        private void lightAJ_Click(object sender, RoutedEventArgs e)
        {
            appleJuiceDD.Visibility = System.Windows.Visibility.Hidden;
            ajLightDD.Visibility = System.Windows.Visibility.Visible;
        }

        private void xice_Click(object sender, RoutedEventArgs e)
        {
            isExtra = true;
            custom(e);
            ajExtraDD.Visibility = System.Windows.Visibility.Hidden;
            appleJuiceDD.Visibility = System.Windows.Visibility.Visible;
        }

        private void minusice_Click(object sender, RoutedEventArgs e)
        {
            isLight = true;
            custom(e);
            ajLightDD.Visibility = System.Windows.Visibility.Hidden;
            appleJuiceDD.Visibility = System.Windows.Visibility.Visible;
        }

//iced tea
        private void icedTea_Click(object sender, RoutedEventArgs e)
        {
            if (icedTeaDD.Visibility == System.Windows.Visibility.Hidden)
            {
                icedTeaDD.Visibility = System.Windows.Visibility.Visible;
            }
            else if (icedTea.Visibility == System.Windows.Visibility.Visible)
            {
                icedTeaDD.Visibility = System.Windows.Visibility.Hidden;
            }
            drinkOrder(e);
        }

        private void extraIT_Click(object sender, RoutedEventArgs e)
        {
            icedTeaDD.Visibility = System.Windows.Visibility.Hidden;
            itExtraDD.Visibility = System.Windows.Visibility.Visible;
        }

        private void lightIT_Click(object sender, RoutedEventArgs e)
        {
            icedTeaDD.Visibility = System.Windows.Visibility.Hidden;
            itLightDD.Visibility = System.Windows.Visibility.Visible;
        }

        private void xice2_Click(object sender, RoutedEventArgs e)
        {
            isExtra = true;
            custom(e);
            itExtraDD.Visibility = System.Windows.Visibility.Hidden;
            icedTeaDD.Visibility = System.Windows.Visibility.Visible;
        }

        private void lightice1_Click(object sender, RoutedEventArgs e)
        {
            isLight = true;
            custom(e);
            itLightDD.Visibility = System.Windows.Visibility.Hidden;
            icedTeaDD.Visibility = System.Windows.Visibility.Visible;
        }
//ginger ale
        private void gingerAle_Click(object sender, RoutedEventArgs e)
        {
            if (gingerAleDD.Visibility == System.Windows.Visibility.Hidden)
            {
                gingerAleDD.Visibility = System.Windows.Visibility.Visible;
            }
            else if (gingerAleDD.Visibility == System.Windows.Visibility.Visible)
            {
                gingerAleDD.Visibility = System.Windows.Visibility.Hidden;
            }
            drinkOrder(e);
        }
        private void extraGA_Click(object sender, RoutedEventArgs e)
        {
            gingerAleDD.Visibility = System.Windows.Visibility.Hidden;
            gaExtraDD.Visibility = System.Windows.Visibility.Visible;
        }

        private void lightGA_Click(object sender, RoutedEventArgs e)
        {
            gingerAleDD.Visibility = System.Windows.Visibility.Hidden;
            gaLightDD.Visibility = System.Windows.Visibility.Visible;
        }

        private void lightice_Click(object sender, RoutedEventArgs e)
        {
            isLight = true;
            custom(e);
            gaLightDD.Visibility = System.Windows.Visibility.Hidden;
            gingerAleDD.Visibility = System.Windows.Visibility.Visible;
        }

        private void xice3_Click(object sender, RoutedEventArgs e)
        {
            isExtra = true;
            custom(e);
            gaExtraDD.Visibility = System.Windows.Visibility.Hidden;
            gingerAleDD.Visibility = System.Windows.Visibility.Visible;
        }
//coca cola
        private void cocaCola_Click(object sender, RoutedEventArgs e)
        {
            if (cocaColaDD.Visibility == System.Windows.Visibility.Hidden)
            {
                cocaColaDD.Visibility = System.Windows.Visibility.Visible;
            }
            else if (cocaColaDD.Visibility == System.Windows.Visibility.Visible)
            {
                cocaColaDD.Visibility = System.Windows.Visibility.Hidden;
            }
            drinkOrder(e);
        }

        private void extraCC_Click(object sender, RoutedEventArgs e)
        {
            cocaColaDD.Visibility = System.Windows.Visibility.Hidden;
            ccExtraDD.Visibility = System.Windows.Visibility.Visible;
        }

        private void lightCC_Click(object sender, RoutedEventArgs e)
        {
            cocaColaDD.Visibility = System.Windows.Visibility.Hidden;
            ccLightDD.Visibility = System.Windows.Visibility.Visible;

        }

        private void extraice_Click(object sender, RoutedEventArgs e)
        {
            isExtra = true;
            custom(e);
            ccExtraDD.Visibility = System.Windows.Visibility.Hidden;
            cocaColaDD.Visibility = System.Windows.Visibility.Visible;
        }

        private void lighticecc_Click(object sender, RoutedEventArgs e)
        {
            isLight = true;
            custom(e);
            ccLightDD.Visibility = System.Windows.Visibility.Hidden;
            cocaColaDD.Visibility = System.Windows.Visibility.Visible;
        }

        private void dropDownUp(object sender, MouseWheelEventArgs e)
        {
            cocaColaDD.Visibility = System.Windows.Visibility.Hidden;
            gingerAleDD.Visibility = System.Windows.Visibility.Hidden;
            appleJuiceDD.Visibility = System.Windows.Visibility.Hidden;
            icedTeaDD.Visibility = System.Windows.Visibility.Hidden;
            ccLightDD.Visibility = System.Windows.Visibility.Hidden;
            ccExtraDD.Visibility = System.Windows.Visibility.Hidden;
            gaLightDD.Visibility = System.Windows.Visibility.Hidden;
            gaExtraDD.Visibility = System.Windows.Visibility.Hidden;
            ajLightDD.Visibility = System.Windows.Visibility.Hidden;
            ajExtraDD.Visibility = System.Windows.Visibility.Hidden;
            itLightDD.Visibility = System.Windows.Visibility.Hidden;
            itExtraDD.Visibility = System.Windows.Visibility.Hidden;
        }


     private void Past_Orders(object sender, RoutedEventArgs e)
     {
         stkPanelOptions.Children.Clear();
         stackPanelDrinks.Children.Clear();
         MainWindow.switchToPastOrders();
     }


    }
}
