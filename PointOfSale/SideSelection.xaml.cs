/*  SideSelection.xaml.cs
*   Author: Nicholas Dreyer
*/
using System.Windows;
using System.Windows.Controls;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// SideSelection constructor
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add Fryceritops to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddFryceritops(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new Fryceritops());
            SideClicked();
        }

        /// <summary>
        /// Add Meteor Mac And Cheese to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddMeteorMacAndCheese(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new MeteorMacAndCheese());
            SideClicked();
        }

        /// <summary>
        /// Add Mezzorella Sticks to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddMezzorellaSticks(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new MezzorellaSticks());
            SideClicked();
        }

        /// <summary>
        /// Add Triceritots to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddTriceritots(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new Triceritots());
            SideClicked();
        }

        /// <summary>
        /// Make side small and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickSmall(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Make side medium and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickMedium(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Make side large and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickLarge(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Disables all side buttons and enables size selection buttons
        /// </summary>
        private void SideClicked()
        {
            BtnAddFryceritops.IsEnabled = false;
            BtnAddMeteorMacAndCheese.IsEnabled = false;
            BtnAddMezzorellaSticks.IsEnabled = false;
            BtnAddTriceritots.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
        }
    }
}
