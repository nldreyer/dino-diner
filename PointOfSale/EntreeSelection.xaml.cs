﻿/*  EntreeSelection.xaml.cs
*   Author: Nicholas Dreyer
*/
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// EntreeSelection constructor
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add Brontowurst to order and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddBrontowurst(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new Brontowurst());
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Add Dino-Nuggets to order and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddDinoNuggets(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new DinoNuggets());
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Add Steakosaurus Burger to order and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddSteakosaurus(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new SteakosaurusBurger());
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Add T-Rex King Burger to order and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddTRexKingBurger(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new TRexKingBurger());
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Add Pterodactyl Wings to order and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddPterodactylWings(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new PterodactylWings());
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Add Prehistoric PB&J to order and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddPrehistoricPBJ(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new PrehistoricPBJ());
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Add VelociWrap to order and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddVelociWrap(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new VelociWrap());
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
