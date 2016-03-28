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
    /// Interaction logic for FoodItem.xaml
    /// </summary>
    public partial class FoodItem : UserControl
    {
        private string foodItemName;
        public bool isChecked = false;
        public static bool customIsChecked = false;
        

        public string FoodItemName
        {
            get { return foodItemName; }
            set { foodItemName = value;
            lblFoodName.Content = foodItemName;
            }
        }

        private string foodCustomizations;
        private string foodCustomizations1;
        private string foodCustomizations2;

        public string FoodCustomizations
        {
            get { return foodCustomizations; }
            set { foodCustomizations = value;
            lblCustom.Content = foodCustomizations;
            }
        }
        public string FoodCustomizations1
        {
            get { return foodCustomizations1; }
            set
            {
                foodCustomizations1 = value;
                lblCustom2.Content = foodCustomizations1;
            }
        }

        public string FoodCustomizations2
        {
            get { return foodCustomizations2; }
            set
            {
                foodCustomizations2 = value;
                lblCustom3.Content = foodCustomizations2;
            }
        }

        public FoodItem()
        {
            InitializeComponent();
        }

        public FoodItem(FoodItem f)
        {
            InitializeComponent();
            foodItemName = f.foodItemName;
            lblFoodName.Content = foodItemName;

            foodCustomizations = f.foodCustomizations;
            lblCustom.Content = foodCustomizations;

            foodCustomizations1 = f.foodCustomizations1;
            lblCustom2.Content = foodCustomizations1;

            foodCustomizations2 = f.foodCustomizations2;
            lblCustom3.Content = foodCustomizations2;

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

            if (isChecked)
            {
                isChecked = false;
            }
            else
            {
                isChecked = true;
            }
        }

        private void customizationsChecker(object sender, RoutedEventArgs e)
        {
            if (customIsChecked)
            {
                customIsChecked = false;
            }
            else
            {
                customIsChecked = true;
            }
        }

    }
}
