using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_DBFirst
{
    public partial class Form1 : Form
    {
        NorthwindEntities db = new NorthwindEntities();
        public Form1()
        {
            InitializeComponent();
            List<Customer> cs=db.Customers.ToList();
            dgwCustomer.DataSource = cs.OrderBy(s=>s.ContactName).ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            List<Customer> customers = db.Customers.Where(a => a.ContactName.Contains(txtName.Text)).ToList();

            if (customers.Count==0)
            {
                MessageBox.Show("Aradığınız kriterde müşteri bulunamamıştır.");
                return;
            }
            dgwCustomer.DataSource=customers;
        }
    }
}
