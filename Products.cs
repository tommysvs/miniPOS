using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace miniPOS
{
    public partial class Products : Form
    {
        string connection = "server=localhost;database=minipos;uid=root;pwd=root;";

        System.Data.DataTable table = new System.Data.DataTable();

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            GetCategories();
            GetProducts();

            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.ReadOnly = true;
            dgvProducts.MultiSelect = false;
        }

        private void ClearFields()
        {
            txtProdName.Clear();
            cmbProdCat.SelectedIndex = -1;
            txtProdPrice.Clear();
            txtProdStock.Clear();
        }

        private void GetCategories()
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, name FROM categories";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dtCategorias = new DataTable();
                    adapter.Fill(dtCategorias);

                    cmbProdCat.DataSource = dtCategorias;
                    cmbProdCat.DisplayMember = "name";
                    cmbProdCat.ValueMember = "id";

                    cmbProdCat.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar categorías: " + ex.Message);
                }
            }
        }
        
        private void GetProducts()
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM products";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    table.Clear();
                    adapter.Fill(table);
                    dgvProducts.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProdName.Text == "")
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            if (cmbProdCat.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoría.");
                return;
            }

            if (txtProdPrice.Text == "")
            {
                MessageBox.Show("El precio no puede estar vacío.");
                return;
            }

            if (txtProdStock.Text == "")
            {
                MessageBox.Show("El stock no puede estar vacío.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO products (name, category_id, price, stock) VALUES (@name, @category_id, @price, @stock)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtProdName.Text);
                    cmd.Parameters.AddWithValue("@category_id", cmbProdCat.SelectedValue);
                    cmd.Parameters.AddWithValue("@price", txtProdPrice.Text);
                    cmd.Parameters.AddWithValue("@stock", txtProdStock.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Producto registrado exitosamente.");

                    ClearFields();
                    GetProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar producto: " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
