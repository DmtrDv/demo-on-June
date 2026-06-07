using DE_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Forms
{
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }
        public void SetProduct(Products product)
        {
            if (product == null)
            {
                return;
            }
            //заполнение полей
            NameAndCategoryProduct_label.Text = product.name + " | " + product.category;
            descriptioinProduct_label.Text = "Описание: " + product.description;
            manufacturer_label.Text = "Производитель: " + product.manufacturer;
            supplier_label.Text = "Поставщик: " + product.supplier;
            unit_label.Text = product.unit;
            stockQuantity_label.Text = "Количество на складе: " + product.stockQuantity;
            discount_label.Text = product.discount.ToString() + "%";

            double price = product.price;
            double discount = product.discount;

            if (discount > 0)
            {
                double newPrice = price * (100 - discount) / 100;

                //старая цена
                price_label.Text = "Цена: " + price.ToString() + " Руб.";
                price_label.Font = new Font(price_label.Font, FontStyle.Strikeout);
                price_label.ForeColor = Color.Red;
                //новая цена
                newPrice_label.Text = newPrice.ToString() + " Руб.";
                newPrice_label.ForeColor = Color.Black;
            }
            else
            {
                price_label.Text = "Цена: " + price.ToString() + " Руб.";
                price_label.Font = new Font(price_label.Font, FontStyle.Regular);
                price_label.ForeColor = Color.Black;
            }
            if (product.stockQuantity <= 0)
            {
                stockQuantity_label.ForeColor = Color.LightBlue;
            }
            if (discount > 15)
            {
                // цвет фона при скидке >
                this.BackColor = Color.SeaGreen;
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }
            LoadImage(product.pathPhoto);
        }
        private void LoadImage(string pathPhoto)
        {
            if (!string.IsNullOrEmpty(pathPhoto))
            {
                string imagePath = Path.Combine(Application.StartupPath, "Resource", pathPhoto);
                if (File.Exists(imagePath))
                {
                    try
                    {
                        product_pictureBox.Image?.Dispose();
                        product_pictureBox.Image = Image.FromFile(imagePath);
                        return;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Ошибка загрузки {imagePath}: {ex.Message}");
                    }
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Файл не найден: {imagePath}");
                }
            }
            string defaultImagePath = Path.Combine(Application.StartupPath, "Resource", "picture.png");
            if (File.Exists(defaultImagePath))
            {
                try
                {
                    product_pictureBox.Image?.Dispose();
                    product_pictureBox.Image = Image.FromFile(defaultImagePath);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Ошибка загрузки заглушки {defaultImagePath}: {ex.Message}");
                    product_pictureBox.Image = null;
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"Файл заглушки не найден: {defaultImagePath}");
                product_pictureBox.Image = null;
            }
        }
    }
}
