namespace DE_Forms
{
    partial class WindowWatchingForm
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
            this.MainPanel_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FioUser_label = new System.Windows.Forms.Label();
            this.Find_label = new System.Windows.Forms.Label();
            this.FindText_textBox = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Sort_label = new System.Windows.Forms.Label();
            this.Sort_comboBox = new System.Windows.Forms.ComboBox();
            this.Filter_label = new System.Windows.Forms.Label();
            this.Filtert_comboBox = new System.Windows.Forms.ComboBox();
            this.AddProduct_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel_flowLayoutPanel
            // 
            this.MainPanel_flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel_flowLayoutPanel.AutoScroll = true;
            this.MainPanel_flowLayoutPanel.BackColor = System.Drawing.Color.Chartreuse;
            this.MainPanel_flowLayoutPanel.Location = new System.Drawing.Point(0, 70);
            this.MainPanel_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel_flowLayoutPanel.Name = "MainPanel_flowLayoutPanel";
            this.MainPanel_flowLayoutPanel.Size = new System.Drawing.Size(1067, 484);
            this.MainPanel_flowLayoutPanel.TabIndex = 0;
            // 
            // FioUser_label
            // 
            this.FioUser_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FioUser_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FioUser_label.Location = new System.Drawing.Point(734, -2);
            this.FioUser_label.Name = "FioUser_label";
            this.FioUser_label.Size = new System.Drawing.Size(333, 32);
            this.FioUser_label.TabIndex = 2;
            this.FioUser_label.Text = "fio user";
            this.FioUser_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Find_label
            // 
            this.Find_label.AutoSize = true;
            this.Find_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find_label.Location = new System.Drawing.Point(3, 0);
            this.Find_label.Name = "Find_label";
            this.Find_label.Size = new System.Drawing.Size(52, 18);
            this.Find_label.TabIndex = 3;
            this.Find_label.Text = "Поиск";
            this.Find_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FindText_textBox
            // 
            this.FindText_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindText_textBox.Location = new System.Drawing.Point(61, 3);
            this.FindText_textBox.Name = "FindText_textBox";
            this.FindText_textBox.Size = new System.Drawing.Size(127, 24);
            this.FindText_textBox.TabIndex = 4;
            this.FindText_textBox.TextChanged += new System.EventHandler(this.findText_textBox_TextChanged);
            // 
            // back_button
            // 
            this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.back_button.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.Location = new System.Drawing.Point(944, 30);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(114, 35);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.Find_label);
            this.flowLayoutPanel1.Controls.Add(this.FindText_textBox);
            this.flowLayoutPanel1.Controls.Add(this.Sort_label);
            this.flowLayoutPanel1.Controls.Add(this.Sort_comboBox);
            this.flowLayoutPanel1.Controls.Add(this.Filter_label);
            this.flowLayoutPanel1.Controls.Add(this.Filtert_comboBox);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(733, 32);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // Sort_label
            // 
            this.Sort_label.AutoSize = true;
            this.Sort_label.Location = new System.Drawing.Point(194, 0);
            this.Sort_label.Name = "Sort_label";
            this.Sort_label.Size = new System.Drawing.Size(99, 18);
            this.Sort_label.TabIndex = 5;
            this.Sort_label.Text = "Сортировать";
            this.Sort_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sort_comboBox
            // 
            this.Sort_comboBox.FormattingEnabled = true;
            this.Sort_comboBox.Items.AddRange(new object[] {
            "Без сортировки",
            "По возрастанию",
            "По убыванию"});
            this.Sort_comboBox.Location = new System.Drawing.Point(299, 3);
            this.Sort_comboBox.Name = "Sort_comboBox";
            this.Sort_comboBox.Size = new System.Drawing.Size(158, 26);
            this.Sort_comboBox.TabIndex = 6;
            this.Sort_comboBox.SelectedIndexChanged += new System.EventHandler(this.Sort_comboBox_SelectedIndexChanged);
            // 
            // Filter_label
            // 
            this.Filter_label.AutoSize = true;
            this.Filter_label.Location = new System.Drawing.Point(463, 0);
            this.Filter_label.Name = "Filter_label";
            this.Filter_label.Size = new System.Drawing.Size(101, 18);
            this.Filter_label.TabIndex = 7;
            this.Filter_label.Text = "Фильтровать";
            // 
            // Filtert_comboBox
            // 
            this.Filtert_comboBox.FormattingEnabled = true;
            this.Filtert_comboBox.Items.AddRange(new object[] {
            "Все поставщики"});
            this.Filtert_comboBox.Location = new System.Drawing.Point(570, 3);
            this.Filtert_comboBox.Name = "Filtert_comboBox";
            this.Filtert_comboBox.Size = new System.Drawing.Size(153, 26);
            this.Filtert_comboBox.TabIndex = 8;
            this.Filtert_comboBox.SelectedIndexChanged += new System.EventHandler(this.Filtert_comboBox_SelectedIndexChanged);
            // 
            // AddProduct_button
            // 
            this.AddProduct_button.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.AddProduct_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduct_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProduct_button.Location = new System.Drawing.Point(6, 33);
            this.AddProduct_button.Name = "AddProduct_button";
            this.AddProduct_button.Size = new System.Drawing.Size(114, 35);
            this.AddProduct_button.TabIndex = 7;
            this.AddProduct_button.Text = "Добавить";
            this.AddProduct_button.UseVisualStyleBackColor = false;
            this.AddProduct_button.Click += new System.EventHandler(this.AddProduct_button_Click);
            // 
            // WindowWatchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.AddProduct_button);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.FioUser_label);
            this.Controls.Add(this.MainPanel_flowLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WindowWatchingForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно просмотра";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowWatchingForm_FormClosing);
            this.Load += new System.EventHandler(this.WindowWatchingForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainPanel_flowLayoutPanel;
        private System.Windows.Forms.Label FioUser_label;
        private System.Windows.Forms.Label Find_label;
        private System.Windows.Forms.TextBox FindText_textBox;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Sort_label;
        private System.Windows.Forms.ComboBox Sort_comboBox;
        private System.Windows.Forms.Label Filter_label;
        private System.Windows.Forms.ComboBox Filtert_comboBox;
        private System.Windows.Forms.Button AddProduct_button;
    }
}