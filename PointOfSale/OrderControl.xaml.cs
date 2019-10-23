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
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
