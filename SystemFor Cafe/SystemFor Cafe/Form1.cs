using System.Diagnostics;
using System.Drawing;
using System;
using System.Data;
using System.Drawing.Imaging;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
//using MongoDB.Driver;

namespace SystemFor_Cafe
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TableList.Enabled = false;
            //  btnRemove.Enabled = false;
            cboItem.Text = "";
            // NumericQty.ResetText();
            btnAdd.Visible = false;

            //radio false visible
            radioDrink.Checked = false;
            radioHot.Checked = false;
            radioCool.Checked = false;

            //  txtPaid.Text = (Convert.ToInt16(txtSub.Text) + Convert.ToInt16(txtSub.Text)).ToString();
        }

        //Radio Cool
        private void radioCool_CheckedChanged(object sender, EventArgs e)
        {

            radioCool.ForeColor = System.Drawing.Color.Aqua;
            radioDrink.ForeColor = System.Drawing.Color.White;
            radioHot.ForeColor = System.Drawing.Color.White;
            //Add Item In Cbo Box Select Item
            cboItem.Text = "Select Cool Item";
            cboItem.Items.Clear();
            cboItem.Items.Add("Ice Latte");
            cboItem.Items.Add("Milk Tea");
            cboItem.Items.Add("Passion Milk");
            cboItem.Items.Add("Black Coffee Ice");
            cboItem.Items.Add("Green Tea (ice)");
        }
        //Radio Hot
        private void radioHot_CheckedChanged(object sender, EventArgs e)
        {
            radioHot.ForeColor = System.Drawing.Color.Red;
            radioDrink.ForeColor = System.Drawing.Color.White;
            radioCool.ForeColor = System.Drawing.Color.White;
            //Add Item In Cbo Box Select Item
            cboItem.Text = "Select Hot Item";
            cboItem.Items.Clear();
            cboItem.Items.Add("Hot Latte");
            cboItem.Items.Add("Mocha");
            cboItem.Items.Add("Espresso");
            cboItem.Items.Add("Cappuccino");

        }
        //Radio Drink
        private void Drink_CheckedChanged(object sender, EventArgs e)
        {
            radioDrink.ForeColor = System.Drawing.Color.Orange;
            radioCool.ForeColor = System.Drawing.Color.White;
            radioHot.ForeColor = System.Drawing.Color.White;
            //Add Item In Cbo Box select Item 
            cboItem.Text = "Select Drink item";
            cboItem.Items.Clear();
            cboItem.Items.Add("Coca");
            cboItem.Items.Add("Sting");
            cboItem.Items.Add("Boostrong");
            cboItem.Items.Add("PEPSI");

        }

        //Select on Name In Item To show Price in Price Box
        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            //visible item 
            MyBoxImg.Visible = true;
            //Ice Item
            if (cboItem.SelectedItem.ToString() == "Ice Latte")
            {
                MyBoxImg.Image = System.Drawing.Image.FromFile(@"D:\Assigment Y4\C#\NewCafeSystem\img\icelatte.jpg");
                txtPrice.Text = "4000";
                txtTotal.Text = (Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(NumericQty.Value)).ToString();

            }
            else if (cboItem.SelectedItem.ToString() == "Milk Tea")
            {
                MyBoxImg.Image = System.Drawing.Image.FromFile(@"D:\Assigment Y4\C#\NewCafeSystem\img\milktea.jpg");
                txtPrice.Text = "5000";
                txtTotal.Text = (Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(NumericQty.Value)).ToString();
            }
            else if (cboItem.SelectedItem.ToString() == "Passion Milk")
            {

                MyBoxImg.Image = System.Drawing.Image.FromFile(@"D:\Assigment Y4\C#\NewCafeSystem\img\passion.jpg");
                txtPrice.Text = "3800";
                txtTotal.Text = (Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(NumericQty.Value)).ToString();
            }
            else if (cboItem.SelectedItem.ToString() == "Black Coffee Ice")
            {

                MyBoxImg.Image = System.Drawing.Image.FromFile(@"D:\Assigment Y4\C#\NewCafeSystem\img\blackcoffee.jpeg");
                txtPrice.Text = "7000";
                txtTotal.Text = (Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(NumericQty.Value)).ToString();
            }
            else if (cboItem.SelectedItem.ToString() == "Green Tea (ice)")
            {
                MyBoxImg.Image = System.Drawing.Image.FromFile(@"D:\Assigment Y4\C#\NewCafeSystem\img\greentea.jpg");
                txtPrice.Text = "6000";
                txtTotal.Text = (Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(NumericQty.Value)).ToString();
            }

            //Hot Item 
            else if (cboItem.SelectedItem.ToString() == "Hot Latte")
            {
                MyBoxImg.Image = System.Drawing.Image.FromFile(@"D:\Assigment Y4\C#\NewCafeSystem\img\hotlatte.jpg");
                txtPrice.Text = " 5000";
                txtTotal.Text = (Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(NumericQty.Value)).ToString();
            }
            else if (cboItem.SelectedItem.ToString() == "Mocha")
            {
                MyBoxImg.Image = System.Drawing.Image.FromFile(@"D:\Assigment Y4\C#\NewCafeSystem\img\mocha.jpg");
                txtPrice.Text = "4000";
                txtTotal.Text = (Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(NumericQty.Value)).ToString();
            }
            else if (cboItem.SelectedItem.ToString() == "Espresso")
            {
                MyBoxImg.Image = System.Drawing.Image.FromFile(@"D:\Assigment Y4\C#\NewCafeSystem\img\espresso.jpg");
                txtPrice.Text = "3500";
                txtTotal.Text = (Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(NumericQty.Value)).ToString();
            }
            else if (cboItem.SelectedItem.ToString() == "Cappuccino")
            {
                MyBoxImg.Image = System.Drawing.Image.FromFile(@"D:\Assigment Y4\C#\NewCafeSystem\img\cappuccino.jpg");
                txtPrice.Text = "5000";
                txtTotal.Text = (Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(NumericQty.Value)).ToString();
            }
            //Drink
            else if (cboItem.SelectedItem.ToString() == "Coca")
            {
                MyBoxImg.Image = System.Drawing.Image.FromFile(@"D:\Assigment Y4\C#\NewCafeSystem\img\cocacola.png");
                txtPrice.Text = "4000";
                txtTotal.Text = (Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(NumericQty.Value)).ToString();
            }
            else if (cboItem.SelectedItem.ToString() == "Sting")
            {
                MyBoxImg.Image = System.Drawing.Image.FromFile(@"D:\Assigment Y4\C#\NewCafeSystem\img\sting.png");
                txtPrice.Text = "2700";
                txtTotal.Text = (Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(NumericQty.Value)).ToString();
            }
            else if (cboItem.SelectedItem.ToString() == "Boostrong")
            {
                MyBoxImg.Image = System.Drawing.Image.FromFile(@"D:\Assigment Y4\C#\NewCafeSystem\img\boostrong.png");
                txtPrice.Text = "2500";
                txtTotal.Text = (Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(NumericQty.Value)).ToString();
            }
            else if (cboItem.SelectedItem.ToString() == "PEPSI")
            {
                MyBoxImg.Image = System.Drawing.Image.FromFile(@"D:\Assigment Y4\C#\NewCafeSystem\img\pepsi.png");
                txtPrice.Text = "5000";
                txtTotal.Text = (Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(NumericQty.Value)).ToString();
            }


        }

        //Input Value into textBox PRice to    =>   QTY * Price = Total
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (NumericQty.Text.Length > -1)
            {

                txtTotal.Text = (Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(NumericQty.Value)).ToString();

                //  txtTotal.Text = (Convert.ToInt32(txtPrice.Text) * Convert.ToInt32((NumericQty.Value)).ToString();
            }
        }

        //Click To Clear


        //Click Btn Add to table
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Item To Table use string
            string[] arr = new string[4];
            ListViewItem itm;
            arr[0] = cboItem.SelectedItem.ToString();
            arr[1] = NumericQty.Value.ToString();
            arr[2] = txtPrice.Text.ToString();
            arr[3] = txtTotal.Text.ToString();
            itm = new ListViewItem(arr);
            TableList.Items.Add(itm);

            txtSub.Text = (Convert.ToInt16(txtSub.Text) + Convert.ToInt16(txtTotal.Text)).ToString();
            txtPaid.Text = (Convert.ToInt16(txtSub.Text) - Convert.ToInt16(txtPaid.Text)).ToString();
            txtPaid.Text = (Convert.ToInt16(txtSub.Text) - Convert.ToInt16(txt_Discount.Text)).ToString();
            // txtBalance.Text = (Convert.ToInt16(txtSub.Text) + Convert.ToInt16(txtBalance.Text)).ToString();


            //show  and hide button
            btnEdit.Visible = true;
            //btnClear.Visible = false;
            //clear item 
            cboItem.Text = "";
            radioDrink.Checked = false;
            radioHot.Checked = false;
            radioCool.Checked = false;
            txtPrice.Text = "0";
            NumericQty.Value = 0;
            //  NumericQty.ResetText();
            txtTotal.Text = "0";
            radioCool.ForeColor = System.Drawing.Color.Black;
            radioDrink.ForeColor = System.Drawing.Color.Black;
            radioHot.ForeColor = System.Drawing.Color.Black;

            MyBoxImg.Visible = false;
        }

        //Value 
        private void txt_Discount_TextChanged(object sender, EventArgs e)
        {

            if (txt_Discount.Text.Length > 0)
            {
                txtPaid.Text = (Convert.ToInt16(txtSub.Text) - Convert.ToInt16(txt_Discount.Text)).ToString();
                txtBalance.Text = (Convert.ToInt16(txtPaid.Text)).ToString();
            }

        }
        //Click On Btn Remove To Clear ItemSelected And Item in table list

        private void button1_Click(object sender, EventArgs e)
        {
            if (TableList.SelectedItems.Count > 0)
            {

                for (int i = 0; i < TableList.Items.Count; i++)
                {

                    if (TableList.Items[i].Selected)
                    {
                        btnRemove.Visible = true;
                        txtSub.Text = (Convert.ToInt16(txtSub.Text) - Convert.ToInt16(TableList.Items[i].SubItems[3].Text)).ToString();
                        txtPaid.Text = (Convert.ToInt16(txtSub.Text) - Convert.ToInt16(txt_Discount.Text)).ToString();
                        TableList.Items[i].Remove();
                    }

                }
            }
            // Clear Item Select
            cboItem.ResetText();
            radioDrink.Checked = false;
            radioHot.Checked = false;
            radioCool.Checked = false;
            txtPrice.ResetText();
            NumericQty.ResetText();
            txtTotal.ResetText();
            radioCool.ForeColor = System.Drawing.Color.Black;
            radioDrink.ForeColor = System.Drawing.Color.Black;
            radioHot.ForeColor = System.Drawing.Color.Black;

        }



        //Button Click Done
        private void btnDone_Click(object sender, EventArgs e)
        {

            btnRemove.Visible = false;
            btnDone.Visible = false;
            btnEdit.Visible = true;
            TableList.Enabled = false;

        }

        //Click To edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            TableList.Enabled = true;
            btnRemove.Visible = true;
            btnDone.Visible = true;
            btnEdit.Visible = false;
        }

        //SAVE
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            /* if (TableList.Items.Count > 0)
             {
                 try
                 {
                     string ConnectionString = "Integrated Security=SSPI; Persist Security Info=False; Initail Catalog=AB_Inventory_DB; Data Source=DESKTOP - 5TIR4HE\\SQLEXPRESS";
                     SqlConnection connection = new SqlConnection(ConnectionString);
                     SqlCommand command = new SqlCommand();

                     connection.Open();
                     command.CommandText = "Insert into tbl_master (InvoiceDate, Sub_Total, Discount, Paid_Total, Balance) value " +
                                 "(getdate() , " + txtSub.Text + "," + txt_Discount.Text + " , " + txtPaid.Text + "," + txtBalance.Text + ") select scope_identity() ";
                     string InvoiceID = command.ExecuteScalar().ToString();


                     foreach (ListViewItem ListItem in TableList.Items)
                     {
                         command.CommandText = "Insert into tbl_Invoice1 (Master_ID, ItemName, Price, Qty, Total) values " +
                         " ( '" + InvoiceID + "' , '" + ListItem.SubItems[0].Text + "', '" + ListItem.SubItems[1].Text + "', '" + ListItem.SubItems[2].Text + "' , '" + ListItem.SubItems[3].Text + ")";

                         command.ExecuteNonQuery();
                     }
                     connection.Close();
                     MessageBox.Show("Sale Created Successfully, with Invoice # " + InvoiceID);

                 }
                 catch (Exception ee)
                 {
                     MessageBox.Show("Sale not Created, Error!");
                 }
             }
             else
             {
                 MessageBox.Show("Must Add an Item in the List");
             }*/
        }





















        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void photoBox(object sender, EventArgs e)
        {

        }


        private void TableList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {

        }

    }
}