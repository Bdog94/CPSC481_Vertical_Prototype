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
        public static FoodItem food;
        public Boolean isAdd = false;
        public Boolean isRemove = false;
        public Boolean isSide = false;
        private int counter = 0;
        public SoupSalads()
        {
            InitializeComponent();
            lblTable.Content = MainWindow.tableNum;
            food = new FoodItem();
            stackPanelSalad.Children.Add(MainWindow.currentOrderInterface);
            stkPanelOptions.Children.Add(MainWindow.currentOrderSelection);
            
           
        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            stackPanelSalad.Children.Clear();
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            MainWindow.switchToMenuCategoriesView();
        }

        private void SelectTableButton_Click(object sender, RoutedEventArgs e)
        {
            SelectTablePopUp s = new SelectTablePopUp();
            s.Show();
            stackPanelSalad.Children.Remove(MainWindow.currentOrderInterface);
            stkPanelOptions.Children.Remove(MainWindow.currentOrderSelection);
            
        }

        public void clear()
        {
            stackPanelSalad.Children.Clear();
        }

        public void foodOrder(RoutedEventArgs e)
        {
            food = new FoodItem();
            Button b = e.Source as Button;
            food.FoodItemName = b.Content as String;
            MainWindow.currentOrderInterface.addFoodItem(food);
            counter = 0;
        }
        public void custom(RoutedEventArgs e)
        {
            while (counter <= 3){
                Button b = e.Source as Button;
                if (counter == 0){
                    if (isAdd == true)
                    {
                        food.FoodCustomizations = "Add: " + b.Content as String;
                        isAdd = false;
                    }
                    else if (isRemove == true)
                    {
                        food.FoodCustomizations = "Remove: " + b.Content as String;
                        isRemove = false;
                    }
                    else if (isSide == true)
                    {
                        food.FoodCustomizations = "Side: " + b.Content as String;
                        isSide = false;
                    }
                    else
                    {
                        food.FoodCustomizations = b.Content as String;
                    }
                   
                   counter++;
                   break;
                }
                else if (counter == 1){
                    if (isAdd == true)
                    {
                        food.FoodCustomizations1 = "Add: " + b.Content as String;
                        isAdd = false;
                    }
                    else if (isRemove == true)
                    {
                        food.FoodCustomizations1 = "Remove: " + b.Content as String;
                        isRemove = false;
                    }
                    else if (isSide == true)
                    {
                        food.FoodCustomizations1 = "Side: " + b.Content as String;
                        isSide = false;
                    }
                    else
                    {
                        food.FoodCustomizations1 = b.Content as String;
                    }
                    
                    counter++;
                    break;
                }
                else if (counter == 2){
                    if (isAdd == true)
                    {
                        food.FoodCustomizations2 = "Add: " + b.Content as String;
                        isAdd = false;
                    }
                    else if (isRemove == true)
                    {
                        food.FoodCustomizations2 = "Remove: " + b.Content as String;
                        isRemove = false;
                    }
                    else if (isSide == true)
                    {
                        food.FoodCustomizations2 = "Side: " + b.Content as String;
                        isSide = false;
                    }
                    else
                    {
                        food.FoodCustomizations2 = b.Content as String;
                    } 
                    counter++;
                    break;
                }
                else{
                    counter=0;
                    break;
                }
            }
        }

//Caesar Salad

        private void btnSoupSalad_Click(object sender, RoutedEventArgs e)
        {
            if (caeserDropDown.Visibility == System.Windows.Visibility.Hidden)
            {
                caeserDropDown.Visibility = System.Windows.Visibility.Visible;
            }
            else if (caeserDropDown.Visibility == System.Windows.Visibility.Visible)
            {
                caeserDropDown.Visibility = System.Windows.Visibility.Hidden;
            }
            foodOrder(e);
        }


        private void AllergySelect_Click(object sender, RoutedEventArgs e)
        {
                Allergies.Visibility = System.Windows.Visibility.Visible;
                caeserDropDown.Visibility = System.Windows.Visibility.Hidden;  
        }

        private void GlutenFree_Click(object sender, RoutedEventArgs e)
        {
            Allergies.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            caeserDropDown.Visibility = System.Windows.Visibility.Visible;
        }

        private void PF_Click(object sender, RoutedEventArgs e)
        {
            Allergies.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            caeserDropDown.Visibility = System.Windows.Visibility.Visible;
        }

        private void Vegan_Click(object sender, RoutedEventArgs e)
        {
            Allergies.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            caeserDropDown.Visibility = System.Windows.Visibility.Visible;
        }

        private void Paleo_Click(object sender, RoutedEventArgs e)
        {
            Allergies.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            caeserDropDown.Visibility = System.Windows.Visibility.Visible;
        }
        //actual bacon add button
        private void Baconbtn_Click(object sender, RoutedEventArgs e)
        {
            isAdd = true;
            AddCaesarBtn.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            caeserDropDown.Visibility = System.Windows.Visibility.Visible;
        }
        //actual remove button
        private void removeMenu_Click(object sender, RoutedEventArgs e)
        {
            isRemove = true;
            removeCaesarBtn.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            caeserDropDown.Visibility = System.Windows.Visibility.Visible;
        }

        private void addcaesar_Click(object sender, RoutedEventArgs e)
        {
            AddCaesarBtn.Visibility = System.Windows.Visibility.Visible;
            caeserDropDown.Visibility = System.Windows.Visibility.Hidden;   
        }
        private void removecaesar_Click(object sender, RoutedEventArgs e)
        {
            removeCaesarBtn.Visibility = System.Windows.Visibility.Visible;
            caeserDropDown.Visibility = System.Windows.Visibility.Hidden; 

        }
        //actual dressing button
        private void dressingside_Click(object sender, RoutedEventArgs e)
        {
            isSide = true;
            sideCaesarBtn.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            caeserDropDown.Visibility = System.Windows.Visibility.Visible;
        }
        private void sideCS_Click(object sender, RoutedEventArgs e)
        {
            sideCaesarBtn.Visibility = System.Windows.Visibility.Visible;
            caeserDropDown.Visibility = System.Windows.Visibility.Hidden;
        }



