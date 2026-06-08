namespace DE_Forms
{
    partial class orderCard
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
            this.Main_groupBox = new System.Windows.Forms.GroupBox();
            this.DateOrder_label = new System.Windows.Forms.Label();
            this.Adress_label = new System.Windows.Forms.Label();
            this.Status_label = new System.Windows.Forms.Label();
            this.Article_label = new System.Windows.Forms.Label();
            this.DateDelivery_groupBox = new System.Windows.Forms.GroupBox();
            this.DateDelivery_label = new System.Windows.Forms.Label();
            this.Main_groupBox.SuspendLayout();
            this.DateDelivery_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_groupBox
            // 
            this.Main_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Main_groupBox.Controls.Add(this.DateOrder_label);
            this.Main_groupBox.Controls.Add(this.Adress_label);
            this.Main_groupBox.Controls.Add(this.Status_label);
            this.Main_groupBox.Controls.Add(this.Article_label);
            this.Main_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_groupBox.Location = new System.Drawing.Point(3, 4);
            this.Main_groupBox.Name = "Main_groupBox";
            this.Main_groupBox.Size = new System.Drawing.Size(478, 152);
            this.Main_groupBox.TabIndex = 0;
            this.Main_groupBox.TabStop = false;
            // 
            // DateOrder_label
            // 
            this.DateOrder_label.AutoSize = true;
            this.DateOrder_label.Location = new System.Drawing.Point(6, 114);
            this.DateOrder_label.Name = "DateOrder_label";
            this.DateOrder_label.Size = new System.Drawing.Size(99, 18);
            this.DateOrder_label.TabIndex = 3;
            this.DateOrder_label.Text = "Дата заказа:";
            // 
            // Adress_label
            // 
            this.Adress_label.AutoSize = true;
            this.Adress_label.Location = new System.Drawing.Point(6, 85);
            this.Adress_label.Name = "Adress_label";
            this.Adress_label.Size = new System.Drawing.Size(54, 18);
            this.Adress_label.TabIndex = 2;
            this.Adress_label.Text = "Адрес:";
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.Location = new System.Drawing.Point(6, 49);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(112, 18);
            this.Status_label.TabIndex = 1;
            this.Status_label.Text = "Статус заказа:";
            // 
            // Article_label
            // 
            this.Article_label.AutoSize = true;
            this.Article_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Article_label.Location = new System.Drawing.Point(6, 18);
            this.Article_label.Name = "Article_label";
            this.Article_label.Size = new System.Drawing.Size(76, 18);
            this.Article_label.TabIndex = 0;
            this.Article_label.Text = "Артикул:";
            // 
            // DateDelivery_groupBox
            // 
            this.DateDelivery_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateDelivery_groupBox.Controls.Add(this.DateDelivery_label);
            this.DateDelivery_groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DateDelivery_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateDelivery_groupBox.Location = new System.Drawing.Point(487, 4);
            this.DateDelivery_groupBox.Name = "DateDelivery_groupBox";
            this.DateDelivery_groupBox.Size = new System.Drawing.Size(202, 152);
            this.DateDelivery_groupBox.TabIndex = 1;
            this.DateDelivery_groupBox.TabStop = false;
            // 
            // DateDelivery_label
            // 
            this.DateDelivery_label.Location = new System.Drawing.Point(25, 40);
            this.DateDelivery_label.Name = "DateDelivery_label";
            this.DateDelivery_label.Size = new System.Drawing.Size(150, 50);
            this.DateDelivery_label.TabIndex = 4;
            this.DateDelivery_label.Text = "Дата доставки:";
            this.DateDelivery_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // orderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.DateDelivery_groupBox);
            this.Controls.Add(this.Main_groupBox);
            this.Name = "orderCard";
            this.Size = new System.Drawing.Size(700, 167);
            this.Main_groupBox.ResumeLayout(false);
            this.Main_groupBox.PerformLayout();
            this.DateDelivery_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Main_groupBox;
        private System.Windows.Forms.GroupBox DateDelivery_groupBox;
        private System.Windows.Forms.Label Article_label;
        private System.Windows.Forms.Label Adress_label;
        private System.Windows.Forms.Label Status_label;
        private System.Windows.Forms.Label DateOrder_label;
        private System.Windows.Forms.Label DateDelivery_label;
    }
}
