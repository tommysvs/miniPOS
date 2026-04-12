using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace miniPOS
{
    public partial class Categories : Form
    {
        string connection = "server=localhost;database=minipos;uid=root;pwd=root;";

        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            GetCategories();

            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.ReadOnly = true;
            dgvCategories.MultiSelect = false;
        }

        private void ClearFields()
        {
            txtCatName.Clear();
            txtCatDesc.Clear();
        }

        private void GetCategories()
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, name, description FROM categories";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCategories.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener categorías: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCatName.Text == "")
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            if (txtCatDesc.Text.Length < 3)
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO categories (name, description) VALUES (@name, @description)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtCatName.Text);
                    cmd.Parameters.AddWithValue("@description", txtCatDesc.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Categoría registrada exitosamente.");

                    ClearFields();
                    GetCategories();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar categoría: " + ex.Message);
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
    }
}
