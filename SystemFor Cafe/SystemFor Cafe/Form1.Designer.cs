namespace SystemFor_Cafe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NumericQty = new System.Windows.Forms.NumericUpDown();
            this.radioCool = new System.Windows.Forms.RadioButton();
            this.radioHot = new System.Windows.Forms.RadioButton();
            this.ItemName = new System.Windows.Forms.Label();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.TableList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.txtSubtotal = new System.Windows.Forms.Label();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioDrink = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.MyBoxImg = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyBoxImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericQty
            // 
            this.NumericQty.Location = new System.Drawing.Point(289, 284);
            this.NumericQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericQty.Name = "NumericQty";
            this.NumericQty.Size = new System.Drawing.Size(137, 27);
            this.NumericQty.TabIndex = 28;
            this.NumericQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericQty.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // radioCool
            // 
            this.radioCool.AutoSize = true;
            this.radioCool.BackColor = System.Drawing.Color.Transparent;
            this.radioCool.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioCool.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioCool.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioCool.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.radioCool.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioCool.ForeColor = System.Drawing.Color.White;
            this.radioCool.Location = new System.Drawing.Point(131, 97);
            this.radioCool.Name = "radioCool";
            this.radioCool.Size = new System.Drawing.Size(81, 29);
            this.radioCool.TabIndex = 2;
            this.radioCool.Text = "COOL";
            this.radioCool.UseVisualStyleBackColor = false;
            this.radioCool.CheckedChanged += new System.EventHandler(this.radioCool_CheckedChanged);
            // 
            // radioHot
            // 
            this.radioHot.AutoSize = true;
            this.radioHot.BackColor = System.Drawing.Color.Transparent;
            this.radioHot.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioHot.ForeColor = System.Drawing.Color.White;
            this.radioHot.Location = new System.Drawing.Point(315, 97);
            this.radioHot.Name = "radioHot";
            this.radioHot.Size = new System.Drawing.Size(72, 29);
            this.radioHot.TabIndex = 3;
            this.radioHot.Text = "HOT";
            this.radioHot.UseVisualStyleBackColor = false;
            this.radioHot.CheckedChanged += new System.EventHandler(this.radioHot_CheckedChanged);
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.BackColor = System.Drawing.Color.Transparent;
            this.ItemName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemName.ForeColor = System.Drawing.Color.White;
            this.ItemName.Location = new System.Drawing.Point(62, 176);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(106, 25);
            this.ItemName.TabIndex = 3;
            this.ItemName.Text = "ItemName:";
            // 
            // cboItem
            // 
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(170, 176);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(434, 28);
            this.cboItem.TabIndex = 4;
            this.cboItem.Text = " ";
            this.cboItem.SelectedIndexChanged += new System.EventHandler(this.cboItem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(58, 284);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(153, 27);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(330, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(534, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Cyan;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(321, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD ITEM";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TableList
            // 
            this.TableList.BackColor = System.Drawing.Color.White;
            this.TableList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.TableList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TableList.ForeColor = System.Drawing.Color.Black;
            this.TableList.Location = new System.Drawing.Point(62, 377);
            this.TableList.Name = "TableList";
            this.TableList.Size = new System.Drawing.Size(731, 220);
            this.TableList.TabIndex = 12;
            this.TableList.UseCompatibleStateImageBehavior = false;
            this.TableList.View = System.Windows.Forms.View.Details;
            this.TableList.SelectedIndexChanged += new System.EventHandler(this.TableList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 170;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.AutoSize = true;
            this.txtSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSubtotal.ForeColor = System.Drawing.Color.White;
            this.txtSubtotal.Location = new System.Drawing.Point(43, 605);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(71, 20);
            this.txtSubtotal.TabIndex = 13;
            this.txtSubtotal.Text = "SubTotal";
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(118, 603);
            this.txtSub.Name = "txtSub";
            this.txtSub.ReadOnly = true;
            this.txtSub.Size = new System.Drawing.Size(125, 27);
            this.txtSub.TabIndex = 14;
            this.txtSub.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(296, 604);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Discount";
            // 
            // txtPaid
            // 
            this.txtPaid.ForeColor = System.Drawing.Color.Red;
            this.txtPaid.Location = new System.Drawing.Point(629, 603);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.ReadOnly = true;
            this.txtPaid.Size = new System.Drawing.Size(164, 27);
            this.txtPaid.TabIndex = 20;
            this.txtPaid.Text = "0";
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(566, 605);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Paid";
            // 
            // radioDrink
            // 
            this.radioDrink.AutoSize = true;
            this.radioDrink.BackColor = System.Drawing.Color.Transparent;
            this.radioDrink.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioDrink.ForeColor = System.Drawing.Color.White;
            this.radioDrink.Location = new System.Drawing.Point(488, 97);
            this.radioDrink.Name = "radioDrink";
            this.radioDrink.Size = new System.Drawing.Size(79, 29);
            this.radioDrink.TabIndex = 4;
            this.radioDrink.Text = "Drink";
            this.radioDrink.UseVisualStyleBackColor = false;
            this.radioDrink.CheckedChanged += new System.EventHandler(this.Drink_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(488, 283);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(140, 27);
            this.txtTotal.TabIndex = 26;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(528, 340);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 33);
            this.btnRemove.TabIndex = 31;
            this.btnRemove.Text = "REMOVE ITEM";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // MyBoxImg
            // 
            this.MyBoxImg.BackColor = System.Drawing.Color.Transparent;
            this.MyBoxImg.ErrorImage = null;
            this.MyBoxImg.Location = new System.Drawing.Point(635, 119);
            this.MyBoxImg.Name = "MyBoxImg";
            this.MyBoxImg.Size = new System.Drawing.Size(159, 199);
            this.MyBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyBoxImg.TabIndex = 32;
            this.MyBoxImg.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(417, 340);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 32);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "EDIT ITEM";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Lime;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDone.Location = new System.Drawing.Point(645, 340);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(90, 32);
            this.btnDone.TabIndex = 36;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txt_Discount
            // 
            this.txt_Discount.Location = new System.Drawing.Point(370, 603);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(138, 27);
            this.txt_Discount.TabIndex = 37;
            this.txt_Discount.Text = "0";
            this.txt_Discount.TextChanged += new System.EventHandler(this.txt_Discount_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 49);
            this.panel1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(800, 415);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(805, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 28);
            this.label5.TabIndex = 40;
            this.label5.Text = "SAVE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(566, 639);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.ForeColor = System.Drawing.Color.Red;
            this.txtBalance.Location = new System.Drawing.Point(630, 636);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(164, 27);
            this.txtBalance.TabIndex = 42;
            this.txtBalance.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1103, 668);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.MyBoxImg);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.NumericQty);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.radioDrink);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.TableList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboItem);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.radioHot);
            this.Controls.Add(this.radioCool);
            this.MaximumSize = new System.Drawing.Size(1521, 715);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyBoxImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton radioCool;
        private RadioButton radioHot;
        private Label ItemName;
        private ComboBox cboItem;
        private Label label1;
        private TextBox txtPrice;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private ListView TableList;
        private Label txtSubtotal;
        private TextBox txtSub;
        private Label label4;
        private TextBox txtPaid;
        private Label label6;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private RadioButton radioDrink;
        private TextBox txtTotal;
        private NumericUpDown NumericQty;
        private Button btnRemove;
        private PictureBox MyBoxImg;
        private Button btnEdit;
        private Button btnDone;
        private TextBox txt_Discount;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label7;
        private TextBox txtBalance;
    }
}