//house salad
        private void AllergySelect_Click1(object sender, RoutedEventArgs e)
        {
            Allergies_1.Visibility = System.Windows.Visibility.Visible;
            caeserDropDown_1.Visibility = System.Windows.Visibility.Hidden;
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
            foodOrder(e);
        }

        private void GlutenFree_Click1(object sender, RoutedEventArgs e)
        {
            Allergies_1.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            caeserDropDown_1.Visibility = System.Windows.Visibility.Visible;
        }
        private void PF_Click1(object sender, RoutedEventArgs e)
        {
            Allergies_1.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            caeserDropDown_1.Visibility = System.Windows.Visibility.Visible;
        }

        private void Vegan_Click1(object sender, RoutedEventArgs e)
        {
            Allergies_1.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            caeserDropDown_1.Visibility = System.Windows.Visibility.Visible;
        }

        private void Paleo_Click1(object sender, RoutedEventArgs e)
        {
            Allergies_1.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            caeserDropDown_1.Visibility = System.Windows.Visibility.Visible;
        }
        //add chicken button
        private void chickenHS_Click(object sender, RoutedEventArgs e)
        {
            isAdd = true;
            AddHS.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            caeserDropDown_1.Visibility = System.Windows.Visibility.Visible;
        }
        //remove dressing button
        private void dressingHS_Click(object sender, RoutedEventArgs e)
        {
            isRemove = true;
            custom(e);
            RemoveHS.Visibility = System.Windows.Visibility.Hidden;
            caeserDropDown_1.Visibility = System.Windows.Visibility.Visible;
        }
        private void removeHSbtn_Click(object sender, RoutedEventArgs e)
        {
            RemoveHS.Visibility = System.Windows.Visibility.Visible;
            caeserDropDown_1.Visibility = System.Windows.Visibility.Hidden;
        }
        private void AddHSbtn_Click(object sender, RoutedEventArgs e)
        {
            AddHS.Visibility = System.Windows.Visibility.Visible;
            caeserDropDown_1.Visibility = System.Windows.Visibility.Hidden;
        }
        private void dHSside_Click(object sender, RoutedEventArgs e)
        {
            isSide = true;
            custom(e);
            SideHS.Visibility = System.Windows.Visibility.Hidden;
            caeserDropDown_1.Visibility = System.Windows.Visibility.Visible;

        }
        private void sideHSbtn_Click(object sender, RoutedEventArgs e)
        {
            SideHS.Visibility = System.Windows.Visibility.Visible;
            caeserDropDown_1.Visibility = System.Windows.Visibility.Hidden;
        }

