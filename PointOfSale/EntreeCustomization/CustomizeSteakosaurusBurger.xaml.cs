/*  CustomizeSteakosaurusBurger.xaml.cs
*   Author: Nicholas Dreyer
*/
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        // Backing variable
        private SteakosaurusBurger sb;
        private bool isComboCustomization = false;

        /// <summary>
        /// CustomizeSteakosaurusBurger constructor
        /// </summary>
        /// <param name="sb">Steakosaurus Burger to modify</param>
        public CustomizeSteakosaurusBurger(SteakosaurusBurger sb)
        {
            InitializeComponent();
            this.sb = sb;
        }

        /// <summary>
        /// CustomizeSteakosaurusBurger constructor with combo
        /// </summary>
        /// <param name="sb">Steakosaurus Burger to modify</param>
        public CustomizeSteakosaurusBurger(SteakosaurusBurger sb, bool isCombo)
        {
            InitializeComponent();
            this.sb = sb;
            this.isComboCustomization = isCombo;
        }

        /// <summary>
        /// Navigate back to menu category selection
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickDone(object sender, RoutedEventArgs e)
        {
            if (isComboCustomization)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Hold bun
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldBun(object sender, RoutedEventArgs e)
        {
            sb.HoldBun();
        }

        /// <summary>
        /// Hold ketchup
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldKetchup(object sender, RoutedEventArgs e)
        {
            sb.HoldKetchup();
        }

        /// <summary>
        /// Hold mustard
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldMustard(object sender, RoutedEventArgs e)
        {
            sb.HoldMustard();
        }

        /// <summary>
        /// Hold pickle
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldPickle(object sender, RoutedEventArgs e)
        {
            sb.HoldPickle();
        }
    }
}
