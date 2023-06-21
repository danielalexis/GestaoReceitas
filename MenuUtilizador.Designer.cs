namespace GestaoReceitas
{
    partial class MenuUtilizador
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
            lblNome = new Label();
            lblUsername = new Label();
            lblNewPassword = new Label();
            lblId = new Label();
            txtId = new TextBox();
            txtUsername = new TextBox();
            textBox3 = new TextBox();
            txtNome = new TextBox();
            btnGravar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(115, 75);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(12, 118);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(160, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Nome de Utilizador";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewPassword.Location = new Point(45, 169);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(127, 21);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "Nova Password";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(147, 36);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 21);
            lblId.TabIndex = 3;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(178, 38);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(182, 23);
            txtId.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(178, 120);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(182, 23);
            txtUsername.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(178, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 23);
            textBox3.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(178, 77);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(182, 23);
            txtNome.TabIndex = 7;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(178, 217);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(182, 23);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // MenuUtilizador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 303);
            Controls.Add(btnGravar);
            Controls.Add(txtNome);
            Controls.Add(textBox3);
            Controls.Add(txtUsername);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(lblNewPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblNome);
            Name = "MenuUtilizador";
            Text = "Utilizador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblUsername;
        private Label lblNewPassword;
        private Label lblId;
        private TextBox txtId;
        private TextBox txtUsername;
        private TextBox textBox3;
        private TextBox txtNome;
        private Button btnGravar;
    }
}