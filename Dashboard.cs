using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace miniPOS
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
            lblDate.Text = "[Fecha actual del sistema — " + DateTime.Now.ToString("dd/MM/yyyy") + " ]";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountProducts();
            CountClients();
            CountSuppliers();
            CountCategories();
            CountProductsLowStock();
        }

        private void CountProducts()
        {
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM products";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int total = Convert.ToInt32(cmd.ExecuteScalar());

                    lblCntProd.Text = total.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al contar productos: " + ex.Message);
                }
            }
        }

        private void CountClients()
        {
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM clients";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int total = Convert.ToInt32(cmd.ExecuteScalar());
                    lblCntCli.Text = total.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al contar clientes: " + ex.Message);
                }
            }
        }

        private void CountSuppliers()
        {
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM suppliers";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int total = Convert.ToInt32(cmd.ExecuteScalar());
                    lblCntSupp.Text = total.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al contar proveedores: " + ex.Message);
                }
            }
        }

        private void CountCategories()
        {
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM categories";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int total = Convert.ToInt32(cmd.ExecuteScalar());
                    lblCntCat.Text = total.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al contar categorías: " + ex.Message);
                }
            }
        }

        private void CountProductsLowStock()
        {
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM products WHERE stock < 5";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int total = Convert.ToInt32(cmd.ExecuteScalar());
                    lblCntLowStock.Text = total.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al contar productos con bajo stock: " + ex.Message);
                }
            }
        }
    }
}
