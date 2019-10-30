/*  CustomizeDinoNuggets.xaml.cs
*   Author: Nicholas Dreyer
*/
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        // Backing variable
        private DinoNuggets dn;

        /// <summary>
        /// CustomizeDinoNuggets constructor
        /// </summary>
        /// <param name="dn">Dino Nuggets to modify</param>
        public CustomizeDinoNuggets(DinoNuggets dn)
        {
            InitializeComponent();
            this.dn = dn;
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
        /// Add nugget
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickAddNugget(object sender, RoutedEventArgs e)
        {
            dn.AddNugget();
        }
    }
}
