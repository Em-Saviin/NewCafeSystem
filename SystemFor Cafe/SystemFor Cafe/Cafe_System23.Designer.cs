namespace SystemFor_Cafe
{
    partial class Cafe_System23
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioDrink = new System.Windows.Forms.RadioButton();
            this.radioHot = new System.Windows.Forms.RadioButton();
            this.radioCool = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.radioDrink);
            this.panel1.Controls.Add(this.radioHot);
            this.panel1.Controls.Add(this.radioCool);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 751);
            this.panel1.TabIndex = 0;
            // 
            // radioDrink
            // 
            this.radioDrink.AutoSize = true;
            this.radioDrink.BackColor = System.Drawing.Color.Transparent;
            this.radioDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioDrink.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioDrink.ForeColor = System.Drawing.Color.White;
            this.radioDrink.Location = new System.Drawing.Point(0, 0);
            this.radioDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioDrink.Name = "radioDrink";
            this.radioDrink.Size = new System.Drawing.Size(880, 751);
            this.radioDrink.TabIndex = 7;
            this.radioDrink.TabStop = true;
            this.radioDrink.Text = "Drink";
            this.radioDrink.UseVisualStyleBackColor = false;
            // 
            // radioHot
            // 
            this.radioHot.AutoSize = true;
            this.radioHot.BackColor = System.Drawing.Color.Transparent;
            this.radioHot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioHot.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioHot.ForeColor = System.Drawing.Color.White;
            this.radioHot.Location = new System.Drawing.Point(0, 0);
            this.radioHot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioHot.Name = "radioHot";
            this.radioHot.Size = new System.Drawing.Size(880, 751);
            this.radioHot.TabIndex = 6;
            this.radioHot.TabStop = true;
            this.radioHot.Text = "HOT";
            this.radioHot.UseVisualStyleBackColor = false;
            // 
            // radioCool
            // 
            this.radioCool.AutoSize = true;
            this.radioCool.BackColor = System.Drawing.Color.Transparent;
            this.radioCool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioCool.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioCool.ForeColor = System.Drawing.Color.White;
            this.radioCool.Location = new System.Drawing.Point(0, 0);
            this.radioCool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioCool.Name = "radioCool";
            this.radioCool.Size = new System.Drawing.Size(880, 751);
            this.radioCool.TabIndex = 5;
            this.radioCool.TabStop = true;
            this.radioCool.Text = "COOL";
            this.radioCool.UseVisualStyleBackColor = false;
            // 
            // Cafe_System23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 751);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cafe_System23";
            this.Text = "Cafe_System23";
            this.Load += new System.EventHandler(this.Cafe_System23_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private RadioButton radioDrink;
        private RadioButton radioHot;
        private RadioButton radioCool;
    }
}