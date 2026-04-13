using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace miniPOS
{
    public partial class Clients : Form
    {
        DataTable table = new DataTable();
        int selected_id = 0;

        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            GetClients();
            CountClients();

            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.ReadOnly = true;
            dgvClients.MultiSelect = false;
        }

        private void ClearFields()
        {
            txtCliName.Clear();
            txtCliTel.Clear();
            txtCliAdd.Clear();
            txtCliEmail.Clear();

            table.DefaultView.RowFilter = string.Empty;
            txtFind.Clear();

            lblErrorEmail.Visible = false;
        }

        private void GetClients()
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
                            phone,
                            email,
                            address
                        FROM clients";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    table.Clear();
                    adapter.Fill(table);
                    dgvClients.DataSource = table;

                    dgvClients.Columns["id"].HeaderText = "ID";
                    dgvClients.Columns["name"].HeaderText = "Nombre";
                    dgvClients.Columns["phone"].HeaderText = "Teléfono";
                    dgvClients.Columns["email"].HeaderText = "Correo electrónico";
                    dgvClients.Columns["address"].HeaderText = "Dirección";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching clients: " + ex.Message);
                }
            }
        }

        private void CountClients()
        {
            lblCliCnt.Text = $"{table.Rows.Count} clientes registrados";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCliName.Text == "")
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            if (txtCliTel.Text == "")
            {
                MessageBox.Show("El teléfono no puede estar vacío.");
                return;
            }

            if (txtCliEmail.Text == "")
            {
                MessageBox.Show("El correo electrónico no puede estar vacío.");
                return;
            }

            if (!txtCliEmail.Text.Contains("@") || !txtCliEmail.Text.Contains("."))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return;
            }

            if (txtCliAdd.Text == "")
            {
                MessageBox.Show("El stock no puede estar vacío.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO clients (name, phone, email, address, created_date) VALUES (@name, @phone, @email, @address, @created_date)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtCliName.Text);
                    cmd.Parameters.AddWithValue("@phone", txtCliTel.Text);
                    cmd.Parameters.AddWithValue("@email", txtCliEmail.Text);
                    cmd.Parameters.AddWithValue("@address", txtCliAdd.Text);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente registrado exitosamente.");

                    ClearFields();
                    GetClients();

                    CountClients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar cliente: " + ex.Message);
                }
            }
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClients.Rows[e.RowIndex];

                if (row.IsNewRow || row.Cells["id"].Value == DBNull.Value)
                {
                    return;
                }

                selected_id = Convert.ToInt32(row.Cells["id"].Value);

                txtCliName.Text = row.Cells["name"].Value != DBNull.Value ? row.Cells["name"].Value.ToString() : string.Empty;
                txtCliTel.Text = row.Cells["phone"].Value != DBNull.Value ? row.Cells["phone"].Value.ToString() : string.Empty;
                txtCliEmail.Text = row.Cells["email"].Value != DBNull.Value ? row.Cells["email"].Value.ToString() : string.Empty;
                txtCliAdd.Text = row.Cells["address"].Value != DBNull.Value ? row.Cells["address"].Value.ToString() : string.Empty;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selected_id == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente para actualizar.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE clients SET name = @name, phone = @phone, email = @email, address = @address WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtCliName.Text);
                    cmd.Parameters.AddWithValue("@phone", txtCliTel.Text);
                    cmd.Parameters.AddWithValue("@email", txtCliEmail.Text);
                    cmd.Parameters.AddWithValue("@address", txtCliAdd.Text);
                    cmd.Parameters.AddWithValue("@id", selected_id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente actualizado exitosamente.");

                    ClearFields();
                    GetClients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar cliente: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selected_id == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar este cliente?",
                "Confirmar eliminación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM clients WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selected_id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente eliminado exitosamente.");

                        ClearFields();
                        GetClients();
                        CountClients();
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
                dv.RowFilter = $"name LIKE '%{txtFind.Text}%' OR phone LIKE '%{txtFind.Text}%' OR email LIKE '%{txtFind.Text}%' OR address LIKE '%{txtFind.Text}%'";
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
                sfd.FileName = "Clientes.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add(dt, "Clientes");

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
            ExcelHelper.ExportToExcel(table, "Clientes");
        }

        private void txtCliTel_TextChanged(object sender, EventArgs e)
        {
            bool isNumber = true;
            foreach (char c in txtCliTel.Text)
            {
                if (!char.IsDigit(c))
                {
                    isNumber = false;
                    break;
                }
            }

            if (!isNumber && !string.IsNullOrEmpty(txtCliTel.Text))
            {
                txtCliTel.Text = System.Text.RegularExpressions.Regex.Replace(txtCliTel.Text, "[^0-9]", "");
                txtCliTel.SelectionStart = txtCliTel.Text.Length;
            }
        }

        private void txtCliEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliEmail.Text))
            {
                lblErrorEmail.Visible = false;
                return;
            }

            if (txtCliEmail.Text.Contains("@") && txtCliEmail.Text.Contains("."))
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
