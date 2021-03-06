﻿using System;
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
        public SoupSalads()
        {
            InitializeComponent();
            lblTable.Content = MainWindow.tableNum;
        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToMenuCategoriesView();
        }

        private void SelectTableButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToTableView();
        }

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
            
        }
    }
}
