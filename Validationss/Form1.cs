using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validationss
{
    public partial class Form1 : Form
    {
        public Form1(String user)
        {
            InitializeComponent();
           /* panelSelected.Height = btn_add.Height;
            panelSelected.Top = btn_add.Top;*/
            lbl_User_Name.Text = user;  
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            panIndicator.Top = btn_Cancel.Top;
            panIndicator.Height = btn_Cancel.Height;
            panIndicator.BackColor = Color.Orange;
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            panIndicator.Top = btn_Add.Top;
            panIndicator.Height = btn_Add.Height;
            panIndicator.BackColor = Color.Orange;


            Product p = new Product();
            do
            {
                if (!string.IsNullOrEmpty(txt_Number.Text) && 
                    !string.IsNullOrEmpty(txt_In.Text)&&
                    !string.IsNullOrEmpty(txt_ObjectName.Text) && 
                    !string.IsNullOrEmpty(txt_PhoneNo.Text) && 
                    !string.IsNullOrEmpty(txt_Count.Text) && 
                    !string.IsNullOrEmpty(txt_Price.Text))
                {
                    
                    p.Count = Convert.ToInt32(txt_Count.Text);
                    p.ObjectName = txt_ObjectName.Text;
                    p.Number =Convert.ToInt32( txt_Number.Text);
                    p.Date = dtp_datepicker1.Value;
                    p.price = Convert.ToInt32(txt_Price.Text);
                    p.InventoryNo = txt_In.Text;
                    p.available = checkBox1.Checked;
                   /* p.yes = checkedListBox1.CheckedItems;
                  
                    p.available= checkedListBox1.CheckedItems;*/
                    p.female = radioButton1.Checked;
                    p.male= radioButton2.Checked;
                    p.pay = radioButton3.Checked;
                    p.paypal = radioButton4.Checked;
                   

                    Regex r = new Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{3}$");
                    if (r.IsMatch(txt_PhoneNo.Text))
                    {
                        p.Phoneno = txt_PhoneNo.Text;
                    }
                    else
                    {
                        errorProvider1.SetError(txt_ObjectName, "Phone NUmber invalid format");
                    }
                    p.save();
                    dgvShowProducts.DataSource = null;
                    dgvShowProducts.DataSource = Product.getAllProduct();
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(txt_ObjectName, "Name is required!");
                    errorProvider1.SetError(txt_Count, " Count is required!");
                    MessageBox.Show("Can't insert null values. Try again please");
                }

            } while (txt_Count.Text == null || 
                    txt_ObjectName.Text == null ||
                    txt_Number.Text == null ||
                    dtp_datepicker1.Text == null || 
                    txt_Price.Text == null || 
                    txt_In.Text == null ||
                    txt_PhoneNo==null);


            String message = "";
            foreach(var item in checkedListBox1.CheckedItems)
                {

                item.ToString();
                message +=item.ToString();

            }
            MessageBox.Show(message);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            panIndicator.Top =  btn_search.Top;
            panIndicator.Height = btn_search.Height;
            panIndicator.BackColor = Color.Orange;


            Product p  = new Product();
            p = null;
            p = Product.findOneByName(txt_search.Text);
            if(p!=null)
            {
                lbl_search.Text = p.ObjectName;
            }
            else
            {
                lbl_search.Text = "Item not found";
            }
        }

        private void txt_PhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtp_datepicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_Count_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_In_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panIndicator_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
