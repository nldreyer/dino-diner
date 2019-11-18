/*  FlavorSelection.xaml.cs
*   Author: Nicholas Dreyer
*/
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        // Backing variables
        public Drink Drink;
        private CretaceousCombo cc;

        /// <summary>
        /// FlavorSelection constructor
        /// </summary>
        /// <param name="drink">Drink to modify</param>
        public FlavorSelection(Drink drink)
        {
            InitializeComponent();
            this.Drink = drink;
        }

        /// <summary>
        /// FlavorSelection constructor within combo
        /// </summary>
        /// <param name="drink">Drink to modify</param>
        public FlavorSelection(Drink drink, CretaceousCombo cc)
        {
            InitializeComponent();
            this.Drink = drink;
            this.cc = cc;
        }

        /// <summary>
        /// Change flavor to user choice
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void ClickFlavor(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                if (this.Drink is Sodasaurus ss)
                {
                    if (b.Name.Equals("BtnCherry"))
                    {
                        ss.Flavor = SodasaurusFlavor.Cherry;
                    }
                    else if (b.Name.Equals("BtnChocolate"))
                    {
                        ss.Flavor = SodasaurusFlavor.Chocolate;
                    }
                    else if (b.Name.Equals("BtnCola"))
                    {
                        ss.Flavor = SodasaurusFlavor.Cola;
                    }
                    else if (b.Name.Equals("BtnLime"))
                    {
                        ss.Flavor = SodasaurusFlavor.Lime;
                    }
                    else if (b.Name.Equals("BtnOrange"))
                    {
                        ss.Flavor = SodasaurusFlavor.Orange;
                    }
                    else if (b.Name.Equals("BtnRootBeer"))
                    {
                        ss.Flavor = SodasaurusFlavor.RootBeer;
                    }
                    else if (b.Name.Equals("BtnVanilla"))
                    {
                        ss.Flavor = SodasaurusFlavor.Vanilla;
                    }
                }
                if (cc != null)
                {
                    cc.NotifyItemChanged("Special");
                }
                NavigationService.GoBack();
            }
        }
    }
}
