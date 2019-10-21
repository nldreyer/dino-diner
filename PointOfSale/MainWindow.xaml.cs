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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Order order = (Order)DataContext;
            order.Items.Add(new Fryceritops());
            Tyrannotea tt = new Tyrannotea();
            tt.Size = DinoDiner.Menu.Size.Large;
            tt.AddLemon();
            order.Items.Add(tt);
            order.Items.Add(new Brontowurst());
        }

        public void OnLoadCompleted(object sender, NavigationEventArgs e)
        {
            SetFrameDataContext();
        }

        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            SetFrameDataContext();
        }

        private void SetFrameDataContext()
        {
            FrameworkElement content = OrderInterface.Content as FrameworkElement;
            if (content == null) return;
            content.DataContext = OrderInterface.DataContext;
        }
    }
}
