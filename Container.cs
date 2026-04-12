using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniPOS
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();

            Dashboard frmDashboard = new Dashboard();
            frmDashboard.MdiParent = this;
            frmDashboard.Dock = DockStyle.Fill;
            frmDashboard.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Panel principal · Usuario: ";

            Dashboard frmDashboard = new Dashboard();
            frmDashboard.MdiParent = this;
            frmDashboard.Dock = DockStyle.Fill;
            frmDashboard.Show();

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "MiniPOS — Gestión de productos";

            Products frmProducts = new Products();
            frmProducts.MdiParent = this;
            frmProducts.Dock = DockStyle.Fill;
            frmProducts.Show();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "MiniPOS — Gestión de categorías";

            Categories frmCategories = new Categories();
            frmCategories.MdiParent = this;
            frmCategories.Dock = DockStyle.Fill;
            frmCategories.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "MiniPOS — Gestión de clientes";

            Clients frmClients = new Clients();
            frmClients.MdiParent = this;
            frmClients.Dock = DockStyle.Fill;
            frmClients.Show();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "MiniPOS — Gestión de proveedores";

            Suppliers frmSuppliers = new Suppliers();
            frmSuppliers.MdiParent = this;
            frmSuppliers.Dock = DockStyle.Fill;
            frmSuppliers.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "MiniPOS — Reportes";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
