namespace CarServiceApp
{
    partial class AddCarForm
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
            this.carBrand_TBX = new System.Windows.Forms.TextBox();
            this.carModel_TBX = new System.Windows.Forms.TextBox();
            this.engineType_TBX = new System.Windows.Forms.TextBox();
            this.registerNumber_TBX = new System.Windows.Forms.TextBox();
            this.releaseDate_DTP = new System.Windows.Forms.DateTimePicker();
            this.Mileage_NUD = new System.Windows.Forms.NumericUpDown();
            this.acceptBut = new System.Windows.Forms.Button();
            this.closeBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Mileage_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бренд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тип двигателя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Регистрационный номер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Год выпуска";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пробег";
            // 
            // carBrand_TBX
            // 
            this.carBrand_TBX.Location = new System.Drawing.Point(15, 29);
            this.carBrand_TBX.Name = "carBrand_TBX";
            this.carBrand_TBX.Size = new System.Drawing.Size(200, 22);
            this.carBrand_TBX.TabIndex = 6;
            // 
            // carModel_TBX
            // 
            this.carModel_TBX.Location = new System.Drawing.Point(15, 74);
            this.carModel_TBX.Name = "carModel_TBX";
            this.carModel_TBX.Size = new System.Drawing.Size(200, 22);
            this.carModel_TBX.TabIndex = 7;
            // 
            // engineType_TBX
            // 
            this.engineType_TBX.Location = new System.Drawing.Point(15, 119);
            this.engineType_TBX.Name = "engineType_TBX";
            this.engineType_TBX.Size = new System.Drawing.Size(200, 22);
            this.engineType_TBX.TabIndex = 8;
            // 
            // registerNumber_TBX
            // 
            this.registerNumber_TBX.Location = new System.Drawing.Point(15, 164);
            this.registerNumber_TBX.Name = "registerNumber_TBX";
            this.registerNumber_TBX.Size = new System.Drawing.Size(200, 22);
            this.registerNumber_TBX.TabIndex = 9;
            // 
            // releaseDate_DTP
            // 
            this.releaseDate_DTP.Location = new System.Drawing.Point(15, 209);
            this.releaseDate_DTP.Name = "releaseDate_DTP";
            this.releaseDate_DTP.Size = new System.Drawing.Size(200, 22);
            this.releaseDate_DTP.TabIndex = 10;
            // 
            // Mileage_NUD
            // 
            this.Mileage_NUD.Location = new System.Drawing.Point(15, 253);
            this.Mileage_NUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Mileage_NUD.Name = "Mileage_NUD";
            this.Mileage_NUD.Size = new System.Drawing.Size(200, 22);
            this.Mileage_NUD.TabIndex = 11;
            // 
            // acceptBut
            // 
            this.acceptBut.Location = new System.Drawing.Point(15, 282);
            this.acceptBut.Name = "acceptBut";
            this.acceptBut.Size = new System.Drawing.Size(100, 23);
            this.acceptBut.TabIndex = 12;
            this.acceptBut.Text = "Добавить";
            this.acceptBut.UseVisualStyleBackColor = true;
            this.acceptBut.Click += new System.EventHandler(this.acceptBut_Click);
            // 
            // closeBut
            // 
            this.closeBut.Location = new System.Drawing.Point(121, 282);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(93, 23);
            this.closeBut.TabIndex = 13;
            this.closeBut.Text = "Отмена";
            this.closeBut.UseVisualStyleBackColor = true;
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 313);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.acceptBut);
            this.Controls.Add(this.Mileage_NUD);
            this.Controls.Add(this.releaseDate_DTP);
            this.Controls.Add(this.registerNumber_TBX);
            this.Controls.Add(this.engineType_TBX);
            this.Controls.Add(this.carModel_TBX);
            this.Controls.Add(this.carBrand_TBX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(250, 360);
            this.MinimumSize = new System.Drawing.Size(250, 360);
            this.Name = "AddCarForm";
            this.Text = "Добавление автомобиля";
            ((System.ComponentModel.ISupportInitialize)(this.Mileage_NUD)).EndInit();
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
        private System.Windows.Forms.TextBox carBrand_TBX;
        private System.Windows.Forms.TextBox carModel_TBX;
        private System.Windows.Forms.TextBox engineType_TBX;
        private System.Windows.Forms.TextBox registerNumber_TBX;
        private System.Windows.Forms.DateTimePicker releaseDate_DTP;
        private System.Windows.Forms.NumericUpDown Mileage_NUD;
        private System.Windows.Forms.Button acceptBut;
        private System.Windows.Forms.Button closeBut;
    }
}