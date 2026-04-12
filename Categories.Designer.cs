namespace miniPOS
{
    partial class Categories
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
            grpbCatData = new GroupBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            lblCatDesc = new Label();
            txtCatDesc = new TextBox();
            lblCatName = new Label();
            txtCatName = new TextBox();
            lblCatId = new Label();
            txtCatId = new TextBox();
            grpbCatList = new GroupBox();
            dgvCategories = new DataGridView();
            lblCatCnt = new Label();
            btnFind = new Button();
            txtFind = new TextBox();
            grpbCatData.SuspendLayout();
            grpbCatList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // grpbCatData
            // 
            grpbCatData.Controls.Add(btnDelete);
            grpbCatData.Controls.Add(btnEdit);
            grpbCatData.Controls.Add(btnSave);
            grpbCatData.Controls.Add(lblCatDesc);
            grpbCatData.Controls.Add(txtCatDesc);
            grpbCatData.Controls.Add(lblCatName);
            grpbCatData.Controls.Add(txtCatName);
            grpbCatData.Controls.Add(lblCatId);
            grpbCatData.Controls.Add(txtCatId);
            grpbCatData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbCatData.Location = new Point(12, 12);
            grpbCatData.Name = "grpbCatData";
            grpbCatData.Size = new Size(323, 545);
            grpbCatData.TabIndex = 0;
            grpbCatData.TabStop = false;
            grpbCatData.Text = "Datos de la categoría";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(196, 221);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 28);
            btnDelete.TabIndex = 5;
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
            btnEdit.Location = new Point(101, 221);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(89, 28);
            btnEdit.TabIndex = 4;
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
            btnSave.Location = new Point(6, 221);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 28);
            btnSave.TabIndex = 3;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblCatDesc
            // 
            lblCatDesc.AutoSize = true;
            lblCatDesc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCatDesc.Location = new Point(6, 156);
            lblCatDesc.Name = "lblCatDesc";
            lblCatDesc.Size = new Size(129, 15);
            lblCatDesc.TabIndex = 5;
            lblCatDesc.Text = "Descripción (opcional):";
            // 
            // txtCatDesc
            // 
            txtCatDesc.Location = new Point(6, 174);
            txtCatDesc.Name = "txtCatDesc";
            txtCatDesc.Size = new Size(311, 23);
            txtCatDesc.TabIndex = 2;
            // 
            // lblCatName
            // 
            lblCatName.AutoSize = true;
            lblCatName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCatName.Location = new Point(6, 94);
            lblCatName.Name = "lblCatName";
            lblCatName.Size = new Size(142, 15);
            lblCatName.TabIndex = 3;
            lblCatName.Text = "Nombre de la categoría: *";
            // 
            // txtCatName
            // 
            txtCatName.Location = new Point(6, 112);
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(311, 23);
            txtCatName.TabIndex = 1;
            // 
            // lblCatId
            // 
            lblCatId.AutoSize = true;
            lblCatId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCatId.Location = new Point(6, 35);
            lblCatId.Name = "lblCatId";
            lblCatId.Size = new Size(75, 15);
            lblCatId.TabIndex = 1;
            lblCatId.Text = "ID Categoría:";
            // 
            // txtCatId
            // 
            txtCatId.Enabled = false;
            txtCatId.Location = new Point(6, 53);
            txtCatId.Name = "txtCatId";
            txtCatId.PlaceholderText = "(Automático)";
            txtCatId.Size = new Size(311, 23);
            txtCatId.TabIndex = 0;
            // 
            // grpbCatList
            // 
            grpbCatList.Controls.Add(dgvCategories);
            grpbCatList.Controls.Add(lblCatCnt);
            grpbCatList.Controls.Add(btnFind);
            grpbCatList.Controls.Add(txtFind);
            grpbCatList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbCatList.Location = new Point(341, 12);
            grpbCatList.Name = "grpbCatList";
            grpbCatList.Size = new Size(583, 545);
            grpbCatList.TabIndex = 1;
            grpbCatList.TabStop = false;
            grpbCatList.Text = "Listado de categorías";
            // 
            // dgvCategories
            // 
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(6, 53);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.Size = new Size(571, 470);
            dgvCategories.TabIndex = 11;
            dgvCategories.CellClick += dgvCategories_CellClick;
            // 
            // lblCatCnt
            // 
            lblCatCnt.AutoSize = true;
            lblCatCnt.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCatCnt.ForeColor = SystemColors.ControlDarkDark;
            lblCatCnt.Location = new Point(6, 526);
            lblCatCnt.Name = "lblCatCnt";
            lblCatCnt.Size = new Size(157, 13);
            lblCatCnt.TabIndex = 10;
            lblCatCnt.Text = "Total: - categorías registradas";
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
            btnFind.TabIndex = 7;
            btnFind.Text = "Buscar";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(6, 22);
            txtFind.Name = "txtFind";
            txtFind.PlaceholderText = "Buscar categoría...";
            txtFind.Size = new Size(476, 23);
            txtFind.TabIndex = 6;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 569);
            Controls.Add(grpbCatList);
            Controls.Add(grpbCatData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Categories";
            Text = "Categories";
            Load += Categories_Load;
            grpbCatData.ResumeLayout(false);
            grpbCatData.PerformLayout();
            grpbCatList.ResumeLayout(false);
            grpbCatList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbCatData;
        private GroupBox grpbCatList;
        private Label lblCatId;
        private TextBox txtCatId;
        private Label lblCatName;
        private TextBox txtCatName;
        private Label lblCatDesc;
        private TextBox txtCatDesc;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private TextBox txtFind;
        private Button btnFind;
        private Label lblCatCnt;
        private DataGridView dgvCategories;
    }
}