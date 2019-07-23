using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIUB.Shop_Management.Default
{
    public partial class BillingSystem : Form
    {
        public BillingSystem()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        double totalCost = 0;
        double amount;

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {


            if (txtProductId.Text == "1010")
            {
                txtPName.Text = "Mutton";
                txtUnit.Text = "Kg";
                //txtUnitPrice.Text = "520";
                int price = Convert.ToInt32(txtUnitPrice.Text = "520");
            }
            else if (txtProductId.Text == "1011")
            {
                txtPName.Text = "Fish";
                txtUnit.Text = "Kg";
                //txtUnitPrice.Text = "150";
                int price = Convert.ToInt32(txtUnitPrice.Text = "150");
            }
            else if (txtProductId.Text == "FshRoi1011")
            {
                txtPName.Text = "Fish_Roi";
                txtUnit.Text = "Kg";
                int price = Convert.ToInt32(txtUnitPrice.Text = "220");
            }
            else if (txtProductId.Text == " ")
            {
                txtPName.Text = "";
                txtUnit.Text = "";
                txtUnitPrice.Text = "";
            }
        }

        private void txtQuentity_TextChanged(object sender, EventArgs e)
        {

            try
            {
                double qnty = Convert.ToDouble(txtQuentity.Text);

                double price = Convert.ToDouble(txtUnitPrice.Text);

                //Calculate Amount in a Product
                amount = qnty * price;
                txtAmount.Text = Convert.ToString(amount);
                totalCost = double.Parse(txtTotal.Text);
                totalCost = totalCost + amount;




            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error : "+ex,"Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }



        private void ItemTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Item In Data Table
            addData(txtProductId.Text, txtPName.Text, txtUnitPrice.Text, txtQuentity.Text, txtUnit.Text, txtAmount.Text);

            MessageBox.Show("Congratulations", "Item Added Done !", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


            //Clear All TextBox regarding Product Info
            txtTotal.Text = totalCost.ToString();

            txtProductId.Text = "";
            txtPName.Text = "";
            txtUnit.Text = "";
            txtUnitPrice.Text = "";
            txtQuentity.Text = "";
            txtAmount.Text = "";



        }

        private void addData(string id, string name, string unitprice, string quentity, string unit, string amount)
        {
            String[] row = { id, name, unitprice, quentity, unit, amount };
            ItemTable.Rows.Add(row);


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

            //Discount 
            double discount = double.Parse(txtDiscount.Text);
            discount = ((100 - discount) / 100 * totalCost);
            txtNetAmount.Text = discount.ToString();

            //Savings Amount
            double t = double.Parse(txtTotal.Text);
            double na = double.Parse(txtNetAmount.Text);
            double savings = t - na;
            txtSavings.Text = savings.ToString();


        }

        private void txtSavings_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGivenAmount_TextChanged(object sender, EventArgs e)
        {
            double given = double.Parse(txtGivenAmount.Text);
            double na = double.Parse(txtNetAmount.Text);
            double returnamount = given - na;
            txtReturn.Text = returnamount.ToString();
            txtGivenAmount.Text = given.ToString();
        }


        //Clear Function

        private void Init()
        {
            Close();
        }

        //Cancel Transaction
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Cancel the whole Transaction ?", "Confarmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Init();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Printing is under Construction", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Init();
            }
        }
    }
}
