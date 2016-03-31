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
    /// Interaction logic for AddNoteWindow.xaml
    /// </summary>
    public partial class AddNoteWindow : Window
    {
        public AddNoteWindow()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Note.Clear();
        }

        private void AddToitem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Note = Note.Text;
            MainWindow.noteAdded = true;
            this.Close();
        } 


    }
}