//clam soup
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
            foodOrder(e);
        }

        private void GlutenFree_Click2(object sender, RoutedEventArgs e)
        {
            Allergies_2.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            ClamSoupDropDown.Visibility = System.Windows.Visibility.Visible;

        }

        private void PF_Click2(object sender, RoutedEventArgs e)
        {
            Allergies_2.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            ClamSoupDropDown.Visibility = System.Windows.Visibility.Visible;
            
        }

        private void Vegan_Click2(object sender, RoutedEventArgs e)
        {
            Allergies_2.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            ClamSoupDropDown.Visibility = System.Windows.Visibility.Visible;

        }

        private void Paleo_Click2(object sender, RoutedEventArgs e)
        {
            Allergies_2.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            ClamSoupDropDown.Visibility = System.Windows.Visibility.Visible;
        }

        private void AllergySelect_Click2(object sender, RoutedEventArgs e)
        {
                Allergies_2.Visibility = System.Windows.Visibility.Visible;
                ClamSoupDropDown.Visibility = System.Windows.Visibility.Hidden;
            
        }

        private void addBtnCS_Click(object sender, RoutedEventArgs e)
        {

                addClamSoup.Visibility = System.Windows.Visibility.Visible;
                ClamSoupDropDown.Visibility = System.Windows.Visibility.Hidden;
        }

        private void sideBtnCS_Click(object sender, RoutedEventArgs e)
        {
                sideClamSoup.Visibility = System.Windows.Visibility.Visible;
                ClamSoupDropDown.Visibility = System.Windows.Visibility.Hidden;
        }
        //add crackers
        private void crackers_Click(object sender, RoutedEventArgs e)
        {
            isAdd = true;
            addClamSoup.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            ClamSoupDropDown.Visibility = System.Windows.Visibility.Visible;
        }
        //side garlic bread
        private void garlicBread_Click(object sender, RoutedEventArgs e)
        {
            isSide = true;
            sideClamSoup.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            ClamSoupDropDown.Visibility = System.Windows.Visibility.Visible;
        } 


        //tomato soup
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
            foodOrder(e);
        }

        private void AllergySelect3_Click(object sender, RoutedEventArgs e)
        {
                Allergies_3.Visibility = System.Windows.Visibility.Visible;
                TomatoSoupDropDown.Visibility = System.Windows.Visibility.Hidden;

        }

        private void GlutenFree_Click3(object sender, RoutedEventArgs e)
        {
                Allergies_3.Visibility = System.Windows.Visibility.Hidden;
                custom(e);
                TomatoSoupDropDown.Visibility = System.Windows.Visibility.Visible;
            
        }

        private void PF_Click3(object sender, RoutedEventArgs e)
        {
                Allergies_3.Visibility = System.Windows.Visibility.Hidden;
                custom(e);
                TomatoSoupDropDown.Visibility = System.Windows.Visibility.Visible;
        }
        

        private void Vegan_Click3(object sender, RoutedEventArgs e)
        {
                Allergies_3.Visibility = System.Windows.Visibility.Hidden;
                custom(e);
                TomatoSoupDropDown.Visibility = System.Windows.Visibility.Visible;
        }

        private void Paleo_Click3(object sender, RoutedEventArgs e)
        {
            Allergies_3.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            TomatoSoupDropDown.Visibility = System.Windows.Visibility.Visible;
        }
        private void AllergySelect_Click3(object sender, RoutedEventArgs e)
        {
                Allergies_3.Visibility = System.Windows.Visibility.Visible;
                TomatoSoupDropDown.Visibility = System.Windows.Visibility.Hidden;
        }

        private void cts_Click(object sender, RoutedEventArgs e)
        {
            isAdd = true;
            AddTS.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            TomatoSoupDropDown.Visibility = System.Windows.Visibility.Visible;
        }
        private void gcts_Click(object sender, RoutedEventArgs e)
        {
            isSide = true;
            RemoveTS.Visibility = System.Windows.Visibility.Hidden;
            custom(e);
            TomatoSoupDropDown.Visibility = System.Windows.Visibility.Visible;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddTS.Visibility = System.Windows.Visibility.Visible;
            TomatoSoupDropDown.Visibility = System.Windows.Visibility.Hidden;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RemoveTS.Visibility = System.Windows.Visibility.Visible;
            TomatoSoupDropDown.Visibility = System.Windows.Visibility.Hidden;
        }

        private void dropdownMenuUp(object sender, MouseWheelEventArgs e)
        {
            caeserDropDown.Visibility = System.Windows.Visibility.Hidden;
            TomatoSoupDropDown.Visibility = System.Windows.Visibility.Hidden;
            ClamSoupDropDown.Visibility = System.Windows.Visibility.Hidden;
            caeserDropDown_1.Visibility = System.Windows.Visibility.Hidden;
            Allergies_3.Visibility = System.Windows.Visibility.Hidden;
            Allergies_2.Visibility = System.Windows.Visibility.Hidden;
            Allergies_1.Visibility = System.Windows.Visibility.Hidden;
            Allergies.Visibility = System.Windows.Visibility.Hidden;
            addClamSoup.Visibility = System.Windows.Visibility.Hidden;
            sideClamSoup.Visibility = System.Windows.Visibility.Hidden;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.window = new SoupSalads();
            MainWindow.switchToAddNote();
        }

        private void AddNote(object sender, KeyEventArgs e)
        {
            food = new FoodItem();
            food.Note.Visibility = System.Windows.Visibility.Visible;
            food.Note.Text = "Note: " + MainWindow.Note;
            MainWindow.currentOrderInterface.addFoodItem(food);
            counter = 0;
        }

























    }
}
