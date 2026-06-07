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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowWatchingForm));
            this.MainPanel_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FioUser_label = new System.Windows.Forms.Label();
            this.find_label = new System.Windows.Forms.Label();
            this.findText_textBox = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
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
            this.FioUser_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FioUser_label.Location = new System.Drawing.Point(734, -2);
            this.FioUser_label.Name = "FioUser_label";
            this.FioUser_label.Size = new System.Drawing.Size(333, 32);
            this.FioUser_label.TabIndex = 2;
            this.FioUser_label.Text = "fio user";
            this.FioUser_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // find_label
            // 
            this.find_label.AutoSize = true;
            this.find_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_label.Location = new System.Drawing.Point(9, 9);
            this.find_label.Name = "find_label";
            this.find_label.Size = new System.Drawing.Size(52, 18);
            this.find_label.TabIndex = 3;
            this.find_label.Text = "Поиск";
            // 
            // findText_textBox
            // 
            this.findText_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findText_textBox.Location = new System.Drawing.Point(70, 6);
            this.findText_textBox.Name = "findText_textBox";
            this.findText_textBox.Size = new System.Drawing.Size(127, 24);
            this.findText_textBox.TabIndex = 4;
            this.findText_textBox.TextChanged += new System.EventHandler(this.findText_textBox_TextChanged_1);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.Location = new System.Drawing.Point(941, 28);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(114, 35);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // WindowWatchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.findText_textBox);
            this.Controls.Add(this.find_label);
            this.Controls.Add(this.FioUser_label);
            this.Controls.Add(this.MainPanel_flowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WindowWatchingForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно просмотра";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowWatchingForm_FormClosing);
            this.Load += new System.EventHandler(this.WindowWatchingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainPanel_flowLayoutPanel;
        private System.Windows.Forms.Label FioUser_label;
        private System.Windows.Forms.Label find_label;
        private System.Windows.Forms.TextBox findText_textBox;
        private System.Windows.Forms.Button back_button;
    }
}