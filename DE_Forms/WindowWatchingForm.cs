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
    public partial class WindowWatchingForm: Form
    {
        private List<Products> allProducts_;
        private string userRole_;
        private AuthorizationForm authorizationForm_;
        public WindowWatchingForm(User user, AuthorizationForm authorization)
        {
            InitializeComponent();
            this.Text = $"Окно просмотра: {user.role}";
            FioUser_label.Text = user.fio;
            LoadProduct();
            userRole_ = user.role;
            authorizationForm_ = authorization;
        }
        private void LoadProduct()
        {
            try
            {
                //получаем данные из бд
                allProducts_ = Database.GetAllProducts();
                // отображаем 
                ShowOnDisplayProducts(allProducts_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки товаров: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowOnDisplayProducts(List<Products> products)
        {
            MainPanel_flowLayoutPanel.Controls.Clear();
            if (products.Count == 0)
            {
                return;
            }
            foreach (Products product in products)
            {
                var card = new Card();
                card.SetProduct(product);
                MainPanel_flowLayoutPanel.Controls.Add(card);
            }
        }

        private void findText_textBox_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = findText_textBox.Text.ToLower().Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                ShowOnDisplayProducts(allProducts_);
            }
            else
            {
                List<Products> needProducts = new List<Products>();
                foreach (Products product in allProducts_)
                {
                    string searchableText = allAtributsForSearch(product);
                    bool visible = searchableText.ToLower().Contains(searchText);
                    if (visible == true)
                    {
                        needProducts.Add(product);
                    }
                }
                ShowOnDisplayProducts(needProducts);
            }
        }
        private string allAtributsForSearch(Products product)
        {
            string searchableText = $@"
                {product.name} ,
                {product.category} ,
                {product.description} ,
                {product.manufacturer} ,
                {product.supplier} ,
                {product.unit}
            ".ToLower();
            return searchableText;
        }

        private bool lowUser()
        {
            return userRole_ == "Гость" || userRole_ == "Авторизированный клиент" || userRole_ == null;
        }

        private void WindowWatchingForm_Load(object sender, EventArgs e)
        {
            if (lowUser())
            {
                findText_textBox.Enabled = false;
                findText_textBox.Location = new Point(150, 6);
                find_label.Text = "Поиск Вам недоступеyн";
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            authorizationForm_.Show();
            this.Dispose();
        }

        private void WindowWatchingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
