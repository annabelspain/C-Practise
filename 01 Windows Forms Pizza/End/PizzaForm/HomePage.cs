using PizzaProj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaForm
{
    public partial class HomePage : Form
    {
        private PizzaContext context;
        public HomePage()
        {
            InitializeComponent();
            context = new PizzaContext();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            context.Orders.Load();
            OrdersGrid.DataSource = context.Orders.Local;
            OrdersGrid.Columns[nameof(Order.NonDiscountedPrice)].DefaultCellStyle.Format = "c2";
        }

        private void FindDiscountButton_Click(object sender, EventArgs e)
        {
            if (OrdersGrid.SelectedRows.Count > 0)
            {
                Order order = (Order)OrdersGrid.SelectedRows[0].DataBoundItem;
                new OrderForm(order, GetBestDiscount(), context).ShowDialog();
                //Checkout checkout = new Checkout(GetBestDiscount());
                //PriceData discountedPrice = checkout.GetBestPrice(order);

                //string message = $"With a {discountedPrice.DiscountPolicyName} discount, that will be {discountedPrice.TotalPrice:c2}";
                //MessageBox.Show(message, "Pizza checkout");
            }

        }
        BestDiscount GetBestDiscount()
        {
            if (WeekendCheckBox.Checked)
            {
                return new WeekendDiscounts();
            }
            else
            {
                return new WeekdayDiscounts();
            }
        }
    }
}
