/*  SideSelection.xaml.cs
*   Author: Nicholas Dreyer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public SideSelection()
        {
            InitializeComponent();
        }

        private void AddFryceritops(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new Fryceritops());
            SideClicked();
        }

        private void AddMeteorMacAndCheese(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new MeteorMacAndCheese());
            SideClicked();
        }

        private void AddMezzorellaSticks(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new MezzorellaSticks());
            SideClicked();
        }

        private void AddTriceritots(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new Triceritots());
            SideClicked();
        }

        /// <summary>
        /// Disables all side buttons and enables size selection buttons
        /// </summary>
        private void SideClicked()
        {
            BtnAddFryceritops.IsEnabled = false;
            BtnAddMeteorMacAndCheese.IsEnabled = false;
            BtnAddMezzorellaSticks.IsEnabled = false;
            BtnAddTriceritots.IsEnabled = false;
            BtnPickSmall.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
        }
    }
}
