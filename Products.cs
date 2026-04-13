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
        DataTable table = new DataTable();
        int selected_id = 0;

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            GetCategories();
            GetProducts();
            CountProducts();

            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.ReadOnly = true;
            dgvProducts.MultiSelect = false;

            dgvProducts.DataBindingComplete += dgvProducts_DataBindingComplete;
        }

        private void ClearFields()
        {
            txtProdName.Clear();
            cmbProdCat.SelectedIndex = -1;
            txtProdPrice.Clear();
            txtProdStock.Clear();

            table.DefaultView.RowFilter = string.Empty;
            txtFind.Clear();
            cmbProdCatFind.SelectedIndex = -1;
        }

        private void GetCategories()
        {
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
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

                    cmbProdCatFind.DataSource = dtCategorias.Copy();
                    cmbProdCatFind.DisplayMember = "name";
                    cmbProdCatFind.ValueMember = "id";
                    cmbProdCatFind.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar categorías: " + ex.Message);
                }
            }
        }

        private void GetProducts()
        {
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            p.id, 
                            p.name, 
                            p.category_id, 
                            c.name AS category_name, 
                            p.price, 
                            p.stock,
                            CASE 
                                WHEN p.stock < 5 THEN 'BAJO' 
                                ELSE 'OK' 
                            END AS estado
                        FROM products p
                        LEFT JOIN categories c ON p.category_id = c.id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    table.Clear();
                    adapter.Fill(table);
                    dgvProducts.DataSource = table;

                    dgvProducts.Columns["id"].HeaderText = "ID";
                    dgvProducts.Columns["name"].HeaderText = "Nombre";
                    dgvProducts.Columns["category_name"].HeaderText = "Categoría";
                    dgvProducts.Columns["price"].HeaderText = "Precio";
                    dgvProducts.Columns["stock"].HeaderText = "Stock";
                    dgvProducts.Columns["estado"].HeaderText = "Estado";

                    dgvProducts.Columns["category_id"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }

        private void CountProducts()
        {
            lblProdCnt.Text = $"{dgvProducts.Rows.Count} productos";
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

            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
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

                    CountProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar producto: " + ex.Message);
                }
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                if (row.IsNewRow || row.Cells["id"].Value == DBNull.Value)
                {
                    return;
                }

                selected_id = Convert.ToInt32(row.Cells["id"].Value);

                txtProdName.Text = row.Cells["name"].Value != DBNull.Value ? row.Cells["name"].Value.ToString() : string.Empty;

                if (row.Cells["category_id"].Value != DBNull.Value)
                {
                    cmbProdCat.SelectedValue = row.Cells["category_id"].Value;
                }
                else
                {
                    cmbProdCat.SelectedIndex = -1;
                }

                txtProdPrice.Text = row.Cells["price"].Value != DBNull.Value ? row.Cells["price"].Value.ToString() : string.Empty;
                txtProdStock.Text = row.Cells["stock"].Value != DBNull.Value ? row.Cells["stock"].Value.ToString() : string.Empty;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selected_id == 0)
            {
                MessageBox.Show("Debe seleccionar un producto para actualizar.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE products SET name = @name, category_id = @category_id, price = @price, stock = @stock WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtProdName.Text);
                    cmd.Parameters.AddWithValue("@category_id", cmbProdCat.SelectedValue);
                    cmd.Parameters.AddWithValue("@price", txtProdPrice.Text);
                    cmd.Parameters.AddWithValue("@stock", txtProdStock.Text);
                    cmd.Parameters.AddWithValue("@id", selected_id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto actualizado exitosamente.");

                    ClearFields();
                    GetProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar producto: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selected_id == 0)
            {
                MessageBox.Show("Debe seleccionar un producto para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar este producto?",
                "Confirmar eliminación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM products WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selected_id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto eliminado exitosamente.");

                        ClearFields();
                        GetProducts();
                        CountProducts();
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
                List<string> filters = new List<string>();

                if (!string.IsNullOrWhiteSpace(txtFind.Text))
                {
                    filters.Add($"name LIKE '%{txtFind.Text.Replace("'", "''")}%'");
                }

                if (cmbProdCatFind.SelectedIndex != -1)
                {
                    filters.Add($"category_id = {cmbProdCatFind.SelectedValue}");
                }

                if (filters.Count > 0)
                {
                    dv.RowFilter = string.Join(" AND ", filters);
                }
                else
                {
                    dv.RowFilter = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void ExcelExport(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel (*.xlsx)|*.xlsx";
                sfd.FileName = "Productos.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add(dt, "Productos");

                            ws.Row(1).Style.Font.Bold = true;

                            ws.Columns().AdjustToContents();

                            wb.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Datos exportados exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar datos: " + ex.Message);
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExcelExport(table);
        }

        private void txtProdPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') && txtProdPrice.Text.IndexOf('.') == -1 && txtProdPrice.Text.IndexOf(',') == -1)
            {
                return;
            }

            e.Handled = true;
        }

        private void txtProdStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void dgvProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.IsNewRow) 
                    continue;

                string estado = row.Cells["estado"].Value?.ToString();

                if (estado == "OK")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;

                    row.Cells["stock"].Style.ForeColor = Color.DarkGreen;
                    row.Cells["stock"].Style.Font = new Font(dgvProducts.Font, FontStyle.Bold);
                }
                else if (estado == "BAJO")
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;

                    row.Cells["stock"].Style.ForeColor = Color.DarkRed;
                    row.Cells["stock"].Style.Font = new Font(dgvProducts.Font, FontStyle.Bold);
                }
            }

            dgvProducts.ClearSelection();
        }
    }
}
