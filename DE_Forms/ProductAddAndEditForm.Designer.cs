using System.Windows.Forms;

namespace ShopApp
{
    partial class ProductAddAndEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Photo_pictureBox = new System.Windows.Forms.PictureBox();
            this.LoadPhoto_button = new System.Windows.Forms.Button();
            this.Article_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Category_comboBox = new System.Windows.Forms.ComboBox();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.Manufacturer_comboBox = new System.Windows.Forms.ComboBox();
            this.Supplier_textBox = new System.Windows.Forms.TextBox();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.Unit_textBox = new System.Windows.Forms.TextBox();
            this.Stock_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Discount_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Save_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Photo_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Discount_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Photo_pictureBox
            // 
            this.Photo_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Photo_pictureBox.Location = new System.Drawing.Point(15, 15);
            this.Photo_pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.Photo_pictureBox.Name = "Photo_pictureBox";
            this.Photo_pictureBox.Size = new System.Drawing.Size(207, 207);
            this.Photo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo_pictureBox.TabIndex = 0;
            this.Photo_pictureBox.TabStop = false;
            // 
            // LoadPhoto_button
            // 
            this.LoadPhoto_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadPhoto_button.Location = new System.Drawing.Point(13, 231);
            this.LoadPhoto_button.Margin = new System.Windows.Forms.Padding(4);
            this.LoadPhoto_button.Name = "LoadPhoto_button";
            this.LoadPhoto_button.Size = new System.Drawing.Size(209, 51);
            this.LoadPhoto_button.TabIndex = 1;
            this.LoadPhoto_button.Text = "Загрузить фото";
            this.LoadPhoto_button.UseVisualStyleBackColor = true;
            this.LoadPhoto_button.Click += new System.EventHandler(this.LoadPhoto_button_Click);
            // 
            // Article_textBox
            // 
            this.Article_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Article_textBox.Location = new System.Drawing.Point(382, 12);
            this.Article_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Article_textBox.Name = "Article_textBox";
            this.Article_textBox.Size = new System.Drawing.Size(223, 24);
            this.Article_textBox.TabIndex = 2;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_textBox.Location = new System.Drawing.Point(382, 53);
            this.Name_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(223, 24);
            this.Name_textBox.TabIndex = 3;
            // 
            // Category_comboBox
            // 
            this.Category_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Category_comboBox.Location = new System.Drawing.Point(382, 95);
            this.Category_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Category_comboBox.Name = "Category_comboBox";
            this.Category_comboBox.Size = new System.Drawing.Size(223, 26);
            this.Category_comboBox.TabIndex = 4;
            // 
            // Description_textBox
            // 
            this.Description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description_textBox.Location = new System.Drawing.Point(382, 137);
            this.Description_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Description_textBox.Multiline = true;
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(298, 82);
            this.Description_textBox.TabIndex = 5;
            // 
            // Manufacturer_comboBox
            // 
            this.Manufacturer_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Manufacturer_comboBox.Location = new System.Drawing.Point(382, 233);
            this.Manufacturer_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Manufacturer_comboBox.Name = "Manufacturer_comboBox";
            this.Manufacturer_comboBox.Size = new System.Drawing.Size(223, 26);
            this.Manufacturer_comboBox.TabIndex = 6;
            // 
            // Supplier_textBox
            // 
            this.Supplier_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Supplier_textBox.Location = new System.Drawing.Point(382, 275);
            this.Supplier_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Supplier_textBox.Name = "Supplier_textBox";
            this.Supplier_textBox.Size = new System.Drawing.Size(223, 24);
            this.Supplier_textBox.TabIndex = 7;
            // 
            // Price_textBox
            // 
            this.Price_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_textBox.Location = new System.Drawing.Point(382, 317);
            this.Price_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(223, 24);
            this.Price_textBox.TabIndex = 8;
            // 
            // Unit_textBox
            // 
            this.Unit_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Unit_textBox.Location = new System.Drawing.Point(382, 357);
            this.Unit_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Unit_textBox.Name = "Unit_textBox";
            this.Unit_textBox.Size = new System.Drawing.Size(223, 24);
            this.Unit_textBox.TabIndex = 9;
            // 
            // Stock_numericUpDown
            // 
            this.Stock_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stock_numericUpDown.Location = new System.Drawing.Point(382, 399);
            this.Stock_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.Stock_numericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Stock_numericUpDown.Name = "Stock_numericUpDown";
            this.Stock_numericUpDown.Size = new System.Drawing.Size(180, 24);
            this.Stock_numericUpDown.TabIndex = 10;
            // 
            // Discount_numericUpDown
            // 
            this.Discount_numericUpDown.DecimalPlaces = 2;
            this.Discount_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discount_numericUpDown.Location = new System.Drawing.Point(382, 441);
            this.Discount_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.Discount_numericUpDown.Name = "Discount_numericUpDown";
            this.Discount_numericUpDown.Size = new System.Drawing.Size(180, 24);
            this.Discount_numericUpDown.TabIndex = 11;
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.Location = new System.Drawing.Point(15, 517);
            this.Save_button.Margin = new System.Windows.Forms.Padding(4);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(144, 37);
            this.Save_button.TabIndex = 12;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(536, 517);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(144, 38);
            this.Cancel_button.TabIndex = 13;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(276, 517);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(4);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(144, 37);
            this.Delete_button.TabIndex = 14;
            this.Delete_button.Text = "Удалить";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(295, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Артикул:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(253, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Наименование:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(283, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Категория:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(283, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Описание:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(253, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Производитель:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(283, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Поставщик:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(312, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Цена:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(297, 354);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ед. изм.:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(312, 395);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Кол-во:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(290, 436);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Скидка %:";
            // 
            // ProductEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 567);
            this.ControlBox = false;
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Discount_numericUpDown);
            this.Controls.Add(this.Stock_numericUpDown);
            this.Controls.Add(this.Unit_textBox);
            this.Controls.Add(this.Price_textBox);
            this.Controls.Add(this.Supplier_textBox);
            this.Controls.Add(this.Manufacturer_comboBox);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.Category_comboBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Article_textBox);
            this.Controls.Add(this.LoadPhoto_button);
            this.Controls.Add(this.Photo_pictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductEditForm";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductEditForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Photo_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Discount_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox Photo_pictureBox;
        private System.Windows.Forms.Button LoadPhoto_button;
        private System.Windows.Forms.TextBox Article_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.ComboBox Category_comboBox;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.ComboBox Manufacturer_comboBox;
        private System.Windows.Forms.TextBox Supplier_textBox;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.TextBox Unit_textBox;
        private System.Windows.Forms.NumericUpDown Stock_numericUpDown;
        private System.Windows.Forms.NumericUpDown Discount_numericUpDown;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}