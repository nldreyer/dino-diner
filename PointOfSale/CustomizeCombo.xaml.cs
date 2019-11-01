/*  CustomizeComboSelection.xaml.cs
*   Author: Nicholas Dreyer
*/
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        public CretaceousCombo combo;

        /// <summary>
        /// CustomizeCombo constructor
        /// </summary>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                this.combo = combo;
                order.Add(combo);
            }
        }

        /// <summary>
        /// Navigates to entree customization page
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void SelectEntree(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is Brontowurst bw)
            {
                NavigationService?.Navigate(new CustomizeBrontowurst(bw));
            }
            if (combo.Entree is DinoNuggets dn)
            {
                NavigationService?.Navigate(new CustomizeDinoNuggets(dn));
            }
            if (combo.Entree is PrehistoricPBJ pbj)
            {
                NavigationService?.Navigate(new CustomizePBJ(pbj));
            }
            if (combo.Entree is SteakosaurusBurger sb)
            {
                NavigationService?.Navigate(new CustomizeSteakosaurusBurger(sb));
            }
            if (combo.Entree is TRexKingBurger kb)
            {
                NavigationService?.Navigate(new CustomizeTRexKingBurger(kb));
            }
            if (combo.Entree is VelociWrap vw)
            {
                NavigationService?.Navigate(new CustomizeVelociWrap(vw));
            }
        }

        /// <summary>
        /// Navigates to SideSelection.xaml
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void SelectSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }

        /// <summary>
        /// Navigates to DrinkSelection.xaml
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
