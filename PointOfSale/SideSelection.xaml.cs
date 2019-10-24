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
        public Side Side { get; set; }

        /// <summary>
        /// SideSelection blank constructor
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// SideSelection constructor with existing side
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.Side = side;
            DisableSideButtons();
            EnableSizeButtons();
        }

        /// <summary>
        /// Add Fryceritops to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddFryceritops(object sender, RoutedEventArgs e)
        {
            SideClicked(new Fryceritops());
        }

        /// <summary>
        /// Add Meteor Mac And Cheese to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddMeteorMacAndCheese(object sender, RoutedEventArgs e)
        {
            SideClicked(new MeteorMacAndCheese());
        }

        /// <summary>
        /// Add Mezzorella Sticks to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddMezzorellaSticks(object sender, RoutedEventArgs e)
        {
            SideClicked(new MezzorellaSticks());
        }

        /// <summary>
        /// Add Triceritots to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddTriceritots(object sender, RoutedEventArgs e)
        {
            SideClicked(new Triceritots());
        }

        /// <summary>
        /// Make side small and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickSmall(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// Make side medium and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickMedium(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Make side large and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickLarge(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// Disables all side buttons and enables size selection buttons
        /// </summary>
        /// <param name="side">Side to be added to order</param>
        private void SideClicked(Side side)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(side);
                this.Side = side;
                DisableSideButtons();
                EnableSizeButtons();
            }
        }

        /// <summary>
        /// Changes side size
        /// </summary>
        /// <param name="size">Size to be changed to</param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
            {
                this.Side.Size = size;
            }
        }

        /// <summary>
        /// Helper method to disable the side buttons
        /// </summary>
        private void DisableSideButtons()
        {
            BtnAddFryceritops.IsEnabled = false;
            BtnAddMeteorMacAndCheese.IsEnabled = false;
            BtnAddMezzorellaSticks.IsEnabled = false;
            BtnAddTriceritots.IsEnabled = false;
        }

        /// <summary>
        /// Helper method to enable size selection buttons
        /// </summary>
        private void EnableSizeButtons()
        {
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
        }
    }
}
