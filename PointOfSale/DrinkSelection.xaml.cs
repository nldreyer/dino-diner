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
        /// <param name="drink">Drink to modify</param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.Drink = drink;
            DisableDrinkButtons();
            EnableSizeButtons();
            BtnIceSpecial.IsEnabled = true;
            BtnSweetDecafFlavorSpecial.IsEnabled = true;
            BtnIceSpecial.Content = "Hold Ice";
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
            if (this.Drink is Sodasaurus ss)
            {
                NavigationService.Navigate(new FlavorSelection(ss));
            }
            else if (this.Drink is Tyrannotea tt)
            {
                tt.Sweet = true;
            }
            else if (this.Drink is JurassicJava jj)
            {
                jj.Decaf = true;
            }
        }

        /// <summary>
        /// Disables all drink buttons and enables size selection buttons
        /// </summary>
        /// <param name="drink">Drink to be added to order</param>
        private void DrinkClicked(Drink drink)
        {
            if (DataContext is Order order)
            {
                order.Add(drink);
                this.Drink = drink;
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
        /// Navigates back to menu category selection page
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnClickDone(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Helper method to disable the drink buttons and display done button
        /// </summary>
        private void DisableDrinkButtons()
        {
            BtnAddJurassicJava.Visibility = System.Windows.Visibility.Hidden;
            BtnAddSodasaurus.Visibility = System.Windows.Visibility.Hidden;
            BtnAddTyrannotea.Visibility = System.Windows.Visibility.Hidden;
            BtnAddWater.Visibility = System.Windows.Visibility.Hidden;
            LeftBtnColumnLabel.Content = "";
            var b = new Button() { Content = "Done" };
            b.Click += BtnClickDone;
            LeftBtnColumn.Children.Add(b);
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

        /// <summary>
        /// Adds lemon
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void AddLemon(object sender, RoutedEventArgs e)
        {
            if (this.Drink is Water water)
            {
                water.AddLemon();
            }
            else if (this.Drink is Tyrannotea tt)
            {
                tt.AddLemon();
            }
        }

        /// <summary>
        /// Modifies ice specialty
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void ModifyIce(object sender, RoutedEventArgs e)
        {
            if (this.Drink is Water water)
            {
                water.HoldIce();
            }
            else if (this.Drink is Tyrannotea tt)
            {
                tt.HoldIce();
            }
            else if (this.Drink is JurassicJava jj)
            {
                jj.AddIce();
            }
            else if (this.Drink is Sodasaurus ss)
            {
                ss.HoldIce();
            }
        }
    }
}
