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
    public partial class ProductInfo : Form
    {
        public ProductInfo()
        {
            InitializeComponent();
            ShowChart();
        }

        private void ShowChart()
        {
            //this.chart1.Series["This Week"].Points.AddXY("Icecream", 28);
            //this.chart1.Series["This Week"].Points.AddXY("Biscit", 56);
            //this.chart1.Series["This Week"].Points.AddXY("Bevrage", 30);
            //this.chart1.Series["This Week"].Points.AddXY("Chips", 65);
            //this.chart1.Series["This Week"].Points.AddXY("Caned Food", 15);

            //this.chart1.Series["Last Week"].Points.AddXY("Icecream", 20);
            //this.chart1.Series["Last Week"].Points.AddXY("Biscit", 42);
            //this.chart1.Series["Last Week"].Points.AddXY("Bevrage", 50);
            //this.chart1.Series["Last Week"].Points.AddXY("Chips", 85);
            //this.chart1.Series["Last Week"].Points.AddXY("Caned Food", 5);
        }

        private void ShowInventory()
        {
            var inventory = new Inventory();
            inventory.Show();
            this.Hide();
        }

        private void ShowPurches()
        {
            var purches = new Purches();
            purches.Show();
            this.Hide();
        }

        private void puerchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPurches();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }

        private void tOOLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory p = new Inventory();
            p.TopLevel = false;
            p.AutoScroll = true;
            p.FormBorderStyle = FormBorderStyle.None;
            p.Dock = DockStyle.Fill;

            this.panelDisplay.Controls.Clear();//Clear panelDisplay
            this.panelDisplay.Controls.Add(p);
            p.Show();
        }

        private void pURCHASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purches p = new Purches();
            p.TopLevel = false;
            p.AutoScroll = true;
            p.FormBorderStyle = FormBorderStyle.None;
            p.Dock = DockStyle.Fill;

            this.panelDisplay.Controls.Clear();//Clear panelDisplay
            this.panelDisplay.Controls.Add(p);
            p.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
