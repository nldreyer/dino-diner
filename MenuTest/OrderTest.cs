/*  OrderTest.cs
*   Author: Nicholas Dreyer
*/
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void ShouldHaveCorrectItems()
        {
            Order order = new Order();
            Brontowurst bw = new Brontowurst();
            Water water = new Water();
            Fryceritops ft = new Fryceritops();
            order.Items.Add(bw);
            order.Items.Add(bw);
            order.Items.Add(bw);
            order.Items.Add(water);
            order.Items.Add(ft);
            Assert.Contains<IOrderItem>(bw, order.Items);
            Assert.Contains<IOrderItem>(water, order.Items);
            Assert.Contains<IOrderItem>(ft, order.Items);
            Assert.Equal<int>(5, order.Items.Count);
        }

        [Fact]
        public void ShouldHaveCorrectSubtotal()
        {
            Order order = new Order();
            Brontowurst bw = new Brontowurst();
            Water water = new Water();
            Fryceritops ft = new Fryceritops();
            order.Items.Add(bw);
            order.Items.Add(bw);
            order.Items.Add(bw);
            order.Items.Add(water);
            order.Items.Add(ft);
            double subtotal = bw.Price * 3 + water.Price + ft.Price;
            Assert.Equal<double>(subtotal, order.SubtotalCost);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSalesTaxRate()
        {
            Order order = new Order();
            Assert.Equal<double>(0.09, order.SalesTaxRate);
        }

        [Fact]
        public void ShouldHaveCorrectSalesTaxCost()
        {
            Order order = new Order();
            Brontowurst bw = new Brontowurst();
            Water water = new Water();
            Fryceritops ft = new Fryceritops();
            order.Items.Add(bw);
            order.Items.Add(bw);
            order.Items.Add(bw);
            order.Items.Add(water);
            order.Items.Add(ft);
            double subtotal = bw.Price * 3 + water.Price + ft.Price;
            Assert.Equal<double>(subtotal * 0.09, order.SalesTaxCost);
        }

        [Fact]
        public void ShouldHaveCorrectTotalCost()
        {
            Order order = new Order();
            Brontowurst bw = new Brontowurst();
            Water water = new Water();
            Fryceritops ft = new Fryceritops();
            order.Items.Add(bw);
            order.Items.Add(bw);
            order.Items.Add(bw);
            order.Items.Add(water);
            order.Items.Add(ft);
            double subtotal = bw.Price * 3 + water.Price + ft.Price;
            Assert.Equal<double>(subtotal *= 1.09, order.TotalCost);
        }
    }
}
