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

        CurrentOrder currentOrderBeingShown;
        public PastOrders()
        {
            InitializeComponent();
            for (int i = 0; i < MainWindow.pastOrders.Count; i++)
            {
                Button btn = new Button();
                btn.Content = "Test " + i;
                btn.Tag = i;
                btn.Click += new RoutedEventHandler(ShowCurrentOrderN);
                stackPanel.Children.Add(btn);
            }
        }

        
        private void Delete_Button(object sender, RoutedEventArgs e)
        {
           currentOrderBeingShown.Delete();
        }

        private void Copy(object sender, RoutedEventArgs e)
        {
            currentOrderBeingShown.Copy();
        }

       private void SendToKitchen(object sender, RoutedEventArgs e)
        {
            SendToKitchen s = new SendToKitchen();
            s.Show();
        }

        private void Add_Note(object sender, RoutedEventArgs e)
        {

        }

        private void ShowCurrentOrderN(object sender, RoutedEventArgs e)
        {
            stackPanel1.Children.Clear();
            Button b = e.Source as Button;
            CurrentOrder[] array = MainWindow.pastOrders.ToArray();
            stackPanel1.Children.Add(array[(int) b.Tag]);
            currentOrderBeingShown = array[(int)b.Tag];
            //stackPanel1.Children.Add(MainWindow.pastOrders.ElementAt<CurrentOrder>(b.Tag));

        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            stackPanel1.Children.Clear();
            MainWindow.switchToMenuCategoriesView();
        }
    }
}
