namespace CarServiceApp
{
    partial class AddClientForm
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
            this.acceptBut = new System.Windows.Forms.Button();
            this.closeBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phone_TBX = new System.Windows.Forms.TextBox();
            this.address_TBX = new System.Windows.Forms.TextBox();
            this.patronymic_TBX = new System.Windows.Forms.TextBox();
            this.name_TBX = new System.Windows.Forms.TextBox();
            this.surname_TBX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // acceptBut
            // 
            this.acceptBut.Location = new System.Drawing.Point(15, 232);
            this.acceptBut.Name = "acceptBut";
            this.acceptBut.Size = new System.Drawing.Size(104, 23);
            this.acceptBut.TabIndex = 0;
            this.acceptBut.Text = "Добавить";
            this.acceptBut.UseVisualStyleBackColor = true;
            this.acceptBut.Click += new System.EventHandler(this.acceptBut_Click);
            // 
            // closeBut
            // 
            this.closeBut.Location = new System.Drawing.Point(125, 232);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(112, 23);
            this.closeBut.TabIndex = 1;
            this.closeBut.Text = "Отмена";
            this.closeBut.UseVisualStyleBackColor = true;
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество (при наличии)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Телефон";
            // 
            // phone_TBX
            // 
            this.phone_TBX.Location = new System.Drawing.Point(15, 204);
            this.phone_TBX.MaxLength = 11;
            this.phone_TBX.Name = "phone_TBX";
            this.phone_TBX.Size = new System.Drawing.Size(222, 22);
            this.phone_TBX.TabIndex = 7;
            // 
            // address_TBX
            // 
            this.address_TBX.Location = new System.Drawing.Point(15, 160);
            this.address_TBX.Name = "address_TBX";
            this.address_TBX.Size = new System.Drawing.Size(222, 22);
            this.address_TBX.TabIndex = 8;
            // 
            // patronymic_TBX
            // 
            this.patronymic_TBX.Location = new System.Drawing.Point(15, 116);
            this.patronymic_TBX.Name = "patronymic_TBX";
            this.patronymic_TBX.Size = new System.Drawing.Size(222, 22);
            this.patronymic_TBX.TabIndex = 9;
            // 
            // name_TBX
            // 
            this.name_TBX.Location = new System.Drawing.Point(15, 72);
            this.name_TBX.Name = "name_TBX";
            this.name_TBX.Size = new System.Drawing.Size(222, 22);
            this.name_TBX.TabIndex = 10;
            // 
            // surname_TBX
            // 
            this.surname_TBX.Location = new System.Drawing.Point(15, 28);
            this.surname_TBX.Name = "surname_TBX";
            this.surname_TBX.Size = new System.Drawing.Size(222, 22);
            this.surname_TBX.TabIndex = 11;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 268);
            this.Controls.Add(this.surname_TBX);
            this.Controls.Add(this.name_TBX);
            this.Controls.Add(this.patronymic_TBX);
            this.Controls.Add(this.address_TBX);
            this.Controls.Add(this.phone_TBX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.acceptBut);
            this.MaximumSize = new System.Drawing.Size(270, 315);
            this.MinimumSize = new System.Drawing.Size(270, 315);
            this.Name = "AddClientForm";
            this.Text = "Добавление клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptBut;
        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone_TBX;
        private System.Windows.Forms.TextBox address_TBX;
        private System.Windows.Forms.TextBox patronymic_TBX;
        private System.Windows.Forms.TextBox name_TBX;
        private System.Windows.Forms.TextBox surname_TBX;
    }
}