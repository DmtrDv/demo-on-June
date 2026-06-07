namespace DE_Forms
{
    partial class Card
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.product_pictureBox = new System.Windows.Forms.PictureBox();
            this.NameAndCategoryProduct_label = new System.Windows.Forms.Label();
            this.discount_label = new System.Windows.Forms.Label();
            this.descriptioinProduct_label = new System.Windows.Forms.Label();
            this.manufacturer_label = new System.Windows.Forms.Label();
            this.supplier_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.unit_label = new System.Windows.Forms.Label();
            this.stockQuantity_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newPrice_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // product_pictureBox
            // 
            this.product_pictureBox.BackColor = System.Drawing.Color.White;
            this.product_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.product_pictureBox.Location = new System.Drawing.Point(5, 4);
            this.product_pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.product_pictureBox.Name = "product_pictureBox";
            this.product_pictureBox.Size = new System.Drawing.Size(206, 190);
            this.product_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.product_pictureBox.TabIndex = 0;
            this.product_pictureBox.TabStop = false;
            // 
            // NameAndCategoryProduct_label
            // 
            this.NameAndCategoryProduct_label.AutoSize = true;
            this.NameAndCategoryProduct_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameAndCategoryProduct_label.Location = new System.Drawing.Point(215, 5);
            this.NameAndCategoryProduct_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameAndCategoryProduct_label.Name = "NameAndCategoryProduct_label";
            this.NameAndCategoryProduct_label.Size = new System.Drawing.Size(386, 23);
            this.NameAndCategoryProduct_label.TabIndex = 1;
            this.NameAndCategoryProduct_label.Text = "Категория товара | Наименование товара";
            // 
            // discount_label
            // 
            this.discount_label.AutoSize = true;
            this.discount_label.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discount_label.Location = new System.Drawing.Point(52, 84);
            this.discount_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discount_label.Name = "discount_label";
            this.discount_label.Size = new System.Drawing.Size(34, 39);
            this.discount_label.TabIndex = 3;
            this.discount_label.Text = "0";
            // 
            // descriptioinProduct_label
            // 
            this.descriptioinProduct_label.CausesValidation = false;
            this.descriptioinProduct_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptioinProduct_label.Location = new System.Drawing.Point(215, 28);
            this.descriptioinProduct_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptioinProduct_label.Name = "descriptioinProduct_label";
            this.descriptioinProduct_label.Size = new System.Drawing.Size(469, 47);
            this.descriptioinProduct_label.TabIndex = 4;
            this.descriptioinProduct_label.Text = "Описание товара:";
            // 
            // manufacturer_label
            // 
            this.manufacturer_label.CausesValidation = false;
            this.manufacturer_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturer_label.Location = new System.Drawing.Point(215, 74);
            this.manufacturer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manufacturer_label.Name = "manufacturer_label";
            this.manufacturer_label.Size = new System.Drawing.Size(469, 26);
            this.manufacturer_label.TabIndex = 5;
            this.manufacturer_label.Text = "Производитель:";
            // 
            // supplier_label
            // 
            this.supplier_label.CausesValidation = false;
            this.supplier_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplier_label.Location = new System.Drawing.Point(215, 98);
            this.supplier_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supplier_label.Name = "supplier_label";
            this.supplier_label.Size = new System.Drawing.Size(469, 26);
            this.supplier_label.TabIndex = 6;
            this.supplier_label.Text = "Поставщик:";
            // 
            // price_label
            // 
            this.price_label.CausesValidation = false;
            this.price_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_label.Location = new System.Drawing.Point(215, 124);
            this.price_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(204, 26);
            this.price_label.TabIndex = 7;
            this.price_label.Text = "Цена:";
            // 
            // unit_label
            // 
            this.unit_label.CausesValidation = false;
            this.unit_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unit_label.Location = new System.Drawing.Point(215, 149);
            this.unit_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unit_label.Name = "unit_label";
            this.unit_label.Size = new System.Drawing.Size(469, 26);
            this.unit_label.TabIndex = 8;
            this.unit_label.Text = "Единица измерения:";
            // 
            // stockQuantity_label
            // 
            this.stockQuantity_label.CausesValidation = false;
            this.stockQuantity_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stockQuantity_label.Location = new System.Drawing.Point(215, 175);
            this.stockQuantity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockQuantity_label.Name = "stockQuantity_label";
            this.stockQuantity_label.Size = new System.Drawing.Size(469, 26);
            this.stockQuantity_label.TabIndex = 9;
            this.stockQuantity_label.Text = "Количество на складе:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.discount_label);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(688, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(135, 198);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // newPrice_label
            // 
            this.newPrice_label.CausesValidation = false;
            this.newPrice_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPrice_label.Location = new System.Drawing.Point(425, 124);
            this.newPrice_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newPrice_label.Name = "newPrice_label";
            this.newPrice_label.Size = new System.Drawing.Size(204, 26);
            this.newPrice_label.TabIndex = 11;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.newPrice_label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stockQuantity_label);
            this.Controls.Add(this.unit_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.supplier_label);
            this.Controls.Add(this.manufacturer_label);
            this.Controls.Add(this.descriptioinProduct_label);
            this.Controls.Add(this.NameAndCategoryProduct_label);
            this.Controls.Add(this.product_pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(827, 201);
            ((System.ComponentModel.ISupportInitialize)(this.product_pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox product_pictureBox;
        private System.Windows.Forms.Label NameAndCategoryProduct_label;
        private System.Windows.Forms.Label discount_label;
        private System.Windows.Forms.Label descriptioinProduct_label;
        private System.Windows.Forms.Label manufacturer_label;
        private System.Windows.Forms.Label supplier_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label unit_label;
        private System.Windows.Forms.Label stockQuantity_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label newPrice_label;
    }
}
