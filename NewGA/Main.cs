using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGA
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //after click confirm, go to tabPage2
            tabControl1.SelectTab("tabPage2");
        }

        private void btnChickenRiceAdd_Click(object sender, EventArgs e)
        {
            //validation - check whether the user has enter quantity or not
            //if not, show this message
            if (txtChickenRiceQuantity.Text == "")
            {
                MessageBox.Show("Please enter quantity");
            }
            else
            {
                //if yes, calculate the total price of this food according to the quantity.
                double price = 7.50;
                double eachtotal = Convert.ToDouble(txtChickenRiceQuantity.Text) * price;
                string displayeachtotal = eachtotal.ToString("f2");
                ListViewItem order = new ListViewItem("Chicken Rice");
                order.SubItems.Add(txtChickenRiceQuantity.Text);
                order.SubItems.Add(displayeachtotal);
                listView1.Items.Add(order);
            }

            //calculate the total price of all the food
            double total = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }
            string displaytotal = total.ToString("f2");
            txtTPrice.Text = displaytotal;
            txtTPrice.Enabled = false;
        }

        private void btnMeeCurryAdd_Click(object sender, EventArgs e)
        {
            //validation - check whether the user has enter quantity or not
            //if not, show this message
            if (txtMeeCurryQuantity.Text == "")
            {
                MessageBox.Show("Please enter quantity");
            }
            else
            {
                //if yes, calculate the total price of this food according to the quantity.
                double price = 5.00;
                double eachtotal = Convert.ToDouble(txtMeeCurryQuantity.Text) * price;
                string displayeachtotal = eachtotal.ToString("f2");
                ListViewItem order = new ListViewItem("Mee Curry");
                order.SubItems.Add(txtMeeCurryQuantity.Text);
                order.SubItems.Add(displayeachtotal);
                listView1.Items.Add(order);
            }

            //calculate the total price of all the food
            double total = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }
            string displaytotal = total.ToString("f2");
            txtTPrice.Text = displaytotal;
            txtTPrice.Enabled = false;
        }

        private void btnRotiCanaiAdd_Click(object sender, EventArgs e)
        {
            //validation - check whether the user has enter quantity or not
            //if not, show this message
            if (txtRotiCanaiQuantity.Text == "")
            {
                MessageBox.Show("Please enter quantity");
            }
            else
            {
                //if yes, calculate the total price of this food according to the quantity.
                double price = 8.50;
                double eachtotal = Convert.ToDouble(txtRotiCanaiQuantity.Text) * price;
                string displayeachtotal = eachtotal.ToString("f2");
                ListViewItem order = new ListViewItem("Roti Canai");
                order.SubItems.Add(txtRotiCanaiQuantity.Text);
                order.SubItems.Add(displayeachtotal);
                listView1.Items.Add(order);
            }

            //calculate the total price of all the food
            double total = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }
            string displaytotal = total.ToString("f2");
            txtTPrice.Text = displaytotal;
            txtTPrice.Enabled = false;
        }

        private void btnNasiLemakAdd_Click(object sender, EventArgs e)
        {
            //validation - check whether the user has enter quantity or not
            //if not, show this message
            if (txtNasiLemakQuantity.Text == "")
            {
                MessageBox.Show("Please enter quantity");
            }
            else
            {
                //if yes, calculate the total price of this food according to the quantity.
                double price = 6.00;
                double eachtotal = Convert.ToDouble(txtNasiLemakQuantity.Text) * price;
                string displayeachtotal = eachtotal.ToString("f2");
                ListViewItem order = new ListViewItem("Nasi Lemak");
                order.SubItems.Add(txtNasiLemakQuantity.Text);
                order.SubItems.Add(displayeachtotal);
                listView1.Items.Add(order);
            }

            //calculate the total price of all the food
            double total = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }
            string displaytotal = total.ToString("f2");
            txtTPrice.Text = displaytotal;
            txtTPrice.Enabled = false;
        }

        private void btnLaksaAdd_Click(object sender, EventArgs e)
        {
            //validation - check whether the user has enter quantity or not
            //if not, show this message
            if (txtLaksaQuantity.Text == "")
            {
                MessageBox.Show("Please enter quantity");
            }
            else
            {
                //if yes, calculate the total price of this food according to the quantity.
                double price = 4.00;
                double eachtotal = Convert.ToDouble(txtLaksaQuantity.Text) * price;
                string displayeachtotal = eachtotal.ToString("f2");
                ListViewItem order = new ListViewItem("Laksa");
                order.SubItems.Add(txtLaksaQuantity.Text);
                order.SubItems.Add(displayeachtotal);
                listView1.Items.Add(order);
            }

            //calculate the total price of all the food
            double total = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }
            string displaytotal = total.ToString("f2");
            txtTPrice.Text = displaytotal;
            txtTPrice.Enabled = false;
        }

        private void btnMeeGorengAdd_Click(object sender, EventArgs e)
        {
            //validation - check whether the user has enter quantity or not
            //if not, show this message
            if (txtMeeGorengQuantity.Text == "")
            {
                MessageBox.Show("Please enter quantity");
            }
            else
            {
                //if yes, calculate the total price of this food according to the quantity.
                double price = 4.50;
                double eachtotal = Convert.ToDouble(txtMeeGorengQuantity.Text) * price;
                string displayeachtotal = eachtotal.ToString("f2");
                ListViewItem order = new ListViewItem("Mee Goreng");
                order.SubItems.Add(txtMeeGorengQuantity.Text);
                order.SubItems.Add(displayeachtotal);
                listView1.Items.Add(order);
            }

            //calculate the total price of all the food
            double total = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }
            string displaytotal = total.ToString("f2");
            txtTPrice.Text = displaytotal;
            txtTPrice.Enabled = false;

        }



        private void btnProceed_Click(object sender, EventArgs e)
        {
            //after click proceed, go to tabPage3
            //before the user select the payment method, he or she is not allow to type anything at others textbox.
            tabControl1.SelectTab("tabPage3");
            txtAmount.Text = txtTPrice.Text;
            txtAmount.Enabled = false;
            txtCardNo.Enabled = false;
            txtPay.Enabled = false;
            txtChange.Enabled = false;
            cbPaymentMethod.Enabled = true;

            //if user already select payment method, then the users can enter pay or credit card number
            if (cbPaymentMethod.Text == "Cash")
            {
                txtCardNo.Enabled = false;
                txtAmount.Enabled = false;
                txtChange.Enabled = false;
                txtPay.Enabled = true;
            }
            else
            if (cbPaymentMethod.Text == "Credit Card")
            {
                //else, the user only allow to input the card number
                txtCardNo.Enabled = true;
                txtChange.Enabled = false;
                txtAmount.Enabled = false;
                txtPay.Enabled = false;
                txtPay.Text = txtTPrice.Text;
            }

        }

        private void cbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if user select cash, the user only allow to input the pay amount
            if (cbPaymentMethod.Text == "Cash")
            {
                txtCardNo.Enabled = false;
                txtAmount.Enabled = false;
                txtChange.Enabled = false;
                txtPay.Enabled = true;
            }
            else
            {
                //else, the user only allow to input the card number
                txtCardNo.Enabled = true;
                txtChange.Enabled = false;
                txtAmount.Enabled = false;
                txtPay.Enabled = false;
                txtPay.Text = txtTPrice.Text;
            }
        }

        

        private void txtCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validation - the user only allow to type integer at the card number textbox.
            //And i have set the max length of the card number become 16 at properties there
            //so user only allow to input 16 integers at the card number textbox.
            char num = e.KeyChar;
            if (!char.IsDigit(num))
            {
                e.Handled = true;
                MessageBox.Show("Please enter number only.");
            }
            

        }

        private void txtPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validation - the user only allow to type integer at the pay textbox.
            char num = e.KeyChar;
            if (!char.IsDigit(num))
            {
                e.Handled = true;
                MessageBox.Show("Please enter number only.");
            }
        }

        private void btnCalChange_Click(object sender, EventArgs e)
        {
            bool t = false;
            //validation - if user do not enter payment method and straight click pay, display this message
            if (cbPaymentMethod.Text == "")
            {
                MessageBox.Show("Please enter payment method !");
                t = true;

            }
            
            
            if (t == false)
            {
                //validation - if user do not enter pay after select the payment method
                bool k = true;
                if (txtPay.Text == "")
                {
                    MessageBox.Show("Please enter pay!");
                    k = true;
                }
                else
                if (txtCardNo.Text == "")
                {
                    MessageBox.Show("Please enter card number!");
                    k = true;
                }

                if (k == false)
                {
                    //calculate the change after the user enter pay
                    double amount, pay, change;
                    amount = Convert.ToDouble(txtAmount.Text);
                    pay = Convert.ToDouble(txtPay.Text);
                    change = pay - amount;
                    string displaychange = change.ToString();


                    //if user pay not enough money, display this message
                    if (pay < amount)
                    {
                        MessageBox.Show("Not enough money.");
                        txtChange.Text = displaychange;
                        txtChange.Enabled = false;
                    }
                    else
                    {
                        //else, show this message
                        txtChange.Text = displaychange;
                        txtChange.Enabled = false;
                        MessageBox.Show("Pay successfully!");
                    }
                }
            }

            

            
        }

        private void btnRemoveSelectedFood_Click(object sender, EventArgs e)
        {
            //remove the selected row at the list view once the user press remove button
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                    i--;

                    //recalculate the total price of all the food
                    double total = 0;
                    foreach (ListViewItem item in listView1.Items)
                    {
                        total += Convert.ToDouble(item.SubItems[2].Text);
                    }
                    string displaytotal = total.ToString("f2");
                    txtTPrice.Text = displaytotal;
                    txtTPrice.Enabled = false;
                }
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            //clear all the rows in the list view once the user press clear button
            listView1.Items.Clear();

            //recalculate the total price of all the food
            double total = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }
            string displaytotal = total.ToString("f2");
            txtTPrice.Text = displaytotal;
            txtTPrice.Enabled = false;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //if user do not add any food in the list view, he or she cannot write anything in the textbox.
            txtAmount.Text = txtTPrice.Text;
            txtAmount.Enabled = false;
            txtCardNo.Enabled = false;
            txtPay.Enabled = false;
            txtChange.Enabled = false;
            cbPaymentMethod.Enabled = false;
        }

        

        

        private void txtMeeGorengQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validation - only allow user to enter integer at the quantity textbox.
            char num = e.KeyChar;
            if (!char.IsDigit(num))
            {
                e.Handled = true;
                MessageBox.Show("Please enter number only.");
            }

        }

        private void txtChickenRiceQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validation - only allow user to enter integer at the quantity textbox.
            char num = e.KeyChar;
            if (!char.IsDigit(num))
            {
                e.Handled = true;
                MessageBox.Show("Please enter number only.");
            }
        }

        private void txtMeeCurryQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validation - only allow user to enter integer at the quantity textbox.
            char num = e.KeyChar;
            if (!char.IsDigit(num))
            {
                e.Handled = true;
                MessageBox.Show("Please enter number only.");
            }
        }

        private void txtRotiCanaiQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validation - only allow user to enter integer at the quantity textbox.
            char num = e.KeyChar;
            if (!char.IsDigit(num))
            {
                e.Handled = true;
                MessageBox.Show("Please enter number only.");
            }
        }

        private void txtNasiLemakQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validation - only allow user to enter integer at the quantity textbox.
            char num = e.KeyChar;
            if (!char.IsDigit(num))
            {
                e.Handled = true;
                MessageBox.Show("Please enter number only.");
            }
        }

        private void txtLaksaQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validation - only allow user to enter integer at the quantity textbox.
            char num = e.KeyChar;
            if (!char.IsDigit(num))
            {
                e.Handled = true;
                MessageBox.Show("Please enter number only.");
            }
        }

        
    }
}
