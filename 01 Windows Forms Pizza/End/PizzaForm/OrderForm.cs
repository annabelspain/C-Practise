using PizzaProj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaForm
{
    public partial class OrderForm : Form
    {
        private readonly Order order;
        private readonly BestDiscount discount;

        private readonly PizzaContext context;
        private List<Pizza> deletedPizzas = new List<Pizza>();

        public OrderForm(Order order, BestDiscount discount, PizzaContext context)
        {
            InitializeComponent();
            this.order = order;
            this.discount = discount;
            this.context = context;
        }


        private void OrderForm_Load(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout(discount);
            PriceData discountedPrice = checkout.GetBestPrice(order);

            string message = $"With a {discountedPrice.DiscountPolicyName} discount, that will be {discountedPrice.TotalPrice:c2}";
            MessageLabel.Text = message;

            //PizzasGrid.DataSource = order.Pizzas;
            //PizzasGrid.Columns.Remove(nameof(Order));
            //PizzasGrid.Columns.Remove(nameof(Order.OrderId));
            //PizzasGrid.Columns[nameof(Pizza.Price)].DefaultCellStyle.Format = "c2";

            PizzasGrid.AutoGenerateColumns = false;
            AddComboBoxColumn(nameof(PizzaProj.Size), typeof(PizzaProj.Size));
            AddComboBoxColumn(nameof(PizzaProj.Crust), typeof(PizzaProj.Crust));
            AddTextBoxColumn(nameof(PizzaProj.Pizza.Price));

            PizzasGrid.DataSource = new BindingList<Pizza>(order.Pizzas);
        }

        private void AddComboBoxColumn(string name, Type enumType)
        {
            DataGridViewColumn col = new DataGridViewComboBoxColumn
            {
                Name = name,
                DataPropertyName = name,
                DataSource = Enum.GetValues(enumType)
            };
            PizzasGrid.Columns.Add(col);
        }

        private void AddTextBoxColumn(string name)
        {
            DataGridViewColumn col = new DataGridViewTextBoxColumn
            {
                Name = name,
                DefaultCellStyle = new DataGridViewCellStyle() { Format = "c2" },
                DataPropertyName = name
            };
            PizzasGrid.Columns.Add(col);
        }


        private void PizzasGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            deletedPizzas.Add(e.Row.DataBoundItem as Pizza);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            foreach (var pizza in deletedPizzas)
            {
                context.Pizzas.Remove(pizza);
            }
            context.SaveChanges();
            Close();
        }
    }
}
