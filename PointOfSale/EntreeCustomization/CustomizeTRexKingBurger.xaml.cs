/*  CustomizeTRexKingBurger.xaml.cs
*   Author: Nicholas Dreyer
*/
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        // Backing variable
        private TRexKingBurger kb;
        private bool isComboCustomization = false;

        /// <summary>
        /// CustomizeTRexKingBurger constructor
        /// </summary>
        /// <param name="kb">T-Rex King Burger to modify</param>
        public CustomizeTRexKingBurger(TRexKingBurger kb)
        {
            InitializeComponent();
            this.kb = kb;
        }

        /// <summary>
        /// CustomizeTRexKingBurger constructor with combo
        /// </summary>
        /// <param name="kb">T-Rex King Burger to modify</param>
        public CustomizeTRexKingBurger(TRexKingBurger kb, bool isCombo)
        {
            InitializeComponent();
            this.kb = kb;
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
            kb.HoldBun();
        }

        /// <summary>
        /// Hold lettuce
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldLettuce(object sender, RoutedEventArgs e)
        {
            kb.HoldLettuce();
        }

        /// <summary>
        /// Hold mustard
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldMustard(object sender, RoutedEventArgs e)
        {
            kb.HoldMustard();
        }

        /// <summary>
        /// Hold onion
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldOnion(object sender, RoutedEventArgs e)
        {
            kb.HoldOnion();
        }

        /// <summary>
        /// Hold pickle
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldPickle(object sender, RoutedEventArgs e)
        {
            kb.HoldPickle();
        }

        /// <summary>
        /// Hold ketchup
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldKetchup(object sender, RoutedEventArgs e)
        {
            kb.HoldKetchup();
        }

        /// <summary>
        /// Hold tomato
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldTomato(object sender, RoutedEventArgs e)
        {
            kb.HoldTomato();
        }

        /// <summary>
        /// Hold mayo
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldMayo(object sender, RoutedEventArgs e)
        {
            kb.HoldMayo();
        }
    }
}
