using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_4.model;

namespace Assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        product p = new product();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            p.Number = int.Parse( txtNumber.Text );
            p.Date = DtpDateofReg.Text;
            p.InvNum = int.Parse (txtInvNum.Text);
            p.ObjName = txtObjName.Text;
            p.Count = int.Parse(txtCount.Text);
            p.Price = double.Parse(txtPrice.Text);
            MessageBox.Show($" Product "+txtObjName.Text +"  Added");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = " ";
            DtpDateofReg.Value = DateTime.Now;
            txtInvNum.Text = " ";
            txtObjName.Text = " ";
            txtCount.Text = " ";
            txtPrice.Text = " ";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
