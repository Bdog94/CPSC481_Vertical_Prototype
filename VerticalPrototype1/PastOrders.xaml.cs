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
    /// Interaction logic for PastOrders.xaml
    /// </summary>
    public partial class PastOrders : UserControl
    {
        public PastOrders()
        {
            InitializeComponent();
            for (int i = 0; i < MainWindow.pastOrders.Count; i++)
            {
                Button btn = new Button();
                btn.Content = "Test " + i;
                btn.Tag = i;
                //btn.Click += new EventHandler(ShowCurrentOrderN);
                stackPanel.Children.Add(btn);
            }
        }

        void ShowCurrentOrderN(object sender, EventArgs e)
        {

        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToMenuCategoriesView();
        }
    }
}
