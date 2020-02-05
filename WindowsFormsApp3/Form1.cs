using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // getting the total amount from the subtotal text box
            decimal subtotal =
                Convert.ToDecimal(txtSubtotal.Text);
            //setting the discountpercent variable based on the value  of the subtotal variable
            decimal discountPercent = 0;
            if (subtotal >= 500)
            {
                discountPercent = .2m; //the m indicates a decimal value

            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPercent = .15m;
            }
            else if (subtotal >= 100 && subtotal < 250)
            {
                discountPercent = .1m;

            }
            // calculating and assigning the values for the discountamount and invoice total variables
            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            //formating the values and displaying them in their text boxes
            txtDiscountPercent.Text = discountPercent.ToString("p1"); // percent format 
            txtDiscountAmount.Text = discountAmount.ToString("c");  // with 1 decimal place 
            txtTotal.Text = invoiceTotal.ToString("c"); // for currency format

            txtSubtotal.Focus(); // moving focus to subtotal text box
        }
    }
}
