using MySql.Data.MySqlClient;
using System.Data;

namespace miniPOS
{
    public partial class Suppliers : Form
    {
        DataTable table = new DataTable();
        int selected_id = 0;

        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            GetSuppliers();
            CountSuppliers();

            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.MultiSelect = false;

            niSuppSaved.Icon = SystemIcons.Information;
            niSuppSaved.Visible = false;
        }

        private void ClearFields()
        {
            txtSuppName.Clear();
            txtSuppCntct.Clear();
            txtSuppTel.Clear();
            txtSuppEmail.Clear();
            txtSuppAdd.Clear();
            txtSuppPrd.Clear();

            table.DefaultView.RowFilter = string.Empty;
            txtFind.Clear();

            lblErrorEmail.Visible = false;
        }

        private void GetSuppliers()
        {
            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            id, 
                            name,
                            contact_person,
                            phone,
                            email,
                            address,
                            products
                        FROM suppliers";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    table.Clear();
                    adapter.Fill(table);
                    dgvSuppliers.DataSource = table;

                    dgvSuppliers.Columns["id"].HeaderText = "ID";
                    dgvSuppliers.Columns["name"].HeaderText = "Nombre";
                    dgvSuppliers.Columns["contact_person"].HeaderText = "Contacto (persona)";
                    dgvSuppliers.Columns["phone"].HeaderText = "Teléfono";
                    dgvSuppliers.Columns["email"].HeaderText = "Correo electrónico";
                    dgvSuppliers.Columns["address"].HeaderText = "Dirección";
                    dgvSuppliers.Columns["products"].HeaderText = "Productos";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener proveedores: " + ex.Message);
                }
            }
        }

        private void CountSuppliers()
        {
            lblSuppCnt.Text = $"{table.Rows.Count} proveedores registrados";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSuppName.Text == "")
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            if (txtSuppTel.Text == "")
            {
                MessageBox.Show("El teléfono no puede estar vacío.");
                return;
            }

            if (txtSuppEmail.Text == "")
            {
                MessageBox.Show("El correo electrónico no puede estar vacío.");
                return;
            }

            if (!txtSuppEmail.Text.Contains("@") || !txtSuppEmail.Text.Contains("."))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return;
            }

            if (txtSuppAdd.Text == "")
            {
                MessageBox.Show("La dirección no puede estar vacía.");
                return;
            }

            if(txtSuppPrd.Text == "")
            {
                MessageBox.Show("El campo de productos no puede estar vacío.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO suppliers (name, contact_person, phone, email, address, products, created_date) VALUES (@name, @contact_person, @phone, @email, @address, @products, @created_date)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtSuppName.Text);
                    cmd.Parameters.AddWithValue("@contact_person", txtSuppCntct.Text);
                    cmd.Parameters.AddWithValue("@phone", txtSuppTel.Text);
                    cmd.Parameters.AddWithValue("@email", txtSuppEmail.Text);
                    cmd.Parameters.AddWithValue("@address", txtSuppAdd.Text);
                    cmd.Parameters.AddWithValue("@products", txtSuppPrd.Text);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Proveedor registrado exitosamente.");

                    niSuppSaved.Visible = true;
                    niSuppSaved.ShowBalloonTip(3000, "Proveedor registrado", $"El proveedor ha sido registrado exitosamente", ToolTipIcon.Info);

                    ClearFields();
                    GetSuppliers();

                    CountSuppliers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar proveedor: " + ex.Message);
                }
            }
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSuppliers.Rows[e.RowIndex];

                if (row.IsNewRow || row.Cells["id"].Value == DBNull.Value)
                {
                    return;
                }

                selected_id = Convert.ToInt32(row.Cells["id"].Value);

                txtSuppName.Text = row.Cells["name"].Value != DBNull.Value ? row.Cells["name"].Value.ToString() : string.Empty;
                txtSuppCntct.Text = row.Cells["contact_person"].Value != DBNull.Value ? row.Cells["contact_person"].Value.ToString() : string.Empty;
                txtSuppTel.Text = row.Cells["phone"].Value != DBNull.Value ? row.Cells["phone"].Value.ToString() : string.Empty;
                txtSuppEmail.Text = row.Cells["email"].Value != DBNull.Value ? row.Cells["email"].Value.ToString() : string.Empty;
                txtSuppAdd.Text = row.Cells["address"].Value != DBNull.Value ? row.Cells["address"].Value.ToString() : string.Empty;
                txtSuppPrd.Text = row.Cells["products"].Value != DBNull.Value ? row.Cells["products"].Value.ToString() : string.Empty;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selected_id == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor para actualizar.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE suppliers SET name = @name, contact_person = @contact_person, phone = @phone, email = @email, address = @address, products = @products WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtSuppName.Text);
                    cmd.Parameters.AddWithValue("@contact_person", txtSuppCntct.Text);
                    cmd.Parameters.AddWithValue("@phone", txtSuppTel.Text);
                    cmd.Parameters.AddWithValue("@email", txtSuppEmail.Text);
                    cmd.Parameters.AddWithValue("@address", txtSuppAdd.Text);
                    cmd.Parameters.AddWithValue("@products", txtSuppPrd.Text);
                    cmd.Parameters.AddWithValue("@id", selected_id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proveedor actualizado exitosamente.");

                    ClearFields();
                    GetSuppliers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar proveedor: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selected_id == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar este proveedor?",
                "Confirmar eliminación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM suppliers WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selected_id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Proveedor eliminado exitosamente.");
                        ClearFields();
                        GetSuppliers();
                        CountSuppliers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar proveedor: " + ex.Message);
                    }
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = $"name LIKE '%{txtFind.Text}%' OR contact_person LIKE '%{txtFind.Text}%' OR phone LIKE '%{txtFind.Text}%' OR email LIKE '%{txtFind.Text}%' OR address LIKE '%{txtFind.Text}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportToExcel(table, "Proveedores");
        }

        private void txtSuppTel_TextChanged(object sender, EventArgs e)
        {
            bool isNumber = true;
            foreach (char c in txtSuppTel.Text)
            {
                if (!char.IsDigit(c))
                {
                    isNumber = false;
                    break;
                }
            }

            if (!isNumber && !string.IsNullOrEmpty(txtSuppTel.Text))
            {
                txtSuppTel.Text = System.Text.RegularExpressions.Regex.Replace(txtSuppTel.Text, "[^0-9]", "");
                txtSuppTel.SelectionStart = txtSuppTel.Text.Length;
            }
        }

        private void txtSuppEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSuppEmail.Text))
            {
                lblErrorEmail.Visible = false;
                return;
            }

            if (txtSuppEmail.Text.Contains("@") && txtSuppEmail.Text.Contains("."))
            {
                lblErrorEmail.Visible = false;
            }
            else
            {
                lblErrorEmail.Text = "El correo debe estar en un formato válido.";
                lblErrorEmail.Visible = true;
            }
        }
    }
}
