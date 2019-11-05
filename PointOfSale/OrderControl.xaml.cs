/*  OrderControl.xaml.cs
*   Author: Nicholas Dreyer
*/
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public NavigationService NavigationService { get; set; }

        /// <summary>
        /// OrderControl constructor
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigate to correct page on item selection
        /// </summary>
        /// <param name="sender">Item clicked</param>
        /// <param name="e">Event args</param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }
            else if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
            }
            else if (OrderItems.SelectedItem is Entree entree)
            {
                if (entree is Brontowurst bw)
                {
                    NavigationService?.Navigate(new CustomizeBrontowurst(bw));
                }
                else if (entree is DinoNuggets dn)
                {
                    NavigationService?.Navigate(new CustomizeDinoNuggets(dn));
                }
                else if (entree is PrehistoricPBJ pbj)
                {
                    NavigationService?.Navigate(new CustomizePBJ(pbj));
                }
                else if (entree is SteakosaurusBurger sb)
                {
                    NavigationService?.Navigate(new CustomizeSteakosaurusBurger(sb));
                }
                else if (entree is TRexKingBurger kb)
                {
                    NavigationService?.Navigate(new CustomizeTRexKingBurger(kb));
                }
                else if (entree is VelociWrap vw)
                {
                    NavigationService?.Navigate(new CustomizeVelociWrap(vw));
                }
            }
            else if (OrderItems.SelectedItem is CretaceousCombo cc)
            {
                NavigationService?.Navigate(new CustomizeCombo(cc));
            }
        }

        /// <summary>
        /// Removes all items from the current order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Items.Clear();
            }
        }

        /// <summary>
        /// Removes a certain item from the order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void OnRemoveItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                    {
                        order.Items.Remove(item);
                    }
                }
            }
        }
    }
}
