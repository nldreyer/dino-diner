﻿/*  SideSelection.xaml.cs
*   Author: Nicholas Dreyer
*/
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public Side Side { get; set; }
        private CretaceousCombo cc;

        /// <summary>
        /// SideSelection blank constructor
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// SideSelection constructor with existing side
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.Side = side;
            DisableSideButtons();
            EnableSizeButtons();
        }

        /// <summary>
        /// SideSelection constructor with existing side inside of a combo
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side, CretaceousCombo cc)
        {
            InitializeComponent();
            this.Side = side;
            this.cc = cc;
        }

        /// <summary>
        /// Add Fryceritops to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddFryceritops(object sender, RoutedEventArgs e)
        {
            if (cc == null)
            {
                SideClicked(new Fryceritops());
            }
            else
            {
                cc.Side = new Fryceritops();
                cc.Side.Size = cc.Size;
                cc.NotifyItemChanged("Special");
                NavigationService.Navigate(new CustomizeCombo(cc));
            }
        }

        /// <summary>
        /// Add Meteor Mac And Cheese to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddMeteorMacAndCheese(object sender, RoutedEventArgs e)
        {
            if (cc == null) 
            { 
                SideClicked(new MeteorMacAndCheese());
            }
            else
            {
                cc.Side = new MeteorMacAndCheese();
                cc.Side.Size = cc.Size;
                cc.NotifyItemChanged("Special");
                NavigationService.Navigate(new CustomizeCombo(cc));
            }
        }

        /// <summary>
        /// Add Mezzorella Sticks to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddMezzorellaSticks(object sender, RoutedEventArgs e)
        {
            if (cc == null)
            {
                SideClicked(new MezzorellaSticks());
            }
            else
            {
                cc.Side = new MezzorellaSticks();
                cc.Side.Size = cc.Size;
                cc.NotifyItemChanged("Special");
                NavigationService.Navigate(new CustomizeCombo(cc));
            }
        }

        /// <summary>
        /// Add Triceritots to order
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void AddTriceritots(object sender, RoutedEventArgs e)
        {
            if (cc == null)
            {
                SideClicked(new Triceritots());
            }
            else
            {
                cc.Side = new Triceritots();
                cc.Side.Size = cc.Size;
                cc.NotifyItemChanged("Special");
                NavigationService.Navigate(new CustomizeCombo(cc));
            }
        }

        /// <summary>
        /// Make side small and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickSmall(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// Make side medium and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickMedium(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Make side large and navigate back to menu category selection page
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">Event args</param>
        private void BtnClickLarge(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// Disables all side buttons and enables size selection buttons
        /// </summary>
        /// <param name="side">Side to be added to order</param>
        private void SideClicked(Side side)
        {
            if (DataContext is Order order)
            {
                order.Add(side);
                this.Side = side;
                DisableSideButtons();
                EnableSizeButtons();
            }
        }

        /// <summary>
        /// Changes side size
        /// </summary>
        /// <param name="size">Size to be changed to</param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
            {
                this.Side.Size = size;
                NavigationService.Navigate(new MenuCategorySelection());
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
        /// Helper method to disable the side buttons
        /// </summary>
        private void DisableSideButtons()
        {
            BtnAddFryceritops.Visibility = System.Windows.Visibility.Hidden;
            BtnAddMeteorMacAndCheese.Visibility = System.Windows.Visibility.Hidden;
            BtnAddMezzorellaSticks.Visibility = System.Windows.Visibility.Hidden;
            BtnAddTriceritots.Visibility = System.Windows.Visibility.Hidden;
            LeftBtnColumnLabel.Content = "";
            var b = new Button() { Content = "Done" };
            b.Click += BtnClickDone;
            b.Background = Brushes.LightGreen;
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
    }
}
