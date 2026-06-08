namespace DE_Forms
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Orders_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Orders_flowLayoutPanel
            // 
            this.Orders_flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Orders_flowLayoutPanel.AutoScroll = true;
            this.Orders_flowLayoutPanel.BackColor = System.Drawing.Color.Silver;
            this.Orders_flowLayoutPanel.Location = new System.Drawing.Point(0, 48);
            this.Orders_flowLayoutPanel.Name = "Orders_flowLayoutPanel";
            this.Orders_flowLayoutPanel.Size = new System.Drawing.Size(901, 387);
            this.Orders_flowLayoutPanel.TabIndex = 0;
            // 
            // Back_button
            // 
            this.Back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Location = new System.Drawing.Point(770, 6);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(118, 36);
            this.Back_button.TabIndex = 1;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 433);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Orders_flowLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "OrdersForm";
            this.Text = "Заказы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Orders_flowLayoutPanel;
        private System.Windows.Forms.Button Back_button;
    }
}