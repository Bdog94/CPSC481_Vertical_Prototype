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
using System.Windows.Shapes;

namespace VerticalPrototype1
{
    /// <summary>
    /// Interaction logic for SendToKitchen.xaml
    /// </summary>
    public partial class SendToKitchen : Window
    {
        
        public SendToKitchen()
        {
            InitializeComponent();
        }

        //confirm
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.SendToKitchen();
            MessageBox.Show("The Order Was Sent to The Kitchen!");
            this.Close();

        }
        //cancel
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.SendToKitchen();
            this.Close();
        }
    }
}
