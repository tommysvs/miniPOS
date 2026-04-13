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

            GetLowStockProducts();
            GetRecentSuppliers();

            ConfigureDataGridViews();

            niLowStock.Icon = SystemIcons.Warning;
            niLowStock.Visible = true;
            niLowStock.Text = "Productos con bajo stock: " + lblCntLowStock.Text;

            niLowStock.ShowBalloonTip(3000, "Bajo stock", $"Hay {lblCntLowStock.Text} productos con bajo stock", ToolTipIcon.Warning);
        }

        private void ConfigureDataGridViews()
        {
            dgvLowStock.ReadOnly = true;
            dgvLowStock.AllowUserToAddRows = false;
            dgvLowStock.AllowUserToDeleteRows = false;

            dgvRecSupp.ReadOnly = true;
            dgvRecSupp.AllowUserToAddRows = false;
            dgvRecSupp.AllowUserToDeleteRows = false;
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

        private void GetLowStockProducts()
        {
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            p.name, 
                            c.name AS category_name,
                            p.stock,
                            CASE 
                                WHEN p.stock < 5 THEN 'BAJO' 
                                ELSE 'OK' 
                            END AS estado
                        FROM products p
                        LEFT JOIN categories c ON p.category_id = c.id
                        WHERE p.stock < 5
                        ORDER BY p.stock ASC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    dgvLowStock.DataSource = table;

                    dgvLowStock.Columns["name"].HeaderText = "Nombre";
                    dgvLowStock.Columns["category_name"].HeaderText = "Categoría";
                    dgvLowStock.Columns["stock"].HeaderText = "Stock";
                    dgvLowStock.Columns["estado"].HeaderText = "Estado";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener productos con bajo stock: " + ex.Message);
                }
            }
        }

        private void GetRecentSuppliers()
        {
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT name, phone, created_date FROM suppliers ORDER BY id DESC LIMIT 5";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    dgvRecSupp.DataSource = table;

                    dgvRecSupp.Columns["name"].HeaderText = "Nombre";
                    dgvRecSupp.Columns["phone"].HeaderText = "Teléfono";
                    dgvRecSupp.Columns["created_date"].HeaderText = "Fecha registro";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener proveedores recientes: " + ex.Message);
                }
            }
        }

        private void dgvLowStock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvLowStock.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string estado = row.Cells["estado"].Value?.ToString();

                if (estado == "OK")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;

                    row.Cells["stock"].Style.ForeColor = Color.DarkGreen;
                    row.Cells["stock"].Style.Font = new Font(dgvLowStock.Font, FontStyle.Bold);
                }
                else if (estado == "BAJO")
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;

                    row.Cells["stock"].Style.ForeColor = Color.DarkRed;
                    row.Cells["stock"].Style.Font = new Font(dgvLowStock.Font, FontStyle.Bold);
                }
            }

            dgvLowStock.ClearSelection();
        }

        private void btnGetAllProd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            p.name, 
                            c.name AS category_name,
                            p.stock,
                            CASE 
                                WHEN p.stock < 5 THEN 'BAJO' 
                                ELSE 'OK' 
                            END AS estado
                        FROM products p
                        LEFT JOIN categories c ON p.category_id = c.id
                        ORDER BY p.stock ASC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    dgvLowStock.DataSource = table;

                    dgvLowStock.Columns["name"].HeaderText = "Nombre";
                    dgvLowStock.Columns["category_name"].HeaderText = "Categoría";
                    dgvLowStock.Columns["stock"].HeaderText = "Stock";
                    dgvLowStock.Columns["estado"].HeaderText = "Estado";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener productos con bajo stock: " + ex.Message);
                }
            }
        }

        private void btnGetAllSupp_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT name, phone, created_date FROM suppliers ORDER BY id DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    dgvRecSupp.DataSource = table;

                    dgvRecSupp.Columns["name"].HeaderText = "Nombre";
                    dgvRecSupp.Columns["phone"].HeaderText = "Teléfono";
                    dgvRecSupp.Columns["created_date"].HeaderText = "Fecha registro";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener proveedores recientes: " + ex.Message);
                }
            }
        }
    }
}
