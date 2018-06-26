namespace WindowsFormsApp1
{
    partial class NewPart
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
            this.PartNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Manufacturer = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PartNum
            // 
            this.PartNum.Location = new System.Drawing.Point(115, 27);
            this.PartNum.Name = "PartNum";
            this.PartNum.Size = new System.Drawing.Size(130, 20);
            this.PartNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PartNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desc";
            // 
            // Desc
            // 
            this.Desc.Location = new System.Drawing.Point(115, 53);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(130, 20);
            this.Desc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(115, 79);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(130, 20);
            this.Price.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Manufacturer";
            // 
            // Manufacturer
            // 
            this.Manufacturer.Location = new System.Drawing.Point(115, 105);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(130, 20);
            this.Manufacturer.TabIndex = 6;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(115, 147);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // NewPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 182);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartNum);
            this.Name = "NewPart";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.NewPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PartNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Manufacturer;
        private System.Windows.Forms.Button btn_Save;
    }
}