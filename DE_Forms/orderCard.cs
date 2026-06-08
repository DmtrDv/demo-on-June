using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DE_Lib;

namespace DE_Forms
{
    public partial class orderCard: UserControl
    {
        public orderCard()
        {
            InitializeComponent();
        }
        public void SetOrder(Orders order)
        {
            if (order == null)
            {
                return;
            }

            Article_label.Text = "Артикул: " + order.article;
            Status_label.Text = "Статус заказа: " + order.status;
            Adress_label.Text = "Адрес: " + order.adress.ToString();
            DateOrder_label.Text = "Дата заказа: " + order.orderDate.ToString("dd.MM.yyyy");
            DateDelivery_label.Text = "Дата доставки: " + order.deliveryDate.ToString("dd.MM.yyyy");
        }
    }
}
