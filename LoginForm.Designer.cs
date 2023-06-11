namespace GestaoReceitas
{
    partial class LoginForm
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
            txtPassword = new TextBox();
            lblTitulo = new Label();
            lblLogin = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            btnRegisto = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(386, 330);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(223, 23);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(108, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(856, 86);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Receitas de Auguste Gusteau";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(427, 95);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(146, 65);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(428, 229);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(145, 21);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Nome de Utilizador";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(459, 306);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(386, 265);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(223, 23);
            txtUsername.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(460, 371);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegisto
            // 
            btnRegisto.Location = new Point(460, 410);
            btnRegisto.Name = "btnRegisto";
            btnRegisto.Size = new Size(75, 23);
            btnRegisto.TabIndex = 7;
            btnRegisto.Text = "Registo";
            btnRegisto.UseVisualStyleBackColor = true;
            btnRegisto.Click += btnRegisto_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(btnRegisto);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblLogin);
            Controls.Add(lblTitulo);
            Controls.Add(txtPassword);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Receitas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label lblTitulo;
        private Label lblLogin;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Button btnRegisto;
    }
}