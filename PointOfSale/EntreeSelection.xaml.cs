/*  EntreeSelection.xaml.cs
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
            EntreeClicked(new Brontowurst());
        }

        /// <summary>
        /// Add Dino-Nuggets to order and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddDinoNuggets(object sender, RoutedEventArgs e)
        {
            EntreeClicked(new DinoNuggets());
        }

        /// <summary>
        /// Add Steakosaurus Burger to order and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddSteakosaurus(object sender, RoutedEventArgs e)
        {
            EntreeClicked(new SteakosaurusBurger());
        }

        /// <summary>
        /// Add T-Rex King Burger to order and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddTRexKingBurger(object sender, RoutedEventArgs e)
        {
            EntreeClicked(new TRexKingBurger());
        }

        /// <summary>
        /// Add Pterodactyl Wings to order and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddPterodactylWings(object sender, RoutedEventArgs e)
        {
            EntreeClicked(new PterodactylWings());
        }

        /// <summary>
        /// Add Prehistoric PB&J to order and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddPrehistoricPBJ(object sender, RoutedEventArgs e)
        {
            EntreeClicked(new PrehistoricPBJ());
        }

        /// <summary>
        /// Add VelociWrap to order and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddVelociWrap(object sender, RoutedEventArgs e)
        {
            EntreeClicked(new VelociWrap());
        }

        private void EntreeClicked(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
