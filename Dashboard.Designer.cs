namespace miniPOS
{
    partial class Dashboard
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
            lblResumen = new Label();
            lblDate = new Label();
            pnlProd = new Panel();
            lblCntProd = new Label();
            lblProdReg = new Label();
            pnlCli = new Panel();
            lblCntCli = new Label();
            lblCliReg = new Label();
            pnlSupp = new Panel();
            lblCntSupp = new Label();
            lblSuppAct = new Label();
            pnlCat = new Panel();
            lblCntCat = new Label();
            lblCat = new Label();
            pnlProdLow = new Panel();
            lblCntLowStock = new Label();
            lblLowStock = new Label();
            grpbProducts = new GroupBox();
            btnGetAllProd = new Button();
            grpbSuppliers = new GroupBox();
            btnGetAllSupp = new Button();
            groupBox1 = new GroupBox();
            dgvLowStock = new DataGridView();
            dgvRecSupp = new DataGridView();
            pnlProd.SuspendLayout();
            pnlCli.SuspendLayout();
            pnlSupp.SuspendLayout();
            pnlCat.SuspendLayout();
            pnlProdLow.SuspendLayout();
            grpbProducts.SuspendLayout();
            grpbSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecSupp).BeginInit();
            SuspendLayout();
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResumen.ForeColor = Color.Black;
            lblResumen.Location = new Point(12, 9);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(113, 15);
            lblResumen.TabIndex = 3;
            lblResumen.Text = "Resumen del día —";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = SystemColors.Highlight;
            lblDate.Location = new Point(120, 9);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(166, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "[Fecha actual del sistema — ]";
            // 
            // pnlProd
            // 
            pnlProd.BackColor = Color.White;
            pnlProd.Controls.Add(lblCntProd);
            pnlProd.Controls.Add(lblProdReg);
            pnlProd.Location = new Point(12, 31);
            pnlProd.Name = "pnlProd";
            pnlProd.Size = new Size(177, 69);
            pnlProd.TabIndex = 5;
            // 
            // lblCntProd
            // 
            lblCntProd.AutoSize = true;
            lblCntProd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCntProd.ForeColor = Color.DodgerBlue;
            lblCntProd.Location = new Point(78, 12);
            lblCntProd.Name = "lblCntProd";
            lblCntProd.Size = new Size(25, 30);
            lblCntProd.TabIndex = 7;
            lblCntProd.Text = "0";
            // 
            // lblProdReg
            // 
            lblProdReg.AutoSize = true;
            lblProdReg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProdReg.ForeColor = Color.DimGray;
            lblProdReg.Location = new Point(30, 45);
            lblProdReg.Name = "lblProdReg";
            lblProdReg.Size = new Size(122, 15);
            lblProdReg.TabIndex = 6;
            lblProdReg.Text = "Productos registrados";
            // 
            // pnlCli
            // 
            pnlCli.BackColor = Color.White;
            pnlCli.Controls.Add(lblCntCli);
            pnlCli.Controls.Add(lblCliReg);
            pnlCli.Location = new Point(195, 31);
            pnlCli.Name = "pnlCli";
            pnlCli.Size = new Size(177, 69);
            pnlCli.TabIndex = 8;
            // 
            // lblCntCli
            // 
            lblCntCli.AutoSize = true;
            lblCntCli.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCntCli.ForeColor = Color.MediumSeaGreen;
            lblCntCli.Location = new Point(78, 12);
            lblCntCli.Name = "lblCntCli";
            lblCntCli.Size = new Size(25, 30);
            lblCntCli.TabIndex = 7;
            lblCntCli.Text = "0";
            // 
            // lblCliReg
            // 
            lblCliReg.AutoSize = true;
            lblCliReg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliReg.ForeColor = Color.DimGray;
            lblCliReg.Location = new Point(37, 45);
            lblCliReg.Name = "lblCliReg";
            lblCliReg.Size = new Size(110, 15);
            lblCliReg.TabIndex = 6;
            lblCliReg.Text = "Clientes registrados";
            // 
            // pnlSupp
            // 
            pnlSupp.BackColor = Color.White;
            pnlSupp.Controls.Add(lblCntSupp);
            pnlSupp.Controls.Add(lblSuppAct);
            pnlSupp.Location = new Point(378, 31);
            pnlSupp.Name = "pnlSupp";
            pnlSupp.Size = new Size(177, 69);
            pnlSupp.TabIndex = 9;
            // 
            // lblCntSupp
            // 
            lblCntSupp.AutoSize = true;
            lblCntSupp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCntSupp.ForeColor = Color.SlateBlue;
            lblCntSupp.Location = new Point(78, 12);
            lblCntSupp.Name = "lblCntSupp";
            lblCntSupp.Size = new Size(25, 30);
            lblCntSupp.TabIndex = 7;
            lblCntSupp.Text = "0";
            // 
            // lblSuppAct
            // 
            lblSuppAct.AutoSize = true;
            lblSuppAct.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSuppAct.ForeColor = Color.DimGray;
            lblSuppAct.Location = new Point(36, 45);
            lblSuppAct.Name = "lblSuppAct";
            lblSuppAct.Size = new Size(112, 15);
            lblSuppAct.TabIndex = 6;
            lblSuppAct.Text = "Proveedores activos";
            // 
            // pnlCat
            // 
            pnlCat.BackColor = Color.White;
            pnlCat.Controls.Add(lblCntCat);
            pnlCat.Controls.Add(lblCat);
            pnlCat.Location = new Point(561, 31);
            pnlCat.Name = "pnlCat";
            pnlCat.Size = new Size(177, 69);
            pnlCat.TabIndex = 10;
            // 
            // lblCntCat
            // 
            lblCntCat.AutoSize = true;
            lblCntCat.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCntCat.ForeColor = Color.DarkOrange;
            lblCntCat.Location = new Point(78, 12);
            lblCntCat.Name = "lblCntCat";
            lblCntCat.Size = new Size(25, 30);
            lblCntCat.TabIndex = 7;
            lblCntCat.Text = "0";
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCat.ForeColor = Color.DimGray;
            lblCat.Location = new Point(59, 45);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(63, 15);
            lblCat.TabIndex = 6;
            lblCat.Text = "Categorías";
            // 
            // pnlProdLow
            // 
            pnlProdLow.BackColor = Color.White;
            pnlProdLow.Controls.Add(lblCntLowStock);
            pnlProdLow.Controls.Add(lblLowStock);
            pnlProdLow.Location = new Point(744, 31);
            pnlProdLow.Name = "pnlProdLow";
            pnlProdLow.Size = new Size(177, 69);
            pnlProdLow.TabIndex = 11;
            // 
            // lblCntLowStock
            // 
            lblCntLowStock.AutoSize = true;
            lblCntLowStock.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCntLowStock.ForeColor = Color.Red;
            lblCntLowStock.Location = new Point(78, 12);
            lblCntLowStock.Name = "lblCntLowStock";
            lblCntLowStock.Size = new Size(25, 30);
            lblCntLowStock.TabIndex = 7;
            lblCntLowStock.Text = "0";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLowStock.ForeColor = Color.DimGray;
            lblLowStock.Location = new Point(19, 45);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(141, 15);
            lblLowStock.TabIndex = 6;
            lblLowStock.Text = "Productos con stock bajo";
            // 
            // grpbProducts
            // 
            grpbProducts.Controls.Add(dgvLowStock);
            grpbProducts.Controls.Add(btnGetAllProd);
            grpbProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbProducts.Location = new Point(12, 106);
            grpbProducts.Name = "grpbProducts";
            grpbProducts.Size = new Size(450, 276);
            grpbProducts.TabIndex = 12;
            grpbProducts.TabStop = false;
            grpbProducts.Text = "Productos con menor stock";
            // 
            // btnGetAllProd
            // 
            btnGetAllProd.BackColor = Color.CornflowerBlue;
            btnGetAllProd.Cursor = Cursors.Hand;
            btnGetAllProd.FlatAppearance.BorderSize = 0;
            btnGetAllProd.FlatStyle = FlatStyle.Flat;
            btnGetAllProd.Location = new Point(6, 247);
            btnGetAllProd.Name = "btnGetAllProd";
            btnGetAllProd.Size = new Size(164, 23);
            btnGetAllProd.TabIndex = 0;
            btnGetAllProd.Text = "Ver todos los productos";
            btnGetAllProd.UseVisualStyleBackColor = false;
            // 
            // grpbSuppliers
            // 
            grpbSuppliers.Controls.Add(dgvRecSupp);
            grpbSuppliers.Controls.Add(btnGetAllSupp);
            grpbSuppliers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbSuppliers.Location = new Point(474, 106);
            grpbSuppliers.Name = "grpbSuppliers";
            grpbSuppliers.Size = new Size(450, 276);
            grpbSuppliers.TabIndex = 13;
            grpbSuppliers.TabStop = false;
            grpbSuppliers.Text = "Proveedores registrados recientemente";
            // 
            // btnGetAllSupp
            // 
            btnGetAllSupp.BackColor = Color.CornflowerBlue;
            btnGetAllSupp.Cursor = Cursors.Hand;
            btnGetAllSupp.FlatAppearance.BorderSize = 0;
            btnGetAllSupp.FlatStyle = FlatStyle.Flat;
            btnGetAllSupp.Location = new Point(6, 247);
            btnGetAllSupp.Name = "btnGetAllSupp";
            btnGetAllSupp.Size = new Size(176, 23);
            btnGetAllSupp.TabIndex = 1;
            btnGetAllSupp.Text = "Ver todos los proveedores";
            btnGetAllSupp.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 388);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(912, 169);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos por categoría";
            // 
            // dgvLowStock
            // 
            dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStock.Location = new Point(6, 22);
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.Size = new Size(438, 219);
            dgvLowStock.TabIndex = 1;
            // 
            // dgvRecSupp
            // 
            dgvRecSupp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecSupp.Location = new Point(6, 22);
            dgvRecSupp.Name = "dgvRecSupp";
            dgvRecSupp.Size = new Size(438, 219);
            dgvRecSupp.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 569);
            Controls.Add(grpbSuppliers);
            Controls.Add(groupBox1);
            Controls.Add(pnlProd);
            Controls.Add(grpbProducts);
            Controls.Add(pnlProdLow);
            Controls.Add(pnlCat);
            Controls.Add(pnlSupp);
            Controls.Add(pnlCli);
            Controls.Add(lblDate);
            Controls.Add(lblResumen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            pnlProd.ResumeLayout(false);
            pnlProd.PerformLayout();
            pnlCli.ResumeLayout(false);
            pnlCli.PerformLayout();
            pnlSupp.ResumeLayout(false);
            pnlSupp.PerformLayout();
            pnlCat.ResumeLayout(false);
            pnlCat.PerformLayout();
            pnlProdLow.ResumeLayout(false);
            pnlProdLow.PerformLayout();
            grpbProducts.ResumeLayout(false);
            grpbSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecSupp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblResumen;
        private Label lblDate;
        private Panel pnlProd;
        private Label lblCntProd;
        private Label lblProdReg;
        private Panel pnlCli;
        private Label lblCntCli;
        private Label lblCliReg;
        private Panel pnlSupp;
        private Label lblCntSupp;
        private Label lblSuppAct;
        private Panel pnlCat;
        private Label lblCntCat;
        private Label lblCat;
        private Panel pnlProdLow;
        private Label lblCntLowStock;
        private Label lblLowStock;
        private GroupBox grpbProducts;
        private GroupBox grpbSuppliers;
        private GroupBox groupBox1;
        private Button btnGetAllProd;
        private Button btnGetAllSupp;
        private DataGridView dgvLowStock;
        private DataGridView dgvRecSupp;
    }
}