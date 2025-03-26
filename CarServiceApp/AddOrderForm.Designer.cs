namespace CarServiceApp
{
    partial class AddOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cars_CMBX = new System.Windows.Forms.ComboBox();
            this.services_CMBX = new System.Windows.Forms.ComboBox();
            this.clients_CMBX = new System.Windows.Forms.ComboBox();
            this.masters_CMBX = new System.Windows.Forms.ComboBox();
            this.count_NUD = new System.Windows.Forms.NumericUpDown();
            this.cost_NUD = new System.Windows.Forms.NumericUpDown();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.count_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автомобиль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Клиент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Услуга";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Мастер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Итоговая стоимость";
            // 
            // cars_CMBX
            // 
            this.cars_CMBX.FormattingEnabled = true;
            this.cars_CMBX.Location = new System.Drawing.Point(15, 29);
            this.cars_CMBX.Name = "cars_CMBX";
            this.cars_CMBX.Size = new System.Drawing.Size(378, 24);
            this.cars_CMBX.TabIndex = 6;
            // 
            // services_CMBX
            // 
            this.services_CMBX.FormattingEnabled = true;
            this.services_CMBX.Location = new System.Drawing.Point(15, 123);
            this.services_CMBX.Name = "services_CMBX";
            this.services_CMBX.Size = new System.Drawing.Size(378, 24);
            this.services_CMBX.TabIndex = 7;
            // 
            // clients_CMBX
            // 
            this.clients_CMBX.FormattingEnabled = true;
            this.clients_CMBX.Location = new System.Drawing.Point(15, 77);
            this.clients_CMBX.Name = "clients_CMBX";
            this.clients_CMBX.Size = new System.Drawing.Size(378, 24);
            this.clients_CMBX.TabIndex = 7;
            // 
            // masters_CMBX
            // 
            this.masters_CMBX.FormattingEnabled = true;
            this.masters_CMBX.Location = new System.Drawing.Point(15, 169);
            this.masters_CMBX.Name = "masters_CMBX";
            this.masters_CMBX.Size = new System.Drawing.Size(378, 24);
            this.masters_CMBX.TabIndex = 7;
            // 
            // count_NUD
            // 
            this.count_NUD.Location = new System.Drawing.Point(15, 215);
            this.count_NUD.Name = "count_NUD";
            this.count_NUD.Size = new System.Drawing.Size(378, 22);
            this.count_NUD.TabIndex = 8;
            // 
            // cost_NUD
            // 
            this.cost_NUD.Location = new System.Drawing.Point(15, 259);
            this.cost_NUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cost_NUD.Name = "cost_NUD";
            this.cost_NUD.Size = new System.Drawing.Size(378, 22);
            this.cost_NUD.TabIndex = 9;
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(15, 288);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(193, 23);
            this.acceptBtn.TabIndex = 10;
            this.acceptBtn.Text = "Добавить";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(214, 287);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(179, 23);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "Отменить";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 333);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.cost_NUD);
            this.Controls.Add(this.count_NUD);
            this.Controls.Add(this.clients_CMBX);
            this.Controls.Add(this.masters_CMBX);
            this.Controls.Add(this.services_CMBX);
            this.Controls.Add(this.cars_CMBX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(425, 380);
            this.MinimumSize = new System.Drawing.Size(425, 380);
            this.Name = "AddOrderForm";
            this.Text = "Добавление заказа";
            ((System.ComponentModel.ISupportInitialize)(this.count_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cars_CMBX;
        private System.Windows.Forms.ComboBox services_CMBX;
        private System.Windows.Forms.ComboBox clients_CMBX;
        private System.Windows.Forms.ComboBox masters_CMBX;
        private System.Windows.Forms.NumericUpDown count_NUD;
        private System.Windows.Forms.NumericUpDown cost_NUD;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}