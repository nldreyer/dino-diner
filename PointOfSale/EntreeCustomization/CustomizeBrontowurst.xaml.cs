/*  CustomizeBrontowurst.xaml.cs
*   Author: Nicholas Dreyer
*/
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        // Backing variable
        private Brontowurst bw;

        /// <summary>
        /// CustomizeBrontowurst constructor
        /// </summary>
        /// <param name="bw">Brontowurst to modify</param>
        public CustomizeBrontowurst(Brontowurst bw)
        {
            InitializeComponent();
            this.bw = bw;
        }

        /// <summary>
        /// Navigate back to menu category selection
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickDone(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Hold bun
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldBun(object sender, RoutedEventArgs e)
        {
            bw.HoldBun();
        }

        /// <summary>
        /// Hold onion
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldOnion(object sender, RoutedEventArgs e)
        {
            bw.HoldOnion();
        }

        /// <summary>
        /// Hold peppers
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldPeppers(object sender, RoutedEventArgs e)
        {
            bw.HoldPeppers();
        }
    }
}
