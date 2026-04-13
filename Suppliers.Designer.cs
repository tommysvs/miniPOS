namespace miniPOS
{
    partial class Suppliers
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
            components = new System.ComponentModel.Container();
            grpbSuppList = new GroupBox();
            dgvSuppliers = new DataGridView();
            btnExport = new Button();
            lblSuppCnt = new Label();
            btnFind = new Button();
            txtFind = new TextBox();
            grpbSuppData = new GroupBox();
            lblErrorEmail = new Label();
            lblSuppCntct = new Label();
            txtSuppCntct = new TextBox();
            lblSuppProds = new Label();
            txtSuppPrd = new TextBox();
            txtSuppTel = new TextBox();
            lblCliAdd = new Label();
            txtSuppAdd = new TextBox();
            lblCliTel = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            lblCliEmail = new Label();
            txtSuppEmail = new TextBox();
            lblSuppName = new Label();
            txtSuppName = new TextBox();
            lblSuppId = new Label();
            txtSuppId = new TextBox();
            niSuppSaved = new NotifyIcon(components);
            grpbSuppList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            grpbSuppData.SuspendLayout();
            SuspendLayout();
            // 
            // grpbSuppList
            // 
            grpbSuppList.Controls.Add(dgvSuppliers);
            grpbSuppList.Controls.Add(btnExport);
            grpbSuppList.Controls.Add(lblSuppCnt);
            grpbSuppList.Controls.Add(btnFind);
            grpbSuppList.Controls.Add(txtFind);
            grpbSuppList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbSuppList.Location = new Point(341, 12);
            grpbSuppList.Name = "grpbSuppList";
            grpbSuppList.Size = new Size(583, 545);
            grpbSuppList.TabIndex = 7;
            grpbSuppList.TabStop = false;
            grpbSuppList.Text = "Listado de proveedores";
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(6, 53);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.Size = new Size(571, 452);
            dgvSuppliers.TabIndex = 14;
            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
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
            btnExport.TabIndex = 12;
            btnExport.Text = "Exportar a Excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // lblSuppCnt
            // 
            lblSuppCnt.AutoSize = true;
            lblSuppCnt.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSuppCnt.ForeColor = SystemColors.ControlDarkDark;
            lblSuppCnt.Location = new Point(6, 526);
            lblSuppCnt.Name = "lblSuppCnt";
            lblSuppCnt.Size = new Size(139, 13);
            lblSuppCnt.TabIndex = 10;
            lblSuppCnt.Text = "- proveedores registrados";
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
            btnFind.TabIndex = 11;
            btnFind.Text = "Buscar";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(6, 22);
            txtFind.Name = "txtFind";
            txtFind.PlaceholderText = "Buscar por nombre, teléfono o correo...";
            txtFind.Size = new Size(476, 23);
            txtFind.TabIndex = 10;
            // 
            // grpbSuppData
            // 
            grpbSuppData.Controls.Add(lblErrorEmail);
            grpbSuppData.Controls.Add(lblSuppCntct);
            grpbSuppData.Controls.Add(txtSuppCntct);
            grpbSuppData.Controls.Add(lblSuppProds);
            grpbSuppData.Controls.Add(txtSuppPrd);
            grpbSuppData.Controls.Add(txtSuppTel);
            grpbSuppData.Controls.Add(lblCliAdd);
            grpbSuppData.Controls.Add(txtSuppAdd);
            grpbSuppData.Controls.Add(lblCliTel);
            grpbSuppData.Controls.Add(btnDelete);
            grpbSuppData.Controls.Add(btnEdit);
            grpbSuppData.Controls.Add(btnSave);
            grpbSuppData.Controls.Add(lblCliEmail);
            grpbSuppData.Controls.Add(txtSuppEmail);
            grpbSuppData.Controls.Add(lblSuppName);
            grpbSuppData.Controls.Add(txtSuppName);
            grpbSuppData.Controls.Add(lblSuppId);
            grpbSuppData.Controls.Add(txtSuppId);
            grpbSuppData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbSuppData.Location = new Point(12, 12);
            grpbSuppData.Name = "grpbSuppData";
            grpbSuppData.Size = new Size(323, 545);
            grpbSuppData.TabIndex = 6;
            grpbSuppData.TabStop = false;
            grpbSuppData.Text = "Datos del proveedor";
            // 
            // lblErrorEmail
            // 
            lblErrorEmail.AutoSize = true;
            lblErrorEmail.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorEmail.ForeColor = Color.Red;
            lblErrorEmail.Location = new Point(7, 331);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(0, 13);
            lblErrorEmail.TabIndex = 21;
            // 
            // lblSuppCntct
            // 
            lblSuppCntct.AutoSize = true;
            lblSuppCntct.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSuppCntct.Location = new Point(6, 160);
            lblSuppCntct.Name = "lblSuppCntct";
            lblSuppCntct.Size = new Size(120, 15);
            lblSuppCntct.TabIndex = 20;
            lblSuppCntct.Text = "Contacto (persona): *";
            // 
            // txtSuppCntct
            // 
            txtSuppCntct.Location = new Point(6, 178);
            txtSuppCntct.Name = "txtSuppCntct";
            txtSuppCntct.Size = new Size(311, 23);
            txtSuppCntct.TabIndex = 2;
            // 
            // lblSuppProds
            // 
            lblSuppProds.AutoSize = true;
            lblSuppProds.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSuppProds.Location = new Point(6, 423);
            lblSuppProds.Name = "lblSuppProds";
            lblSuppProds.Size = new Size(148, 15);
            lblSuppProds.TabIndex = 18;
            lblSuppProds.Text = "Productos que suministra: ";
            // 
            // txtSuppPrd
            // 
            txtSuppPrd.Location = new Point(6, 441);
            txtSuppPrd.Name = "txtSuppPrd";
            txtSuppPrd.Size = new Size(311, 23);
            txtSuppPrd.TabIndex = 6;
            // 
            // txtSuppTel
            // 
            txtSuppTel.Location = new Point(7, 239);
            txtSuppTel.Name = "txtSuppTel";
            txtSuppTel.Size = new Size(310, 23);
            txtSuppTel.TabIndex = 3;
            txtSuppTel.TextChanged += txtSuppTel_TextChanged;
            // 
            // lblCliAdd
            // 
            lblCliAdd.AutoSize = true;
            lblCliAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliAdd.Location = new Point(7, 353);
            lblCliAdd.Name = "lblCliAdd";
            lblCliAdd.Size = new Size(68, 15);
            lblCliAdd.TabIndex = 15;
            lblCliAdd.Text = "Dirección: *";
            // 
            // txtSuppAdd
            // 
            txtSuppAdd.Location = new Point(7, 371);
            txtSuppAdd.Name = "txtSuppAdd";
            txtSuppAdd.Size = new Size(310, 23);
            txtSuppAdd.TabIndex = 5;
            // 
            // lblCliTel
            // 
            lblCliTel.AutoSize = true;
            lblCliTel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliTel.Location = new Point(6, 221);
            lblCliTel.Name = "lblCliTel";
            lblCliTel.Size = new Size(64, 15);
            lblCliTel.TabIndex = 13;
            lblCliTel.Text = "Teléfono: *";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(196, 511);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 28);
            btnDelete.TabIndex = 9;
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
            btnEdit.Location = new Point(102, 511);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(89, 28);
            btnEdit.TabIndex = 8;
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
            btnSave.Location = new Point(7, 511);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 28);
            btnSave.TabIndex = 7;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblCliEmail
            // 
            lblCliEmail.AutoSize = true;
            lblCliEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliEmail.Location = new Point(7, 287);
            lblCliEmail.Name = "lblCliEmail";
            lblCliEmail.Size = new Size(116, 15);
            lblCliEmail.TabIndex = 5;
            lblCliEmail.Text = "Correo electrónico: *";
            // 
            // txtSuppEmail
            // 
            txtSuppEmail.Location = new Point(7, 305);
            txtSuppEmail.Name = "txtSuppEmail";
            txtSuppEmail.Size = new Size(310, 23);
            txtSuppEmail.TabIndex = 4;
            txtSuppEmail.TextChanged += txtSuppEmail_TextChanged;
            // 
            // lblSuppName
            // 
            lblSuppName.AutoSize = true;
            lblSuppName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSuppName.Location = new Point(6, 94);
            lblSuppName.Name = "lblSuppName";
            lblSuppName.Size = new Size(118, 15);
            lblSuppName.TabIndex = 3;
            lblSuppName.Text = "Nombre / Empresa: *";
            // 
            // txtSuppName
            // 
            txtSuppName.Location = new Point(6, 112);
            txtSuppName.Name = "txtSuppName";
            txtSuppName.Size = new Size(311, 23);
            txtSuppName.TabIndex = 1;
            // 
            // lblSuppId
            // 
            lblSuppId.AutoSize = true;
            lblSuppId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSuppId.Location = new Point(6, 35);
            lblSuppId.Name = "lblSuppId";
            lblSuppId.Size = new Size(78, 15);
            lblSuppId.TabIndex = 1;
            lblSuppId.Text = "ID Proveedor:";
            // 
            // txtSuppId
            // 
            txtSuppId.Enabled = false;
            txtSuppId.Location = new Point(6, 53);
            txtSuppId.Name = "txtSuppId";
            txtSuppId.PlaceholderText = "(Automático)";
            txtSuppId.Size = new Size(311, 23);
            txtSuppId.TabIndex = 0;
            // 
            // niSuppSaved
            // 
            niSuppSaved.Text = "notifyIcon1";
            niSuppSaved.Visible = true;
            // 
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 569);
            Controls.Add(grpbSuppList);
            Controls.Add(grpbSuppData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Suppliers";
            Text = "Suppliers";
            Load += Suppliers_Load;
            grpbSuppList.ResumeLayout(false);
            grpbSuppList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            grpbSuppData.ResumeLayout(false);
            grpbSuppData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbSuppList;
        private Button btnExport;
        private Label lblSuppCnt;
        private Button btnFind;
        private TextBox txtFind;
        private GroupBox grpbSuppData;
        private TextBox txtSuppTel;
        private Label lblCliAdd;
        private TextBox txtSuppAdd;
        private Label lblCliTel;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private Label lblCliEmail;
        private TextBox txtSuppEmail;
        private Label lblSuppName;
        private TextBox txtSuppName;
        private Label lblSuppId;
        private TextBox txtSuppId;
        private Label lblSuppProds;
        private TextBox txtSuppPrd;
        private Label lblSuppCntct;
        private TextBox txtSuppCntct;
        private DataGridView dgvSuppliers;
        private Label lblErrorEmail;
        private NotifyIcon niSuppSaved;
    }
}