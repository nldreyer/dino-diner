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
                if (DataContext is Order order)
                {
                    if (b.Name.Equals("BtnBrontowurst"))
                    {
                        CretaceousCombo cc = new CretaceousCombo(new Brontowurst());
                        order.Add(cc);
                        NavigationService.Navigate(new CustomizeCombo(cc));
                    }
                    if (b.Name.Equals("BtnDinoNuggets"))
                    {
                        CretaceousCombo cc = new CretaceousCombo(new DinoNuggets());
                        order.Add(cc);
                        NavigationService.Navigate(new CustomizeCombo(cc));
                    }
                    if (b.Name.Equals("BtnSteakosaurus"))
                    {
                        CretaceousCombo cc = new CretaceousCombo(new SteakosaurusBurger());
                        order.Add(cc);
                        NavigationService.Navigate(new CustomizeCombo(cc));
                    }
                    if (b.Name.Equals("BtnTRexKingBurger"))
                    {
                        CretaceousCombo cc = new CretaceousCombo(new TRexKingBurger());
                        order.Add(cc);
                        NavigationService.Navigate(new CustomizeCombo(cc));
                    }
                    if (b.Name.Equals("BtnPterodactylWings"))
                    {
                        CretaceousCombo cc = new CretaceousCombo(new PterodactylWings());
                        order.Add(cc);
                        NavigationService.Navigate(new CustomizeCombo(cc));
                    }
                    if (b.Name.Equals("BtnPBJ"))
                    {
                        CretaceousCombo cc = new CretaceousCombo(new PrehistoricPBJ());
                        order.Add(cc);
                        NavigationService.Navigate(new CustomizeCombo(cc));
                    }
                    if (b.Name.Equals("BtnVelociWrap"))
                    {
                        CretaceousCombo cc = new CretaceousCombo(new VelociWrap());
                        order.Add(cc);
                        NavigationService.Navigate(new CustomizeCombo(cc));
                    }
                }
            }
        }
    }
}
