/*  CustomizeComboSelection.xaml.cs
*   Author: Nicholas Dreyer
*/
using DinoDiner.Menu;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page, INotifyPropertyChanged
    {
        public CretaceousCombo combo;

        /// <summary>
        /// Notify of a property change; For price, calories, ingredients, and special
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoke a changed property notification
        /// </summary>
        /// <param name="propertyName">Name of property being updated</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// CustomizeCombo constructor
        /// </summary>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            BtnEntree.Content = combo.Description;
            BtnSide.Content = combo.Side.Description;
            BtnDrink.Content = combo.Drink.Description;
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
                bw.cc = combo;
                NavigationService?.Navigate(new CustomizeBrontowurst(bw, true));
            }
            else if (combo.Entree is DinoNuggets dn)
            {
                dn.cc = combo;
                NavigationService?.Navigate(new CustomizeDinoNuggets(dn, true));
            }
            else if (combo.Entree is PrehistoricPBJ pbj)
            {
                pbj.cc = combo;
                NavigationService?.Navigate(new CustomizePBJ(pbj, true));
            }
            else if (combo.Entree is SteakosaurusBurger sb)
            {
                sb.cc = combo;
                NavigationService?.Navigate(new CustomizeSteakosaurusBurger(sb, true));
            }
            else if (combo.Entree is TRexKingBurger kb)
            {
                kb.cc = combo;
                NavigationService?.Navigate(new CustomizeTRexKingBurger(kb, true));
            }
            else if (combo.Entree is VelociWrap vw)
            {
                vw.cc = combo;
                NavigationService?.Navigate(new CustomizeVelociWrap(vw, true));
            }
        }

        /// <summary>
        /// Navigates to SideSelection.xaml
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void SelectSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection(combo.Side, combo));
        }

        /// <summary>
        /// Navigates to DrinkSelection.xaml
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(combo.Drink, combo));
        }

        /// <summary>
        /// Changes side and drink sizes to small
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnClickSmall(object sender, RoutedEventArgs e)
        {
            combo.Drink.Size = DinoDiner.Menu.Size.Small;
            combo.Side.Size = DinoDiner.Menu.Size.Small;
            combo.Size = DinoDiner.Menu.Size.Small;
            BtnSide.Content = combo.Side.Description;
            BtnDrink.Content = combo.Drink.Description;
            combo.NotifyItemChanged("Special");
        }

        /// <summary>
        /// Changes side and drink sizes to medium
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnClickMedium(object sender, RoutedEventArgs e)
        {
            combo.Drink.Size = DinoDiner.Menu.Size.Medium;
            combo.Side.Size = DinoDiner.Menu.Size.Medium;
            combo.Size = DinoDiner.Menu.Size.Medium;
            BtnSide.Content = combo.Side.Description;
            BtnDrink.Content = combo.Drink.Description;
            combo.NotifyItemChanged("Special");
        }

        /// <summary>
        /// Changes side and drink sizes to large
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnClickLarge(object sender, RoutedEventArgs e)
        {
            combo.Drink.Size = DinoDiner.Menu.Size.Large;
            combo.Side.Size = DinoDiner.Menu.Size.Large;
            combo.Size = DinoDiner.Menu.Size.Large;
            BtnSide.Content = combo.Side.Description;
            BtnDrink.Content = combo.Drink.Description;
            combo.NotifyItemChanged("Special");
        }

        /// <summary>
        /// Navigates back to the main menu
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnClickDone(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
