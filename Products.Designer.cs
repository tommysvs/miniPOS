namespace miniPOS
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpbProdList = new GroupBox();
            dgvProducts = new DataGridView();
            btnExport = new Button();
            lblColors = new Label();
            cmbProdCatFind = new ComboBox();
            lblProdCnt = new Label();
            btnFind = new Button();
            txtFind = new TextBox();
            grpbProdData = new GroupBox();
            lblProdStock = new Label();
            txtProdStock = new TextBox();
            lblProdCat = new Label();
            cmbProdCat = new ComboBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            lblProdPrice = new Label();
            txtProdPrice = new TextBox();
            lblProdName = new Label();
            txtProdName = new TextBox();
            lblCatId = new Label();
            txtProdId = new TextBox();
            grpbProdList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            grpbProdData.SuspendLayout();
            SuspendLayout();
            // 
            // grpbProdList
            // 
            grpbProdList.Controls.Add(dgvProducts);
            grpbProdList.Controls.Add(btnExport);
            grpbProdList.Controls.Add(lblColors);
            grpbProdList.Controls.Add(cmbProdCatFind);
            grpbProdList.Controls.Add(lblProdCnt);
            grpbProdList.Controls.Add(btnFind);
            grpbProdList.Controls.Add(txtFind);
            grpbProdList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbProdList.Location = new Point(341, 12);
            grpbProdList.Name = "grpbProdList";
            grpbProdList.Size = new Size(583, 545);
            grpbProdList.TabIndex = 3;
            grpbProdList.TabStop = false;
            grpbProdList.Text = "Listado de productos";
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(6, 53);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(571, 452);
            dgvProducts.TabIndex = 14;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Silver;
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.ForeColor = SystemColors.ActiveCaptionText;
            btnExport.Location = new Point(441, 511);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(136, 28);
            btnExport.TabIndex = 11;
            btnExport.Text = "Exportar a Excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // lblColors
            // 
            lblColors.AutoSize = true;
            lblColors.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblColors.ForeColor = SystemColors.ControlDarkDark;
            lblColors.Location = new Point(152, 525);
            lblColors.Name = "lblColors";
            lblColors.Size = new Size(283, 13);
            lblColors.TabIndex = 12;
            lblColors.Text = "· Verde: stock normal · Rojo: stock bajo (< 5 unidades)";
            // 
            // cmbProdCatFind
            // 
            cmbProdCatFind.FormattingEnabled = true;
            cmbProdCatFind.Location = new Point(351, 22);
            cmbProdCatFind.Name = "cmbProdCatFind";
            cmbProdCatFind.Size = new Size(131, 23);
            cmbProdCatFind.TabIndex = 9;
            // 
            // lblProdCnt
            // 
            lblProdCnt.AutoSize = true;
            lblProdCnt.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProdCnt.ForeColor = SystemColors.ControlDarkDark;
            lblProdCnt.Location = new Point(6, 526);
            lblProdCnt.Name = "lblProdCnt";
            lblProdCnt.Size = new Size(67, 13);
            lblProdCnt.TabIndex = 10;
            lblProdCnt.Text = "- productos";
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.DodgerBlue;
            btnFind.Cursor = Cursors.Hand;
            btnFind.FlatAppearance.BorderSize = 0;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.ForeColor = SystemColors.ButtonHighlight;
            btnFind.Location = new Point(488, 18);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(89, 28);
            btnFind.TabIndex = 10;
            btnFind.Text = "Buscar";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(6, 22);
            txtFind.Name = "txtFind";
            txtFind.PlaceholderText = "Buscar producto en tiempo real";
            txtFind.Size = new Size(339, 23);
            txtFind.TabIndex = 8;
            // 
            // grpbProdData
            // 
            grpbProdData.Controls.Add(lblProdStock);
            grpbProdData.Controls.Add(txtProdStock);
            grpbProdData.Controls.Add(lblProdCat);
            grpbProdData.Controls.Add(cmbProdCat);
            grpbProdData.Controls.Add(btnDelete);
            grpbProdData.Controls.Add(btnEdit);
            grpbProdData.Controls.Add(btnSave);
            grpbProdData.Controls.Add(lblProdPrice);
            grpbProdData.Controls.Add(txtProdPrice);
            grpbProdData.Controls.Add(lblProdName);
            grpbProdData.Controls.Add(txtProdName);
            grpbProdData.Controls.Add(lblCatId);
            grpbProdData.Controls.Add(txtProdId);
            grpbProdData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbProdData.Location = new Point(12, 12);
            grpbProdData.Name = "grpbProdData";
            grpbProdData.Size = new Size(323, 545);
            grpbProdData.TabIndex = 2;
            grpbProdData.TabStop = false;
            grpbProdData.Text = "Datos del producto";
            // 
            // lblProdStock
            // 
            lblProdStock.AutoSize = true;
            lblProdStock.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProdStock.Location = new Point(6, 282);
            lblProdStock.Name = "lblProdStock";
            lblProdStock.Size = new Size(82, 15);
            lblProdStock.TabIndex = 15;
            lblProdStock.Text = "Stock actual: *";
            // 
            // txtProdStock
            // 
            txtProdStock.Location = new Point(6, 300);
            txtProdStock.Name = "txtProdStock";
            txtProdStock.Size = new Size(311, 23);
            txtProdStock.TabIndex = 4;
            txtProdStock.KeyPress += txtProdStock_KeyPress;
            // 
            // lblProdCat
            // 
            lblProdCat.AutoSize = true;
            lblProdCat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProdCat.Location = new Point(6, 154);
            lblProdCat.Name = "lblProdCat";
            lblProdCat.Size = new Size(69, 15);
            lblProdCat.TabIndex = 13;
            lblProdCat.Text = "Categoría: *";
            // 
            // cmbProdCat
            // 
            cmbProdCat.FormattingEnabled = true;
            cmbProdCat.Location = new Point(6, 172);
            cmbProdCat.Name = "cmbProdCat";
            cmbProdCat.Size = new Size(311, 23);
            cmbProdCat.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(196, 357);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 28);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkOrange;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(101, 357);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(89, 28);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(6, 357);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 28);
            btnSave.TabIndex = 5;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblProdPrice
            // 
            lblProdPrice.AutoSize = true;
            lblProdPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProdPrice.Location = new Point(6, 217);
            lblProdPrice.Name = "lblProdPrice";
            lblProdPrice.Size = new Size(99, 15);
            lblProdPrice.TabIndex = 5;
            lblProdPrice.Text = "Precio de venta: *";
            // 
            // txtProdPrice
            // 
            txtProdPrice.Location = new Point(6, 235);
            txtProdPrice.Name = "txtProdPrice";
            txtProdPrice.Size = new Size(311, 23);
            txtProdPrice.TabIndex = 3;
            txtProdPrice.KeyPress += txtProdPrice_KeyPress;
            // 
            // lblProdName
            // 
            lblProdName.AutoSize = true;
            lblProdName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProdName.Location = new Point(6, 94);
            lblProdName.Name = "lblProdName";
            lblProdName.Size = new Size(133, 15);
            lblProdName.TabIndex = 3;
            lblProdName.Text = "Nombre del producto: *";
            // 
            // txtProdName
            // 
            txtProdName.Location = new Point(6, 112);
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(311, 23);
            txtProdName.TabIndex = 1;
            // 
            // lblCatId
            // 
            lblCatId.AutoSize = true;
            lblCatId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCatId.Location = new Point(6, 35);
            lblCatId.Name = "lblCatId";
            lblCatId.Size = new Size(73, 15);
            lblCatId.TabIndex = 1;
            lblCatId.Text = "ID Producto:";
            // 
            // txtProdId
            // 
            txtProdId.Enabled = false;
            txtProdId.Location = new Point(6, 53);
            txtProdId.Name = "txtProdId";
            txtProdId.PlaceholderText = "(Automático)";
            txtProdId.Size = new Size(311, 23);
            txtProdId.TabIndex = 0;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 569);
            Controls.Add(grpbProdList);
            Controls.Add(grpbProdData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
            grpbProdList.ResumeLayout(false);
            grpbProdList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            grpbProdData.ResumeLayout(false);
            grpbProdData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbProdList;
        private Label lblProdCnt;
        private Button btnFind;
        private TextBox txtFind;
        private GroupBox grpbProdData;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private Label lblProdPrice;
        private TextBox txtProdPrice;
        private Label lblProdName;
        private TextBox txtProdName;
        private Label lblCatId;
        private TextBox txtProdId;
        private ComboBox cmbProdCatFind;
        private ComboBox cmbProdCat;
        private Label lblProdCat;
        private Label lblProdStock;
        private TextBox txtProdStock;
        private Label lblColors;
        private Button btnExport;
        private DataGridView dgvProducts;
    }
}