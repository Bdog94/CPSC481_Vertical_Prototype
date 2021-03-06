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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static String tableNum;
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
        public static void switchToBeverages()
        {
            Drinks d = new Drinks();
            m.switchTo(d);
        }
        public static void switchToAlcohol()
        {
            WineBeer wb = new WineBeer();
            m.switchTo(wb);
        }
        public static void switchToStarters()
        {
            Starters s = new Starters();
            m.switchTo(s);
        }
        public static void switchToMeals()
        {
            Meals ml = new Meals();
            m.switchTo(ml);
        }
        public static void switchToDessert()
        {
            Dessert d = new Dessert();
            m.switchTo(d);
        }
        public static void switchToSides()
        {
            Sides d = new Sides();
            m.switchTo(d);
        }
        public static void switchToKids()
        {
            Specials s = new Specials();
            m.switchTo(s);
        }

    }
}
