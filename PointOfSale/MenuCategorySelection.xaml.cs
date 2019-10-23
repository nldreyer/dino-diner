/*  MenuCategorySelection.xaml.cs
*   Author: Nicholas Dreyer
*/
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to ComboSelection.xaml
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void SelectCombo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComboSelection());
        }

        /// <summary>
        /// Navigates to EntreeSelection.xaml
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void SelectEntree(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EntreeSelection());
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
