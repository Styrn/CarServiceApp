﻿namespace CarServiceApp
{
    partial class EditMasterForm
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
            this.experience_NUD = new System.Windows.Forms.NumericUpDown();
            this.position_TBX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patronymic_TBX = new System.Windows.Forms.TextBox();
            this.name_TBX = new System.Windows.Forms.TextBox();
            this.surname_TBX = new System.Windows.Forms.TextBox();
            this.closeBut = new System.Windows.Forms.Button();
            this.acceptBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.experience_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // experience_NUD
            // 
            this.experience_NUD.Location = new System.Drawing.Point(15, 204);
            this.experience_NUD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.experience_NUD.Name = "experience_NUD";
            this.experience_NUD.Size = new System.Drawing.Size(316, 22);
            this.experience_NUD.TabIndex = 22;
            // 
            // position_TBX
            // 
            this.position_TBX.Location = new System.Drawing.Point(15, 160);
            this.position_TBX.Name = "position_TBX";
            this.position_TBX.Size = new System.Drawing.Size(316, 22);
            this.position_TBX.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Стаж";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Отчество (при наличии)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Фамилия";
            // 
            // patronymic_TBX
            // 
            this.patronymic_TBX.Location = new System.Drawing.Point(15, 116);
            this.patronymic_TBX.Name = "patronymic_TBX";
            this.patronymic_TBX.Size = new System.Drawing.Size(316, 22);
            this.patronymic_TBX.TabIndex = 16;
            // 
            // name_TBX
            // 
            this.name_TBX.Location = new System.Drawing.Point(15, 72);
            this.name_TBX.Name = "name_TBX";
            this.name_TBX.Size = new System.Drawing.Size(316, 22);
            this.name_TBX.TabIndex = 15;
            // 
            // surname_TBX
            // 
            this.surname_TBX.Location = new System.Drawing.Point(15, 28);
            this.surname_TBX.Name = "surname_TBX";
            this.surname_TBX.Size = new System.Drawing.Size(316, 22);
            this.surname_TBX.TabIndex = 14;
            // 
            // closeBut
            // 
            this.closeBut.Location = new System.Drawing.Point(169, 232);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(162, 23);
            this.closeBut.TabIndex = 13;
            this.closeBut.Text = "Отмена";
            this.closeBut.UseVisualStyleBackColor = true;
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
            // 
            // acceptBut
            // 
            this.acceptBut.Location = new System.Drawing.Point(15, 232);
            this.acceptBut.Name = "acceptBut";
            this.acceptBut.Size = new System.Drawing.Size(148, 23);
            this.acceptBut.TabIndex = 12;
            this.acceptBut.Text = "Применить";
            this.acceptBut.UseVisualStyleBackColor = true;
            this.acceptBut.Click += new System.EventHandler(this.acceptBut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Должность";
            // 
            // EditMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 264);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.experience_NUD);
            this.Controls.Add(this.position_TBX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patronymic_TBX);
            this.Controls.Add(this.name_TBX);
            this.Controls.Add(this.surname_TBX);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.acceptBut);
            this.MaximumSize = new System.Drawing.Size(360, 311);
            this.MinimumSize = new System.Drawing.Size(360, 311);
            this.Name = "EditMasterForm";
            this.Text = "Изменение мастера";
            ((System.ComponentModel.ISupportInitialize)(this.experience_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown experience_NUD;
        private System.Windows.Forms.TextBox position_TBX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patronymic_TBX;
        private System.Windows.Forms.TextBox name_TBX;
        private System.Windows.Forms.TextBox surname_TBX;
        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.Button acceptBut;
        private System.Windows.Forms.Label label4;
    }
}