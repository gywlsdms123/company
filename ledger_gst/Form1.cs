using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ledger_gst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            Item im = new Item();
            im.Owner = this;
            im.Show();
        }

        private void btn_resigter_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Owner = this;
            reg.Show();
        }

        private void btn_Look_Click(object sender, EventArgs e)
        {
            LookUp lu = new LookUp();
            lu.Owner = this;
            lu.Show();
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            ItemTotal imt = new ItemTotal();
            imt.Owner = this;
            imt.Show();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
