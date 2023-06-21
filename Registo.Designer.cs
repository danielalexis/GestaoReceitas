namespace GestaoReceitas
{
    partial class Registo
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
            btnRegisto = new Button();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblLogin = new Label();
            lblTitulo = new Label();
            txtPassword = new TextBox();
            txtNome = new TextBox();
            lblNome = new Label();
            SuspendLayout();
            // 
            // btnRegisto
            // 
            btnRegisto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegisto.Location = new Point(388, 406);
            btnRegisto.Name = "btnRegisto";
            btnRegisto.Size = new Size(223, 46);
            btnRegisto.TabIndex = 14;
            btnRegisto.Text = "Registo";
            btnRegisto.UseVisualStyleBackColor = true;
            btnRegisto.Click += btnRegisto_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(388, 287);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(223, 23);
            txtUsername.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(461, 328);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 16;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(430, 262);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(145, 21);
            lblUsername.TabIndex = 15;
            lblUsername.Text = "Nome de Utilizador";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(408, 100);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(185, 65);
            lblLogin.TabIndex = 13;
            lblLogin.Text = "Registo";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 48F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.Location = new Point(81, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(834, 86);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Receitas de Auguste Gusteau";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(388, 352);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(223, 23);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(387, 226);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(223, 23);
            txtNome.TabIndex = 17;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(471, 200);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 21);
            lblNome.TabIndex = 18;
            lblNome.Text = "Nome";
            // 
            // Registo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 479);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnRegisto);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblLogin);
            Controls.Add(lblTitulo);
            Controls.Add(txtPassword);
            Name = "Registo";
            Text = "hgfd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegisto;
        private TextBox txtUsername;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblLogin;
        private Label lblTitulo;
        private TextBox txtPassword;
        private TextBox txtNome;
        private Label lblNome;
    }
}