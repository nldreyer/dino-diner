/*  ComboSelection.xaml.cs
*   Author: Nicholas Dreyer
*/
using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// ComboSelection constructor
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to CustomizeCombo.xaml
        /// </summary>
        /// <param name="sender">Button that was pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void ComboSelected(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                if (b.Name.Equals("BtnBrontowurst"))
                {
                    if (DataContext is Order order)
                    {
                        CretaceousCombo cc = new CretaceousCombo(new Brontowurst());
                        NavigationService.Navigate(new CustomizeCombo(cc));
                    }
                }
            }
        }
    }
}
