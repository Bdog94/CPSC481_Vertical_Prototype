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
        public bool isChecked;

        public string FoodItemName
        {
            get { return foodItemName; }
            set { foodItemName = value;
            lblFoodName.Content = foodItemName;
            }
        }

        private string foodCustomizations;

        public string FoodCustomizations
        {
            get { return foodCustomizations; }
            set { foodCustomizations = value;
            lblFoodName.Content = foodCustomizations;
            }
        }


        public FoodItem()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
