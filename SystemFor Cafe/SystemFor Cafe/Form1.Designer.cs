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
            NumericQty = new NumericUpDown();
            radioCool = new RadioButton();
            radioHot = new RadioButton();
            ItemName = new Label();
            cboItem = new ComboBox();
            label1 = new Label();
            txtPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            TableList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            txtSubtotal = new Label();
            txtSub = new TextBox();
            label4 = new Label();
            txtPaid = new TextBox();
            label6 = new Label();
            radioDrink = new RadioButton();
            txtTotal = new TextBox();
            btnRemove = new Button();
            MyBoxImg = new PictureBox();
            btnEdit = new Button();
            btnDone = new Button();
            txt_Discount = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label7 = new Label();
            txtBalance = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NumericQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyBoxImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NumericQty
            // 
            NumericQty.Location = new Point(289, 284);
            NumericQty.Margin = new Padding(3, 4, 3, 4);
            NumericQty.Name = "NumericQty";
            NumericQty.Size = new Size(137, 27);
            NumericQty.TabIndex = 28;
            NumericQty.TextAlign = HorizontalAlignment.Center;
            NumericQty.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // radioCool
            // 
            radioCool.AutoSize = true;
            radioCool.BackColor = Color.Transparent;
            radioCool.FlatAppearance.BorderColor = Color.White;
            radioCool.FlatAppearance.CheckedBackColor = Color.White;
            radioCool.FlatAppearance.MouseDownBackColor = Color.White;
            radioCool.FlatAppearance.MouseOverBackColor = Color.White;
            radioCool.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioCool.ForeColor = Color.White;
            radioCool.Location = new Point(131, 97);
            radioCool.Name = "radioCool";
            radioCool.Size = new Size(81, 29);
            radioCool.TabIndex = 2;
            radioCool.Text = "COOL";
            radioCool.UseVisualStyleBackColor = false;
            radioCool.CheckedChanged += radioCool_CheckedChanged;
            // 
            // radioHot
            // 
            radioHot.AutoSize = true;
            radioHot.BackColor = Color.Transparent;
            radioHot.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioHot.ForeColor = Color.White;
            radioHot.Location = new Point(315, 97);
            radioHot.Name = "radioHot";
            radioHot.Size = new Size(71, 29);
            radioHot.TabIndex = 3;
            radioHot.Text = "HOT";
            radioHot.UseVisualStyleBackColor = false;
            radioHot.CheckedChanged += radioHot_CheckedChanged;
            // 
            // ItemName
            // 
            ItemName.AutoSize = true;
            ItemName.BackColor = Color.Transparent;
            ItemName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ItemName.ForeColor = Color.White;
            ItemName.Location = new Point(62, 176);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(106, 25);
            ItemName.TabIndex = 3;
            ItemName.Text = "ItemName:";
            // 
            // cboItem
            // 
            cboItem.FormattingEnabled = true;
            cboItem.Location = new Point(170, 176);
            cboItem.Name = "cboItem";
            cboItem.Size = new Size(434, 28);
            cboItem.TabIndex = 4;
            cboItem.Text = " ";
            cboItem.SelectedIndexChanged += cboItem_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(118, 259);
            label1.Name = "label1";
            label1.Size = new Size(49, 23);
            label1.TabIndex = 5;
            label1.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(58, 284);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(153, 27);
            txtPrice.TabIndex = 6;
            txtPrice.Text = "0";
            txtPrice.TextAlign = HorizontalAlignment.Center;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(330, 257);
            label2.Name = "label2";
            label2.Size = new Size(39, 23);
            label2.TabIndex = 7;
            label2.Text = "Qty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(534, 259);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 9;
            label3.Text = "Total";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Cyan;
            btnAdd.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(321, 339);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 33);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "ADD ITEM";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // TableList
            // 
            TableList.BackColor = Color.White;
            TableList.BorderStyle = BorderStyle.None;
            TableList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            TableList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TableList.ForeColor = Color.Black;
            TableList.Location = new Point(62, 377);
            TableList.Name = "TableList";
            TableList.Size = new Size(731, 220);
            TableList.TabIndex = 12;
            TableList.UseCompatibleStateImageBehavior = false;
            TableList.View = View.Details;
            TableList.SelectedIndexChanged += TableList_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Item Name";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Qty";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Price";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Total";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 170;
            // 
            // txtSubtotal
            // 
            txtSubtotal.AutoSize = true;
            txtSubtotal.BackColor = Color.Transparent;
            txtSubtotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubtotal.ForeColor = Color.White;
            txtSubtotal.Location = new Point(43, 605);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(70, 20);
            txtSubtotal.TabIndex = 13;
            txtSubtotal.Text = "SubTotal";
            // 
            // txtSub
            // 
            txtSub.Location = new Point(118, 603);
            txtSub.Name = "txtSub";
            txtSub.ReadOnly = true;
            txtSub.Size = new Size(125, 27);
            txtSub.TabIndex = 14;
            txtSub.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(296, 604);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 15;
            label4.Text = "Discount";
            // 
            // txtPaid
            // 
            txtPaid.ForeColor = Color.Red;
            txtPaid.Location = new Point(629, 603);
            txtPaid.Name = "txtPaid";
            txtPaid.ReadOnly = true;
            txtPaid.Size = new Size(164, 27);
            txtPaid.TabIndex = 20;
            txtPaid.Text = "0";
            txtPaid.TextChanged += txtPaid_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(566, 605);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 19;
            label6.Text = "Paid";
            // 
            // radioDrink
            // 
            radioDrink.AutoSize = true;
            radioDrink.BackColor = Color.Transparent;
            radioDrink.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioDrink.ForeColor = Color.White;
            radioDrink.Location = new Point(488, 97);
            radioDrink.Name = "radioDrink";
            radioDrink.Size = new Size(79, 29);
            radioDrink.TabIndex = 4;
            radioDrink.Text = "Drink";
            radioDrink.UseVisualStyleBackColor = false;
            radioDrink.CheckedChanged += Drink_CheckedChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(488, 283);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(140, 27);
            txtTotal.TabIndex = 26;
            txtTotal.Text = "0";
            txtTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Font = new Font("Segoe UI", 7.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.Location = new Point(528, 340);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(111, 33);
            btnRemove.TabIndex = 31;
            btnRemove.Text = "REMOVE ITEM";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Visible = false;
            btnRemove.Click += button1_Click;
            // 
            // MyBoxImg
            // 
            MyBoxImg.BackColor = Color.Transparent;
            MyBoxImg.ErrorImage = null;
            MyBoxImg.Location = new Point(635, 119);
            MyBoxImg.Name = "MyBoxImg";
            MyBoxImg.Size = new Size(159, 199);
            MyBoxImg.SizeMode = PictureBoxSizeMode.StretchImage;
            MyBoxImg.TabIndex = 32;
            MyBoxImg.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.SandyBrown;
            btnEdit.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(417, 340);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(104, 32);
            btnEdit.TabIndex = 33;
            btnEdit.Text = "EDIT ITEM";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.Lime;
            btnDone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDone.Location = new Point(645, 340);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(90, 32);
            btnDone.TabIndex = 36;
            btnDone.Text = "DONE";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Visible = false;
            btnDone.Click += btnDone_Click;
            // 
            // txt_Discount
            // 
            txt_Discount.Location = new Point(370, 603);
            txt_Discount.Name = "txt_Discount";
            txt_Discount.Size = new Size(138, 27);
            txt_Discount.TabIndex = 37;
            txt_Discount.Text = "0";
            txt_Discount.TextChanged += txt_Discount_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 49);
            panel1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(800, 415);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(805, 499);
            label5.Name = "label5";
            label5.Size = new Size(60, 28);
            label5.TabIndex = 40;
            label5.Text = "SAVE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(566, 639);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 41;
            label7.Text = "Balance";
            // 
            // txtBalance
            // 
            txtBalance.ForeColor = Color.Red;
            txtBalance.Location = new Point(630, 636);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(164, 27);
            txtBalance.TabIndex = 42;
            txtBalance.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1103, 668);
            Controls.Add(txtBalance);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(txt_Discount);
            Controls.Add(btnDone);
            Controls.Add(btnEdit);
            Controls.Add(MyBoxImg);
            Controls.Add(btnRemove);
            Controls.Add(NumericQty);
            Controls.Add(txtTotal);
            Controls.Add(radioDrink);
            Controls.Add(txtPaid);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtSub);
            Controls.Add(txtSubtotal);
            Controls.Add(TableList);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPrice);
            Controls.Add(label1);
            Controls.Add(cboItem);
            Controls.Add(ItemName);
            Controls.Add(radioHot);
            Controls.Add(radioCool);
            MaximumSize = new Size(1521, 715);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)NumericQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyBoxImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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