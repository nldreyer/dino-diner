/*  CustomizeVelociWrap.xaml.cs
*   Author: Nicholas Dreyer
*/
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        // Backing variable
        private VelociWrap vw;
        private bool isComboCustomization = false;

        /// <summary>
        /// CustomizeVelociWrap constructor
        /// </summary>
        /// <param name="pbj">VelociWrap to modify</param>
        public CustomizeVelociWrap(VelociWrap vw)
        {
            InitializeComponent();
            this.vw = vw;
        }

        /// <summary>
        /// CustomizeVelociWrap constructor with combo
        /// </summary>
        /// <param name="pbj">VelociWrap to modify</param>
        public CustomizeVelociWrap(VelociWrap vw, bool isCombo)
        {
            InitializeComponent();
            this.vw = vw;
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
        /// Hold Dressing
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldDressing(object sender, RoutedEventArgs e)
        {
            vw.HoldDressing();
        }

        /// <summary>
        /// Hold lettuce
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldLettuce(object sender, RoutedEventArgs e)
        {
            vw.HoldLettuce();
        }

        /// <summary>
        /// Hold cheese
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickHoldCheese(object sender, RoutedEventArgs e)
        {
            vw.HoldCheese();
        }
    }
}
