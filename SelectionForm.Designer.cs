namespace GestaoReceitas
{
    partial class SelectionForm
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
            btnCriarReceitas = new Button();
            btnVerReceitas = new Button();
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // btnCriarReceitas
            // 
            btnCriarReceitas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCriarReceitas.Image = Properties.Resources.Pencil;
            btnCriarReceitas.Location = new Point(178, 134);
            btnCriarReceitas.Name = "btnCriarReceitas";
            btnCriarReceitas.Size = new Size(267, 264);
            btnCriarReceitas.TabIndex = 0;
            btnCriarReceitas.Text = "Criar Receitas";
            btnCriarReceitas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCriarReceitas.UseVisualStyleBackColor = true;
            btnCriarReceitas.Click += btnCriarReceitas_Click;
            // 
            // btnVerReceitas
            // 
            btnVerReceitas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerReceitas.Image = Properties.Resources.Book;
            btnVerReceitas.Location = new Point(541, 134);
            btnVerReceitas.Name = "btnVerReceitas";
            btnVerReceitas.Size = new Size(267, 264);
            btnVerReceitas.TabIndex = 2;
            btnVerReceitas.Text = "Ver Receitas";
            btnVerReceitas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVerReceitas.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(192, 28);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(266, 65);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Bem vindo ";
            // 
            // SelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 482);
            Controls.Add(lblWelcome);
            Controls.Add(btnVerReceitas);
            Controls.Add(btnCriarReceitas);
            Name = "SelectionForm";
            Text = "Dashboard";
            Load += SelectionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCriarReceitas;
        private Button btnVerReceitas;
        private Label lblWelcome;
    }
}