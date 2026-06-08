using DE_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Forms
{
    public partial class OrdersForm: Form
    {
        private List<Orders> allOrders_ = new List<Orders>();
        private bool closingForm = false;
        public OrdersForm()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void OrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closingForm)
            {
                Application.Exit();
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            closingForm = true;
            this.Close();
        }
        private void LoadOrders()
        {
            try
            {
                allOrders_ = Database.GetAllOrders();
                ShowOnDisplayOrders(allOrders_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заказов: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowOnDisplayOrders(List<Orders> orders)
        {
            Orders_flowLayoutPanel.Controls.Clear();
            if (orders.Count == 0)
            {
                return;
            }
            foreach (Orders order in orders)
            {
                orderCard card = new orderCard();
                card.SetOrder(order);
                Orders_flowLayoutPanel.Controls.Add(card);
            }
        }
    }
}
