﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OrderList.NavigationService = OrderInterface.NavigationService;
        }

        public void OnLoadCompleted(object sender, NavigationEventArgs e)
        {
            BindDataContextToPage();
        }

        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            BindDataContextToPage();
        }

        private void BindDataContextToPage()
        {
            if(OrderInterface.Content is FrameworkElement element)
            {
                element.DataContext = OrderInterface.DataContext;
            }
        }
    }
}
