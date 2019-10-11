﻿/*  CustomizeComboSelection.xaml.cs
*   Author: Nicholas Dreyer
*/
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to SideSelection.xaml
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void SelectSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }

        /// <summary>
        /// Navigates to DrinkSelection.xaml
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
