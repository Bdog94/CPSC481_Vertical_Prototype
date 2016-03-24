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
    /// Interaction logic for CurrentOrder.xaml
    /// </summary>
    public partial class CurrentOrder : UserControl
    {
        public static StackPanel foodPanel;
        public static ScrollViewer scroller;
        public CurrentOrder()
        {
            InitializeComponent();
            foodPanel= stackPanel;
            scroller = svFoodItems;
        }

        public void addFoodItem(FoodItem f)
        {
            foodPanel.Children.Add(f);
        }

        public void Delete()
        {
            Stack<FoodItem> removeStack = new Stack<FoodItem>();
            foreach(object child in stackPanel.Children)
            {
            if (child is FoodItem )
            {
                FoodItem f = child as FoodItem;
                if (f.isChecked)
                {
                    removeStack.Push(f);
                    //stackPanel.Children.Remove(f);
                }
            }
            }

            foreach (FoodItem f in removeStack)
            {
                stackPanel.Children.Remove(f);
            }
        }

        public void Copy()
        {
            Stack<FoodItem> copyStack = new Stack<FoodItem>();
            foreach (object child in stackPanel.Children)
            {
                if (child is FoodItem)
                {
                    FoodItem f = child as FoodItem;
                    FoodItem fCopy = new FoodItem(f);
                    if (f.isChecked)
                    {
                        copyStack.Push(fCopy);
                        //stackPanel.Children.Remove(f);
                    }
                }
            }

            foreach (FoodItem f in copyStack)
            {
                stackPanel.Children.Add(f);
            }
        }
    }
}
