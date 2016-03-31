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
    /// Interaction logic for CurrentOrderSelection.xaml
    /// </summary>
    public partial class CurrentOrderSelection : UserControl
    {
        public CurrentOrderSelection()
        {
            InitializeComponent();
        }


        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            MainWindow.currentOrderInterface.Delete();
        }

       

       private void SendToKitchen(object sender, RoutedEventArgs e)
       {
           SendToKitchen s = new SendToKitchen();
           s.Show();
       }

       private void Add_Note(object sender, RoutedEventArgs e)
       {
           AddNoteWindow  an= new AddNoteWindow();
           an.Show();
       }


       private void Copy(object sender, RoutedEventArgs e)
       {
           MainWindow.currentOrderInterface.Copy();

       }


    }
}
