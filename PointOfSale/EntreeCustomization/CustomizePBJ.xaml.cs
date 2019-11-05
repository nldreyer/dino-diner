/*  CustomizePBJ.xaml.cs
*   Author: Nicholas Dreyer
*/
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizePBJ.xaml
    /// </summary>
    public partial class CustomizePBJ : Page
    {
        // Backing variable
        private PrehistoricPBJ pbj;
        private bool isComboCustomization = false;

        /// <summary>
        /// CustomizePBJ constructor
        /// </summary>
        /// <param name="pbj">Prehistoric PBJ to modify</param>
        public CustomizePBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        /// <summary>
        /// CustomizePBJ constructor
        /// </summary>
        /// <param name="pbj">Prehistoric PBJ to modify</param>
        public CustomizePBJ(PrehistoricPBJ pbj, bool isCombo)
        {
            InitializeComponent();
            this.pbj = pbj;
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
        /// Hold Jelly
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldJelly(object sender, RoutedEventArgs e)
        {
            pbj.HoldJelly();
        }

        /// <summary>
        /// Hold peanut butter
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldPeanutButter(object sender, RoutedEventArgs e)
        {
            pbj.HoldPeanutButter();
        }
    }
}
