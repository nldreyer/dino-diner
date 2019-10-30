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

        public OrderControl()
        {
            InitializeComponent();
        }

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
                if (entree is DinoNuggets dn)
                {
                    NavigationService?.Navigate(new CustomizeDinoNuggets(dn));
                }
                if (entree is PrehistoricPBJ pbj)
                {
                    NavigationService?.Navigate(new CustomizePBJ(pbj));
                }
                if (entree is SteakosaurusBurger sb)
                {
                    NavigationService?.Navigate(new CustomizeSteakosaurusBurger(sb));
                }
                if (entree is TRexKingBurger kb)
                {
                    NavigationService?.Navigate(new CustomizeTRexKingBurger(kb));
                }
                if (entree is VelociWrap vw)
                {
                    NavigationService?.Navigate(new CustomizeVelociWrap(vw));
                }
            }
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            
        }

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
