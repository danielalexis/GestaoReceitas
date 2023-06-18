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
            SuspendLayout();
            // 
            // lstViewReceitas
            // 
            lstViewReceitas.Columns.AddRange(new ColumnHeader[] { receitaNome, categoria, dificuldade, tempoPreparacao, descricao });
            lstViewReceitas.FullRowSelect = true;
            lstViewReceitas.Location = new Point(12, 56);
            lstViewReceitas.Name = "lstViewReceitas";
            lstViewReceitas.Size = new Size(960, 435);
            lstViewReceitas.TabIndex = 0;
            lstViewReceitas.UseCompatibleStateImageBehavior = false;
            lstViewReceitas.View = View.Details;
            lstViewReceitas.ColumnClick += lstViewReceitas_ColumnClick;
            lstViewReceitas.MouseDoubleClick += lstViewReceitas_MouseDoubleClick;
            // 
            // receitaNome
            // 
            receitaNome.Text = "Nome";
            receitaNome.Width = 248;
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
            descricao.Width = 393;
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBemVindo.Location = new Point(12, 20);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(124, 30);
            lblBemVindo.TabIndex = 1;
            lblBemVindo.Text = "Bem vindo ";
            // 
            // btnNovaReceita
            // 
            btnNovaReceita.Location = new Point(691, 20);
            btnNovaReceita.Name = "btnNovaReceita";
            btnNovaReceita.Size = new Size(98, 30);
            btnNovaReceita.TabIndex = 2;
            btnNovaReceita.Text = "Criar Receita";
            btnNovaReceita.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(795, 20);
            button1.Name = "button1";
            button1.Size = new Size(177, 30);
            button1.TabIndex = 3;
            button1.Text = "Apagar receita selecionada";
            button1.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 503);
            Controls.Add(button1);
            Controls.Add(btnNovaReceita);
            Controls.Add(lblBemVindo);
            Controls.Add(lstViewReceitas);
            Name = "Dashboard";
            Text = "Receitas";
            Load += Dashboard_Load;
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
    }
}