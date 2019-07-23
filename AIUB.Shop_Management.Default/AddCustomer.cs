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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = txtCustomerName.Text = txtCustomerContact.Text = txtCustomerAddress.Text = dateCustomerJoining.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(txtCustomerId.Text=="")
            {
                MessageBox.Show("ID Must be Filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtCustomerName.Text=="")
            {
                MessageBox.Show("Name Must be Filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtCustomerContact.Text == "")
            {
                MessageBox.Show("Contact Must be Filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtCustomerAddress.Text=="")
            {
                MessageBox.Show("Address Must be Filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Data Saved Successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCustomerId.Text = txtCustomerName.Text = txtCustomerContact.Text = txtCustomerAddress.Text = dateCustomerJoining.Text = "";
        }

        private void txtCustomerContact_TextChanged(object sender, EventArgs e)
        {
            txtCustomerId.Text = txtCustomerContact.Text;


        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            txtCustomerName.Focus();
        }
    }
}
