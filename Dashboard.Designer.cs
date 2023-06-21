namespace GestaoReceitas
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
            lstViewReceitas = new ListView();
            receitaNome = new ColumnHeader();
            categoria = new ColumnHeader();
            dificuldade = new ColumnHeader();
            tempoPreparacao = new ColumnHeader();
            descricao = new ColumnHeader();
            lblBemVindo = new Label();
            btnNovaReceita = new Button();
            button1 = new Button();
            picUserMenu = new PictureBox();
            id = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)picUserMenu).BeginInit();
            SuspendLayout();
            // 
            // lstViewReceitas
            // 
            lstViewReceitas.Columns.AddRange(new ColumnHeader[] { id, receitaNome, categoria, dificuldade, tempoPreparacao, descricao });
            lstViewReceitas.FullRowSelect = true;
            lstViewReceitas.Location = new Point(12, 75);
            lstViewReceitas.Name = "lstViewReceitas";
            lstViewReceitas.Size = new Size(960, 400);
            lstViewReceitas.TabIndex = 0;
            lstViewReceitas.UseCompatibleStateImageBehavior = false;
            lstViewReceitas.View = View.Details;
            lstViewReceitas.ColumnClick += lstViewReceitas_ColumnClick;
            lstViewReceitas.MouseDoubleClick += lstViewReceitas_MouseDoubleClick;
            // 
            // receitaNome
            // 
            receitaNome.Text = "Nome";
            receitaNome.Width = 45;
            // 
            // categoria
            // 
            categoria.Text = "Categoria";
            categoria.Width = 63;
            // 
            // dificuldade
            // 
            dificuldade.Text = "Dificuldade";
            dificuldade.Width = 72;
            // 
            // tempoPreparacao
            // 
            tempoPreparacao.Text = "Tempo de Preparação";
            tempoPreparacao.Width = 127;
            // 
            // descricao
            // 
            descricao.Text = "Descrição";
            descricao.Width = 624;
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBemVindo.Location = new Point(12, 34);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(124, 30);
            lblBemVindo.TabIndex = 1;
            lblBemVindo.Text = "Bem vindo ";
            // 
            // btnNovaReceita
            // 
            btnNovaReceita.Location = new Point(691, 481);
            btnNovaReceita.Name = "btnNovaReceita";
            btnNovaReceita.Size = new Size(98, 30);
            btnNovaReceita.TabIndex = 2;
            btnNovaReceita.Text = "Criar Receita";
            btnNovaReceita.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(795, 481);
            button1.Name = "button1";
            button1.Size = new Size(177, 30);
            button1.TabIndex = 3;
            button1.Text = "Apagar receita selecionada";
            button1.UseVisualStyleBackColor = true;
            // 
            // picUserMenu
            // 
            picUserMenu.Image = Properties.Resources.User;
            picUserMenu.Location = new Point(915, 12);
            picUserMenu.Name = "picUserMenu";
            picUserMenu.Size = new Size(57, 52);
            picUserMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            picUserMenu.TabIndex = 4;
            picUserMenu.TabStop = false;
            picUserMenu.Click += picUserMenu_Click;
            // 
            // id
            // 
            id.Text = "ID";
            id.Width = 25;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 523);
            Controls.Add(picUserMenu);
            Controls.Add(button1);
            Controls.Add(btnNovaReceita);
            Controls.Add(lblBemVindo);
            Controls.Add(lstViewReceitas);
            Name = "Dashboard";
            Text = "Receitas";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)picUserMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstViewReceitas;
        private ColumnHeader receitaNome;
        private ColumnHeader tempoPreparacao;
        private ColumnHeader descricao;
        private ColumnHeader dificuldade;
        private ColumnHeader categoria;
        private Label lblBemVindo;
        private Button btnNovaReceita;
        private Button button1;
        private PictureBox picUserMenu;
        private ColumnHeader id;
    }
}