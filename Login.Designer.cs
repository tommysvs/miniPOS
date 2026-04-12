namespace miniPOS
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            loginPanel = new Panel();
            lblVersion = new Label();
            btnLogin = new Button();
            label1 = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            lblTitle = new Label();
            pbxLogo = new PictureBox();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.AliceBlue;
            loginPanel.Controls.Add(lblVersion);
            loginPanel.Controls.Add(btnLogin);
            loginPanel.Controls.Add(label1);
            loginPanel.Controls.Add(lblPassword);
            loginPanel.Controls.Add(txtPassword);
            loginPanel.Controls.Add(txtUser);
            loginPanel.Controls.Add(lblTitle);
            loginPanel.Controls.Add(pbxLogo);
            loginPanel.Location = new Point(247, 23);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(311, 404);
            loginPanel.TabIndex = 0;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVersion.ForeColor = SystemColors.AppWorkspace;
            lblVersion.Location = new Point(98, 378);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(119, 13);
            lblVersion.TabIndex = 7;
            lblVersion.Text = "V1.0.0 - MiniPOS 2026";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(102, 294);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 27);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 161);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 5;
            label1.Text = "Usuario";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(71, 215);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(71, 233);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(171, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(71, 179);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(171, 23);
            txtUser.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(90, 95);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(127, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "MiniPOS";
            // 
            // pbxLogo
            // 
            pbxLogo.Image = Properties.Resources.logo;
            pbxLogo.Location = new Point(117, 22);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(70, 70);
            pbxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxLogo.TabIndex = 0;
            pbxLogo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(820, 450);
            Controls.Add(loginPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(836, 489);
            MinimumSize = new Size(836, 489);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniPOS - Iniciar sesión";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private PictureBox pbxLogo;
        private Label lblTitle;
        private TextBox txtPassword;
        private TextBox txtUser;
        private Label label1;
        private Label lblPassword;
        private Button btnLogin;
        private Label lblVersion;
    }
}
