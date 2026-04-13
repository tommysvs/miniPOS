using MySql.Data.MySqlClient;
using System.Data;

namespace miniPOS
{
    public partial class Categories : Form
    {
        DataTable table = new DataTable();
        int selected_id = 0;

        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            GetCategories();
            CountCategories();

            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.ReadOnly = true;
            dgvCategories.MultiSelect = false;
        }

        private void ClearFields()
        {
            txtCatName.Clear();
            txtCatDesc.Clear();

            table.DefaultView.RowFilter = string.Empty;
            txtFind.Clear();
        }

        private void GetCategories()
        {
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            c.id, 
                            c.name, 
                            c.description,
                            COUNT(p.id) AS products_count
                        FROM categories c
                        LEFT JOIN products p ON c.id = p.category_id
                        GROUP BY c.id, c.name, c.description";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    table.Clear();
                    adapter.Fill(table);
                    dgvCategories.DataSource = table;

                    dgvCategories.Columns["id"].HeaderText = "ID";
                    dgvCategories.Columns["name"].HeaderText = "Nombre";
                    dgvCategories.Columns["description"].HeaderText = "Descripción";
                    dgvCategories.Columns["products_count"].HeaderText = "# Productos";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener categorías: " + ex.Message);
                }
            }
        }

        private void CountCategories()
        {
            lblCatCnt.Text = $"Total: {table.Rows.Count} categorías registradas";
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

            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
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

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategories.Rows[e.RowIndex];

                if (row.IsNewRow || row.Cells["id"].Value == DBNull.Value)
                {
                    return;
                }

                selected_id = Convert.ToInt32(row.Cells["id"].Value);

                txtCatName.Text = row.Cells["name"].Value != DBNull.Value ? row.Cells["name"].Value.ToString() : string.Empty;
                txtCatDesc.Text = row.Cells["description"].Value != DBNull.Value ? row.Cells["description"].Value.ToString() : string.Empty;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selected_id == 0)
            {
                MessageBox.Show("Debe seleccionar una categoría para actualizar.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE categories SET name = @name, description = @description WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtCatName.Text);
                    cmd.Parameters.AddWithValue("@description", txtCatDesc.Text);
                    cmd.Parameters.AddWithValue("@id", selected_id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoría actualizada exitosamente.");

                    ClearFields();
                    GetCategories();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar categoría: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selected_id == 0)
            {
                MessageBox.Show("Debe seleccionar una categoría para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar esta categoría?",
                "Confirmar eliminación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM categories WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selected_id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Categoría eliminada exitosamente.");
                        GetCategories();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar producto: " + ex.Message);
                    }
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = $"name LIKE '%{txtFind.Text}%' OR description LIKE '%{txtFind.Text}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }
    }
}
