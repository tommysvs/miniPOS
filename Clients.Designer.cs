namespace miniPOS
{
    partial class Clients
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
            grpbCliList = new GroupBox();
            btnExport = new Button();
            lblCliCnt = new Label();
            btnFind = new Button();
            txtFind = new TextBox();
            grpbCliData = new GroupBox();
            lblCliAdd = new Label();
            txtCliAdd = new TextBox();
            lblCliTel = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            lblCliEmail = new Label();
            txtCliEmail = new TextBox();
            lblCliName = new Label();
            txtCliName = new TextBox();
            lblCliId = new Label();
            txtCliId = new TextBox();
            txtCliTel = new TextBox();
            grpbCliList.SuspendLayout();
            grpbCliData.SuspendLayout();
            SuspendLayout();
            // 
            // grpbCliList
            // 
            grpbCliList.Controls.Add(btnExport);
            grpbCliList.Controls.Add(lblCliCnt);
            grpbCliList.Controls.Add(btnFind);
            grpbCliList.Controls.Add(txtFind);
            grpbCliList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbCliList.Location = new Point(341, 12);
            grpbCliList.Name = "grpbCliList";
            grpbCliList.Size = new Size(583, 545);
            grpbCliList.TabIndex = 5;
            grpbCliList.TabStop = false;
            grpbCliList.Text = "Listado de clientes";
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
            btnExport.TabIndex = 13;
            btnExport.Text = "Exportar a Excel";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // lblCliCnt
            // 
            lblCliCnt.AutoSize = true;
            lblCliCnt.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliCnt.ForeColor = SystemColors.ControlDarkDark;
            lblCliCnt.Location = new Point(6, 526);
            lblCliCnt.Name = "lblCliCnt";
            lblCliCnt.Size = new Size(114, 13);
            lblCliCnt.TabIndex = 10;
            lblCliCnt.Text = "- clientes registrados";
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
            btnFind.TabIndex = 9;
            btnFind.Text = "Buscar";
            btnFind.UseVisualStyleBackColor = false;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(6, 22);
            txtFind.Name = "txtFind";
            txtFind.PlaceholderText = "Buscar producto en tiempo real";
            txtFind.Size = new Size(476, 23);
            txtFind.TabIndex = 0;
            // 
            // grpbCliData
            // 
            grpbCliData.Controls.Add(txtCliTel);
            grpbCliData.Controls.Add(lblCliAdd);
            grpbCliData.Controls.Add(txtCliAdd);
            grpbCliData.Controls.Add(lblCliTel);
            grpbCliData.Controls.Add(btnDelete);
            grpbCliData.Controls.Add(btnEdit);
            grpbCliData.Controls.Add(btnSave);
            grpbCliData.Controls.Add(lblCliEmail);
            grpbCliData.Controls.Add(txtCliEmail);
            grpbCliData.Controls.Add(lblCliName);
            grpbCliData.Controls.Add(txtCliName);
            grpbCliData.Controls.Add(lblCliId);
            grpbCliData.Controls.Add(txtCliId);
            grpbCliData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbCliData.Location = new Point(12, 12);
            grpbCliData.Name = "grpbCliData";
            grpbCliData.Size = new Size(323, 545);
            grpbCliData.TabIndex = 4;
            grpbCliData.TabStop = false;
            grpbCliData.Text = "Datos del cliente";
            // 
            // lblCliAdd
            // 
            lblCliAdd.AutoSize = true;
            lblCliAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliAdd.Location = new Point(6, 282);
            lblCliAdd.Name = "lblCliAdd";
            lblCliAdd.Size = new Size(68, 15);
            lblCliAdd.TabIndex = 15;
            lblCliAdd.Text = "Dirección: *";
            // 
            // txtCliAdd
            // 
            txtCliAdd.Location = new Point(6, 300);
            txtCliAdd.Name = "txtCliAdd";
            txtCliAdd.Size = new Size(311, 23);
            txtCliAdd.TabIndex = 14;
            // 
            // lblCliTel
            // 
            lblCliTel.AutoSize = true;
            lblCliTel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliTel.Location = new Point(6, 154);
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
            btnDelete.Location = new Point(197, 511);
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
            btnEdit.Location = new Point(102, 511);
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
            btnSave.Location = new Point(7, 511);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 28);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblCliEmail
            // 
            lblCliEmail.AutoSize = true;
            lblCliEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliEmail.Location = new Point(6, 217);
            lblCliEmail.Name = "lblCliEmail";
            lblCliEmail.Size = new Size(116, 15);
            lblCliEmail.TabIndex = 5;
            lblCliEmail.Text = "Correo electrónico: *";
            // 
            // txtCliEmail
            // 
            txtCliEmail.Location = new Point(6, 235);
            txtCliEmail.Name = "txtCliEmail";
            txtCliEmail.Size = new Size(311, 23);
            txtCliEmail.TabIndex = 4;
            // 
            // lblCliName
            // 
            lblCliName.AutoSize = true;
            lblCliName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliName.Location = new Point(6, 94);
            lblCliName.Name = "lblCliName";
            lblCliName.Size = new Size(116, 15);
            lblCliName.TabIndex = 3;
            lblCliName.Text = "Nombre completo: *";
            // 
            // txtCliName
            // 
            txtCliName.Location = new Point(6, 112);
            txtCliName.Name = "txtCliName";
            txtCliName.Size = new Size(311, 23);
            txtCliName.TabIndex = 2;
            // 
            // lblCliId
            // 
            lblCliId.AutoSize = true;
            lblCliId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliId.Location = new Point(6, 35);
            lblCliId.Name = "lblCliId";
            lblCliId.Size = new Size(61, 15);
            lblCliId.TabIndex = 1;
            lblCliId.Text = "ID Cliente:";
            // 
            // txtCliId
            // 
            txtCliId.Enabled = false;
            txtCliId.Location = new Point(6, 53);
            txtCliId.Name = "txtCliId";
            txtCliId.PlaceholderText = "(Automático)";
            txtCliId.Size = new Size(311, 23);
            txtCliId.TabIndex = 0;
            // 
            // txtCliTel
            // 
            txtCliTel.Location = new Point(7, 172);
            txtCliTel.Name = "txtCliTel";
            txtCliTel.Size = new Size(310, 23);
            txtCliTel.TabIndex = 16;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 569);
            Controls.Add(grpbCliList);
            Controls.Add(grpbCliData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clients";
            Text = "Clients";
            grpbCliList.ResumeLayout(false);
            grpbCliList.PerformLayout();
            grpbCliData.ResumeLayout(false);
            grpbCliData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbCliList;
        private Button btnExport;
        private Label lblCliCnt;
        private Button btnFind;
        private TextBox txtFind;
        private GroupBox grpbCliData;
        private Label lblCliAdd;
        private TextBox txtCliAdd;
        private Label lblCliTel;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private Label lblCliEmail;
        private TextBox txtCliEmail;
        private Label lblCliName;
        private TextBox txtCliName;
        private Label lblCliId;
        private TextBox txtCliId;
        private TextBox txtCliTel;
    }
}