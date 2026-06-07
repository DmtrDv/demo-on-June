using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DE_Lib;
using MySql.Data.MySqlClient;

namespace ShopApp
{
    public partial class ProductAddAndEditForm : Form
    {
        private Products currentProduct_;
        private string loadedImagePath_;
        private bool imageChanged_ = false;

        public ProductAddAndEditForm(Products product)
        {
            InitializeComponent();
            currentProduct_ = product;

            if (currentProduct_ == null)
            {
                this.Text = "Добавление товара";
            }
            else
            {
                this.Text = "Редактирование товара";
            }

            // Заполнение комбобоксов
            LoadComboBox();

            // Если редактирование, заполняем поля
            if (currentProduct_ != null)
            {
                Article_textBox.Text = currentProduct_.article;
                Article_textBox.ReadOnly = true;
                Name_textBox.Text = currentProduct_.name;
                Category_comboBox.Text = currentProduct_.category;
                Description_textBox.Text = currentProduct_.description;
                Manufacturer_comboBox.Text = currentProduct_.manufacturer;
                Supplier_textBox.Text = currentProduct_.supplier;
                Price_textBox.Text = currentProduct_.price.ToString();
                Unit_textBox.Text = currentProduct_.unit;
                Stock_numericUpDown.Value = currentProduct_.stockQuantity;
                Discount_numericUpDown.Value = (decimal)currentProduct_.discount;

                // Загружаем фото, если есть
                if (!string.IsNullOrEmpty(currentProduct_.pathPhoto))
                {
                    string photoPath = Path.Combine(Application.StartupPath, "Resource", currentProduct_.pathPhoto);
                    if (File.Exists(photoPath))
                    {
                        using (var fs = new FileStream(photoPath, FileMode.Open, FileAccess.Read))
                        using (var tempImage = Image.FromStream(fs))
                        {
                            Photo_pictureBox.Image = new Bitmap(tempImage);
                        }
                    }
                }
            }
            if (Photo_pictureBox.Image == null)
            {
                string defaultImagePath = Path.Combine(Application.StartupPath, "Resource", "picture.png");
                if (File.Exists(defaultImagePath))
                {
                    try
                    {
                        using (var fs = new FileStream(defaultImagePath, FileMode.Open, FileAccess.Read))
                        using (var tempImage = Image.FromStream(fs))
                        {
                            Photo_pictureBox.Image = new Bitmap(tempImage);
                        }
                    }
                    catch
                    {
                        Photo_pictureBox.Image = null;
                    }
                }
            }
            Delete_button.Visible = (currentProduct_ != null);
        }

        private void LoadComboBox()
        {
            try
            {
                Category_comboBox.Items.Clear();
                Category_comboBox.Items.AddRange(Database.GetCategories().ToArray());
                Manufacturer_comboBox.Items.Clear();
                Manufacturer_comboBox.Items.AddRange(Database.GetManufacturers().ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки списков: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPhoto_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                        using (var tempImage = Image.FromStream(fs))
                        {
                            Photo_pictureBox.Image?.Dispose();
                            Photo_pictureBox.Image = new Bitmap(tempImage);
                            imageChanged_ = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            // проверка
            if (string.IsNullOrWhiteSpace(Article_textBox.Text))
            {
                MessageBox.Show("Артикул не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(Name_textBox.Text))
            {
                MessageBox.Show("Наименование не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(Price_textBox.Text, out double price) || price < 0)
            {
                MessageBox.Show("Цена должна быть неотрицательным числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Stock_numericUpDown.Value < 0)
            {
                MessageBox.Show("Количество не может быть отрицательным.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(Category_comboBox.Text))
            {
                MessageBox.Show("Категория не может быть пустой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(Description_textBox.Text))
            {
                MessageBox.Show("Описание не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(Manufacturer_comboBox.Text))
            {
                MessageBox.Show("Производитель не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(Supplier_textBox.Text))
            {
                MessageBox.Show("Поставщик не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(Unit_textBox.Text))
            {
                MessageBox.Show("Единица измерения не может быть пустой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка уникальности артикула
            if (currentProduct_ == null)
            {
                try
                {
                    if (!Database.IsArticleUnique(Article_textBox.Text.Trim()))
                    {
                        MessageBox.Show("Товар с таким артикулом уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка проверки артикула: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Products product = new Products
            {
                article = Article_textBox.Text.Trim(),
                name = Name_textBox.Text.Trim(),
                unit = Unit_textBox.Text.Trim(),
                price = price,
                supplier = Supplier_textBox.Text.Trim(),
                manufacturer = Manufacturer_comboBox.Text.Trim(),
                category = Category_comboBox.Text.Trim(),
                discount = (int)Discount_numericUpDown.Value,
                stockQuantity = (int)Stock_numericUpDown.Value,
                description = Description_textBox.Text.Trim(),
                pathPhoto = currentProduct_.pathPhoto ?? "" 
            };

            if (imageChanged_ && Photo_pictureBox.Image != null)
            {
                // создаём имя файла 
                string safeArticle = string.Join("_", product.article.Split(Path.GetInvalidFileNameChars()));
                string fileName = safeArticle + ".jpg";
                string savePath = Path.Combine(Application.StartupPath, "Resource", fileName);

                try
                {
                    if (currentProduct_ != null && !string.IsNullOrEmpty(currentProduct_.pathPhoto))
                    {
                        string oldPath = Path.Combine(Application.StartupPath, "Resource", currentProduct_.pathPhoto);
                        if (File.Exists(oldPath) && oldPath != savePath)
                        {
                            File.Delete(oldPath);
                        }
                    }

                    // Сохранение нового изображения
                    Photo_pictureBox.Image.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    product.pathPhoto = fileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (currentProduct_ != null)
                {
                    product.pathPhoto = currentProduct_.pathPhoto;
                }
                else
                {
                    product.pathPhoto = "";
                }
            }

            // Сохранение в БД
            try
            {
                if (currentProduct_ == null)
                {
                    Database.AddProduct(product);
                    MessageBox.Show("Товар успешно добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Database.UpdateProduct(product);
                    MessageBox.Show("Товар успешно обновлён.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения в БД: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult = DialogResult.Yes;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (currentProduct_ == null) return;

            // Проверка есть ли товар в заказах
            try
            {
                if (Database.IsProductInOrders(currentProduct_.article))
                {
                    MessageBox.Show("Нельзя удалить товар, который присутствует в заказах.", "Предупреждение",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка проверки наличия в заказах: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show("Вы уверены, что хотите удалить товар?", "Подтверждение",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    if (!string.IsNullOrEmpty(currentProduct_.pathPhoto))
                    {
                        string photoPath = Path.Combine(Application.StartupPath, "Resource", currentProduct_.pathPhoto);
                        if (File.Exists(photoPath))
                            File.Delete(photoPath);
                    }

                    Database.DeleteProduct(currentProduct_.article);
                    MessageBox.Show("Товар удалён.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DialogResult = DialogResult.Yes;
        }

        private void ProductEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Photo_pictureBox.Image?.Dispose();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}