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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static MainWindow m;
        public MainWindow()
        {
            m = this;
            InitializeComponent();
            SelectTable lw = new SelectTable();
            stackPanel.Children.Add(lw);
        }

        public static void switchToTableView()
        {
            SelectTable st = new SelectTable();
            m.switchTo(st);
        }

        private void switchTo(UserControl u)
        {
            stackPanel.Children.Clear();
            stackPanel.Children.Add(u);
        }

        public static void switchToMenuCategoriesView()
        {
            MenuCategories mc = new MenuCategories();
            m.switchTo(mc);
        }
        public static void switchToSoupSalad()
        {
            SoupSalads mc = new SoupSalads();
            m.switchTo(mc);
        }

    }
}
