using DE_Lib;
using MySqlX.XDevAPI.Common;
using ShopApp;
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
            FioUser_label.Text = user.fio;
            LoadProduct();
            userRole_ = user.role;
            authorizationForm_ = authorization;
            Sort_comboBox.SelectedIndex = 0;
            Filtert_comboBox.SelectedIndex = 0;
            GetSuppliers();
        }
        private void LoadProduct()
        {
            try
            {
                //получаем данные из бд
                allProducts_ = Database.GetAllProducts();
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
                card.Click += (sender, args) =>
                {
                    EditFormOpen(product);
                };
                foreach (Control c in card.Controls)
                {
                    c.Click += (s, e) => EditFormOpen(product);
                }
                MainPanel_flowLayoutPanel.Controls.Add(card);
            }
        }
        private void EditFormOpen(Products product)
        {
            if (HighUser())
            {
                ProductAddAndEditForm editForm = new ProductAddAndEditForm(product);
                if (editForm.ShowDialog() == DialogResult.Yes )
                {
                    LoadProduct();
                    UpdateDisplay();
                }
            }
            else
            {
                MessageBox.Show("Недостаточно прав для редактирования", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool LowUser()
        {
            return userRole_ == "Гость" || userRole_ == "Авторизированный клиент" || userRole_ == null;
        }
        private bool MiddleUser()
        {
            return userRole_ == "Менеджер";
        }
        private bool HighUser()
        {
            return userRole_ == "Администратор";
        }


        private void WindowWatchingForm_Load(object sender, EventArgs e)
        {
            if (LowUser())
            {
                if (userRole_ == "Гость")
                {
                    FioUser_label.Text = userRole_;
                }

                FindText_textBox.Enabled = false;
                Find_label.Text = "Поиск недоступен";

                Filtert_comboBox.Enabled = false;
                Filter_label.Text = "Фильтрация недоступна";

                Sort_comboBox.Enabled = false;
                Sort_label.Text = "Сортировка недоступна";

                AddProduct_button.Enabled = false;
            }
            if (MiddleUser())
            {
                AddProduct_button.Enabled = false;
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

        private void findText_textBox_TextChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
        private void Sort_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
        private void Filtert_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
        private void UpdateDisplay()
        {
            if (allProducts_ == null)
            {
                return;
            }

            List<Products> filtered = new List<Products>(allProducts_);

            // Поиск 
            string searchText = FindText_textBox.Text.ToLower().Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                List<Products> findList = new List<Products>();
                foreach (Products product in filtered)
                {
                    if (AllAtributsForSearch(product).Contains(searchText))
                    {
                        findList.Add(product);
                    }
                }
                filtered = findList;
            }
            
            // Фильтр по поставщику
            if (Filtert_comboBox.SelectedIndex > 0) // не "Все поставщики"
            {
                string selectedSupplier = Filtert_comboBox.SelectedItem.ToString();
                List<Products> needFilter = new List<Products>();
                foreach (Products product in filtered)
                {
                    if (product.supplier != null && product.supplier == selectedSupplier)
                    {
                        needFilter.Add(product);
                    }
                }
                filtered = needFilter;
            }

            // Сортировка по количеству
            int sortIndex = Sort_comboBox.SelectedIndex;
            if (sortIndex == 1) // По возрастанию
            {
                for (int i = 0; i < filtered.Count - 1; i++)
                {
                    for (int j = 0; j < filtered.Count - 1 - i; j++)
                    {
                        if (filtered[j].stockQuantity > filtered[j + 1].stockQuantity)
                        {
                            Products prod = filtered[j];
                            filtered[j] = filtered[j + 1];
                            filtered[j + 1] = prod;
                        }
                    }
                }
            }
            else if (sortIndex == 2) // По убыванию
            {
                for (int i = 0; i < filtered.Count - 1; i++)
                {
                    for (int j = 0; j < filtered.Count - 1; j++)
                    {
                        if (filtered[j].stockQuantity < filtered[j + 1].stockQuantity)
                        {
                            Products prod = filtered[j];
                            filtered[j] = filtered[j + 1];
                            filtered[j + 1] = prod;
                        }
                    }
                }
            }

            ShowOnDisplayProducts(filtered);
        }
        private string AllAtributsForSearch(Products product)
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
        private void GetSuppliers()
        {
            if (allProducts_ != null)
            {
                // уникальные поставщики
                List<string> unicalSuppliers = new List<string>();
                foreach (Products product in allProducts_)
                {
                    string supplier = product.supplier;
                    if (!string.IsNullOrWhiteSpace(supplier) && !unicalSuppliers.Contains(supplier))
                    {
                        unicalSuppliers.Add(supplier);
                    }
                }
                unicalSuppliers.Sort();
                foreach (string supplier in unicalSuppliers)
                {
                    Filtert_comboBox.Items.Add(supplier);
                }
            }
            UpdateDisplay();
        }

        private void AddProduct_button_Click(object sender, EventArgs e)
        {
            ProductAddAndEditForm addForm = new ProductAddAndEditForm(null);
            if (addForm.ShowDialog() == DialogResult.Yes)
            {
                LoadProduct();
                UpdateDisplay();
            }
        }
    }
}
