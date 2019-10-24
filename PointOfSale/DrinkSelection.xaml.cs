/*  DrinkSelection.xaml.cs
*   Author: Nicholas Dreyer
*/
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public Drink Drink { get; set; }

        /// <summary>
        /// DrinkSelection constructor
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// DrinkSelection constructor with existing drink
        /// </summary>
        /// <param name="side"></param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.Drink = drink;
            DisableDrinkButtons();
            EnableSizeButtons();
            if (drink.Description.Contains("Sodasaurus"))
            {
                BtnSweetDecafFlavorSpecial.Content = "Flavor";
            }
            else if (drink.Description.Contains("Tyrannotea"))
            {
                BtnSweetDecafFlavorSpecial.Content = "Sweet";
                BtnLemonSpecial.IsEnabled = true;
            }
            else if (drink.Description.Contains("Jurassic Java"))
            {
                BtnIceSpecial.Content = "Add Ice";
                BtnSweetDecafFlavorSpecial.Content = "Decaf";
            }
            else if (drink.Description.Contains("Water"))
            {
                BtnSweetDecafFlavorSpecial.IsEnabled = false;
                BtnLemonSpecial.IsEnabled = true;
            }
        }

        /// <summary>
        /// Add Sodasaurus to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddSodasaurus(object sender, RoutedEventArgs e)
        {
            DrinkClicked(new Sodasaurus());
            BtnSweetDecafFlavorSpecial.Content = "Flavor";
        }

        /// <summary>
        /// Add Tyrannotea to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddTyrannotea(object sender, RoutedEventArgs e)
        {
            DrinkClicked(new Tyrannotea());
            BtnSweetDecafFlavorSpecial.Content = "Sweet";
            BtnLemonSpecial.IsEnabled = true;
        }

        /// <summary>
        /// Add JurassicJava to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddJurassicJava(object sender, RoutedEventArgs e)
        {
            DrinkClicked(new JurassicJava());
            BtnIceSpecial.Content = "Add Ice";
            BtnSweetDecafFlavorSpecial.Content = "Decaf";
        }

        /// <summary>
        /// Add Water to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddWater(object sender, RoutedEventArgs e)
        {
            DrinkClicked(new Water());
            BtnSweetDecafFlavorSpecial.IsEnabled = false;
            BtnLemonSpecial.IsEnabled = true;
        }

        /// <summary>
        /// Make drink small
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickSmall(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// Make drink medium
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickMedium(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Make drink large
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickLarge(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// Navigates to FlavorSelection.xaml
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void SelectFlavor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Disables all drink buttons and enables size selection buttons
        /// </summary>
        /// <param name="drink">Drink to be added to order</param>
        private void DrinkClicked(Drink drink)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(drink);
                DisableDrinkButtons();
                EnableSizeButtons();
                BtnIceSpecial.IsEnabled = true;
                BtnSweetDecafFlavorSpecial.IsEnabled = true;
                BtnIceSpecial.Content = "Hold Ice";
            }
        }

        /// <summary>
        /// Changes drink size
        /// </summary>
        /// <param name="drink">Drink to be changed to</param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
            {
                this.Drink.Size = size;
            }
        }

        /// <summary>
        /// Helper method to disable the drink buttons
        /// </summary>
        private void DisableDrinkButtons()
        {
            BtnAddJurassicJava.IsEnabled = false;
            BtnAddSodasaurus.IsEnabled = false;
            BtnAddTyrannotea.IsEnabled = false;
            BtnAddWater.IsEnabled = false;
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
