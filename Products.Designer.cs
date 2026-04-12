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
            cmbProdCatFind = new ComboBox();
            lblProdCnt = new Label();
            btnFind = new Button();
            txtFind = new TextBox();
            grpbProdData = new GroupBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            lblProdPrice = new Label();
            txtProdPrice = new TextBox();
            lblProdName = new Label();
            txtProdName = new TextBox();
            lblCatId = new Label();
            txtProdId = new TextBox();
            cmbProdCat = new ComboBox();
            lblProdCat = new Label();
            lblProdStock = new Label();
            txtProdStock = new TextBox();
            lblColors = new Label();
            grpbProdList.SuspendLayout();
            grpbProdData.SuspendLayout();
            SuspendLayout();
            // 
            // grpbProdList
            // 
            grpbProdList.Controls.Add(lblColors);
            grpbProdList.Controls.Add(cmbProdCatFind);
            grpbProdList.Controls.Add(lblProdCnt);
            grpbProdList.Controls.Add(btnFind);
            grpbProdList.Controls.Add(txtFind);
            grpbProdList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbProdList.Location = new Point(418, 12);
            grpbProdList.Name = "grpbProdList";
            grpbProdList.Size = new Size(390, 426);
            grpbProdList.TabIndex = 3;
            grpbProdList.TabStop = false;
            grpbProdList.Text = "Listado de productos";
            // 
            // cmbProdCatFind
            // 
            cmbProdCatFind.FormattingEnabled = true;
            cmbProdCatFind.Location = new Point(263, 27);
            cmbProdCatFind.Name = "cmbProdCatFind";
            cmbProdCatFind.Size = new Size(121, 23);
            cmbProdCatFind.TabIndex = 11;
            // 
            // lblProdCnt
            // 
            lblProdCnt.AutoSize = true;
            lblProdCnt.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProdCnt.ForeColor = SystemColors.ControlDarkDark;
            lblProdCnt.Location = new Point(6, 408);
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
            btnFind.Location = new Point(6, 56);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(89, 28);
            btnFind.TabIndex = 9;
            btnFind.Text = "Buscar";
            btnFind.UseVisualStyleBackColor = false;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(6, 27);
            txtFind.Name = "txtFind";
            txtFind.PlaceholderText = "Buscar producto en tiempo real";
            txtFind.Size = new Size(251, 23);
            txtFind.TabIndex = 0;
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
            grpbProdData.Size = new Size(390, 426);
            grpbProdData.TabIndex = 2;
            grpbProdData.TabStop = false;
            grpbProdData.Text = "Datos del producto";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(196, 392);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 28);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkOrange;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(101, 392);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(89, 28);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(6, 392);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 28);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
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
            txtProdPrice.Size = new Size(378, 23);
            txtProdPrice.TabIndex = 4;
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
            txtProdName.Size = new Size(378, 23);
            txtProdName.TabIndex = 2;
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
            txtProdId.Size = new Size(378, 23);
            txtProdId.TabIndex = 0;
            // 
            // cmbProdCat
            // 
            cmbProdCat.FormattingEnabled = true;
            cmbProdCat.Location = new Point(6, 172);
            cmbProdCat.Name = "cmbProdCat";
            cmbProdCat.Size = new Size(378, 23);
            cmbProdCat.TabIndex = 12;
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
            txtProdStock.Size = new Size(378, 23);
            txtProdStock.TabIndex = 14;
            // 
            // lblColors
            // 
            lblColors.AutoSize = true;
            lblColors.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblColors.ForeColor = SystemColors.ControlDarkDark;
            lblColors.Location = new Point(79, 407);
            lblColors.Name = "lblColors";
            lblColors.Size = new Size(283, 13);
            lblColors.TabIndex = 12;
            lblColors.Text = "· Verde: stock normal · Rojo: stock bajo (< 5 unidades)";
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 450);
            Controls.Add(grpbProdList);
            Controls.Add(grpbProdData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Products";
            Text = "Products";
            grpbProdList.ResumeLayout(false);
            grpbProdList.PerformLayout();
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
    }
}