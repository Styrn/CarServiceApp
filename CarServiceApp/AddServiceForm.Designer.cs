namespace CarServiceApp
{
    partial class AddServiceForm
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
            this.warranty_NUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.workType_TBX = new System.Windows.Forms.TextBox();
            this.closeBut = new System.Windows.Forms.Button();
            this.acceptBut = new System.Windows.Forms.Button();
            this.cost_NUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.warranty_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // warranty_NUD
            // 
            this.warranty_NUD.Location = new System.Drawing.Point(12, 116);
            this.warranty_NUD.Name = "warranty_NUD";
            this.warranty_NUD.Size = new System.Drawing.Size(320, 22);
            this.warranty_NUD.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Гарантия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Вид работы";
            // 
            // workType_TBX
            // 
            this.workType_TBX.Location = new System.Drawing.Point(12, 28);
            this.workType_TBX.MaxLength = 100;
            this.workType_TBX.Name = "workType_TBX";
            this.workType_TBX.Size = new System.Drawing.Size(320, 22);
            this.workType_TBX.TabIndex = 14;
            // 
            // closeBut
            // 
            this.closeBut.Location = new System.Drawing.Point(170, 144);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(162, 23);
            this.closeBut.TabIndex = 13;
            this.closeBut.Text = "Отмена";
            this.closeBut.UseVisualStyleBackColor = true;
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
            // 
            // acceptBut
            // 
            this.acceptBut.Location = new System.Drawing.Point(12, 144);
            this.acceptBut.Name = "acceptBut";
            this.acceptBut.Size = new System.Drawing.Size(148, 23);
            this.acceptBut.TabIndex = 12;
            this.acceptBut.Text = "Добавить";
            this.acceptBut.UseVisualStyleBackColor = true;
            this.acceptBut.Click += new System.EventHandler(this.acceptBut_Click);
            // 
            // cost_NUD
            // 
            this.cost_NUD.Location = new System.Drawing.Point(12, 72);
            this.cost_NUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cost_NUD.Name = "cost_NUD";
            this.cost_NUD.Size = new System.Drawing.Size(320, 22);
            this.cost_NUD.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Стоимость";
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 178);
            this.Controls.Add(this.cost_NUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.warranty_NUD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workType_TBX);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.acceptBut);
            this.MaximumSize = new System.Drawing.Size(360, 225);
            this.MinimumSize = new System.Drawing.Size(360, 225);
            this.Name = "AddServiceForm";
            this.Text = "Добавить услугу";
            ((System.ComponentModel.ISupportInitialize)(this.warranty_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown warranty_NUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox workType_TBX;
        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.Button acceptBut;
        private System.Windows.Forms.NumericUpDown cost_NUD;
        private System.Windows.Forms.Label label2;
    }
}