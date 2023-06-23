namespace GestaoReceitas
{
    partial class Receita
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
            lblId = new Label();
            lblNome = new Label();
            lblCategory = new Label();
            lblDificuldade = new Label();
            lblPorcoes = new Label();
            lblTempo = new Label();
            lblDescricao = new Label();
            lblPreparacao = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            cmbDificuldade = new ComboBox();
            cmbCategoria = new ComboBox();
            txtPorcoes = new TextBox();
            numTempo = new NumericUpDown();
            lblMinutos = new Label();
            txtDescricao = new TextBox();
            txtPreparaco = new TextBox();
            lstViewIngredientes = new ListView();
            nome = new ColumnHeader();
            Quantidade = new ColumnHeader();
            Unidade = new ColumnHeader();
            lblNomeIngrediente = new Label();
            lblQuantidadeIngrediente = new Label();
            lblUnidade = new Label();
            txtNomeIngrediente = new TextBox();
            txtQuantidadeIngrediente = new TextBox();
            cmbUnidadeIngrediente = new ComboBox();
            lblIngredientes = new Label();
            btnAdiconarIngrediente = new Button();
            btnEliminarIngrediente = new Button();
            btnGravarReceita = new Button();
            ((System.ComponentModel.ISupportInitialize)numTempo).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(72, 23);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 21);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(42, 56);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 21);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.Location = new Point(15, 85);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 21);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Categoria";
            // 
            // lblDificuldade
            // 
            lblDificuldade.AutoSize = true;
            lblDificuldade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDificuldade.Location = new Point(0, 114);
            lblDificuldade.Name = "lblDificuldade";
            lblDificuldade.Size = new Size(99, 21);
            lblDificuldade.TabIndex = 4;
            lblDificuldade.Text = "Dificuldade";
            // 
            // lblPorcoes
            // 
            lblPorcoes.AutoSize = true;
            lblPorcoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPorcoes.Location = new Point(29, 139);
            lblPorcoes.Name = "lblPorcoes";
            lblPorcoes.Size = new Size(70, 21);
            lblPorcoes.TabIndex = 5;
            lblPorcoes.Text = "Porções";
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTempo.Location = new Point(37, 172);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(62, 21);
            lblTempo.TabIndex = 6;
            lblTempo.Text = "Tempo";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescricao.Location = new Point(15, 202);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(84, 21);
            lblDescricao.TabIndex = 7;
            lblDescricao.Text = "Descrição";
            // 
            // lblPreparacao
            // 
            lblPreparacao.AutoSize = true;
            lblPreparacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPreparacao.Location = new Point(3, 243);
            lblPreparacao.Name = "lblPreparacao";
            lblPreparacao.Size = new Size(96, 21);
            lblPreparacao.TabIndex = 8;
            lblPreparacao.Text = "Preparação";
            // 
            // txtId
            // 
            txtId.Location = new Point(105, 25);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(105, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(299, 23);
            txtNome.TabIndex = 2;
            // 
            // cmbDificuldade
            // 
            cmbDificuldade.FormattingEnabled = true;
            cmbDificuldade.Items.AddRange(new object[] { "Fácil", "Médio", "Dificil", "Muito Díficil" });
            cmbDificuldade.Location = new Point(105, 112);
            cmbDificuldade.Name = "cmbDificuldade";
            cmbDificuldade.Size = new Size(143, 23);
            cmbDificuldade.TabIndex = 9;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Carne", "Porco", "Vaca", "Frango", "Ovelha", "Peixe", "Sushi", "Arroz", "Vegatais", "Outros" });
            cmbCategoria.Location = new Point(105, 83);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(143, 23);
            cmbCategoria.TabIndex = 10;
            // 
            // txtPorcoes
            // 
            txtPorcoes.Location = new Point(105, 141);
            txtPorcoes.Name = "txtPorcoes";
            txtPorcoes.Size = new Size(143, 23);
            txtPorcoes.TabIndex = 11;
            // 
            // numTempo
            // 
            numTempo.Location = new Point(105, 175);
            numTempo.Name = "numTempo";
            numTempo.Size = new Size(143, 23);
            numTempo.TabIndex = 12;
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Location = new Point(254, 178);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(51, 15);
            lblMinutos.TabIndex = 13;
            lblMinutos.Text = "minutos";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(105, 204);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(299, 23);
            txtDescricao.TabIndex = 14;
            // 
            // txtPreparaco
            // 
            txtPreparaco.Location = new Point(105, 241);
            txtPreparaco.Multiline = true;
            txtPreparaco.Name = "txtPreparaco";
            txtPreparaco.Size = new Size(299, 187);
            txtPreparaco.TabIndex = 15;
            // 
            // lstViewIngredientes
            // 
            lstViewIngredientes.Columns.AddRange(new ColumnHeader[] { nome, Quantidade, Unidade });
            lstViewIngredientes.FullRowSelect = true;
            lstViewIngredientes.Location = new Point(485, 241);
            lstViewIngredientes.Name = "lstViewIngredientes";
            lstViewIngredientes.Size = new Size(408, 187);
            lstViewIngredientes.TabIndex = 17;
            lstViewIngredientes.UseCompatibleStateImageBehavior = false;
            lstViewIngredientes.View = View.Details;
            // 
            // nome
            // 
            nome.Text = "Nome";
            nome.Width = 45;
            // 
            // Quantidade
            // 
            Quantidade.Text = "Quantidade";
            Quantidade.Width = 74;
            // 
            // Unidade
            // 
            Unidade.Text = "Unidade";
            Unidade.Width = 285;
            // 
            // lblNomeIngrediente
            // 
            lblNomeIngrediente.AutoSize = true;
            lblNomeIngrediente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeIngrediente.Location = new Point(528, 71);
            lblNomeIngrediente.Name = "lblNomeIngrediente";
            lblNomeIngrediente.Size = new Size(57, 21);
            lblNomeIngrediente.TabIndex = 18;
            lblNomeIngrediente.Text = "Nome";
            // 
            // lblQuantidadeIngrediente
            // 
            lblQuantidadeIngrediente.AutoSize = true;
            lblQuantidadeIngrediente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantidadeIngrediente.Location = new Point(485, 98);
            lblQuantidadeIngrediente.Name = "lblQuantidadeIngrediente";
            lblQuantidadeIngrediente.Size = new Size(100, 21);
            lblQuantidadeIngrediente.TabIndex = 19;
            lblQuantidadeIngrediente.Text = "Quantidade";
            // 
            // lblUnidade
            // 
            lblUnidade.AutoSize = true;
            lblUnidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnidade.Location = new Point(510, 127);
            lblUnidade.Name = "lblUnidade";
            lblUnidade.Size = new Size(75, 21);
            lblUnidade.TabIndex = 20;
            lblUnidade.Text = "Unidade";
            // 
            // txtNomeIngrediente
            // 
            txtNomeIngrediente.Location = new Point(591, 69);
            txtNomeIngrediente.Name = "txtNomeIngrediente";
            txtNomeIngrediente.Size = new Size(232, 23);
            txtNomeIngrediente.TabIndex = 22;
            // 
            // txtQuantidadeIngrediente
            // 
            txtQuantidadeIngrediente.Location = new Point(591, 98);
            txtQuantidadeIngrediente.Name = "txtQuantidadeIngrediente";
            txtQuantidadeIngrediente.Size = new Size(97, 23);
            txtQuantidadeIngrediente.TabIndex = 23;
            // 
            // cmbUnidadeIngrediente
            // 
            cmbUnidadeIngrediente.FormattingEnabled = true;
            cmbUnidadeIngrediente.Items.AddRange(new object[] { "Gramas", "Kilogramas", "Miligramas", "Litros", "Mililitros", "Colheres de Chá", "Colheres de Sopa", "Xícaras", "Unidades" });
            cmbUnidadeIngrediente.Location = new Point(591, 127);
            cmbUnidadeIngrediente.Name = "cmbUnidadeIngrediente";
            cmbUnidadeIngrediente.Size = new Size(165, 23);
            cmbUnidadeIngrediente.TabIndex = 24;
            // 
            // lblIngredientes
            // 
            lblIngredientes.AutoSize = true;
            lblIngredientes.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngredientes.Location = new Point(485, 25);
            lblIngredientes.Name = "lblIngredientes";
            lblIngredientes.Size = new Size(158, 32);
            lblIngredientes.TabIndex = 25;
            lblIngredientes.Text = "Ingredientes";
            // 
            // btnAdiconarIngrediente
            // 
            btnAdiconarIngrediente.Location = new Point(485, 434);
            btnAdiconarIngrediente.Name = "btnAdiconarIngrediente";
            btnAdiconarIngrediente.Size = new Size(138, 27);
            btnAdiconarIngrediente.TabIndex = 26;
            btnAdiconarIngrediente.Text = "Adicionar Ingrediente";
            btnAdiconarIngrediente.UseVisualStyleBackColor = true;
            btnAdiconarIngrediente.Click += btnAdiconarIngrediente_Click;
            // 
            // btnEliminarIngrediente
            // 
            btnEliminarIngrediente.Location = new Point(629, 434);
            btnEliminarIngrediente.Name = "btnEliminarIngrediente";
            btnEliminarIngrediente.Size = new Size(264, 27);
            btnEliminarIngrediente.TabIndex = 27;
            btnEliminarIngrediente.Text = "Eliminar Ingrediente Selecionado";
            btnEliminarIngrediente.UseVisualStyleBackColor = true;
            btnEliminarIngrediente.Click += btnEliminarIngrediente_Click;
            // 
            // btnGravarReceita
            // 
            btnGravarReceita.Location = new Point(105, 436);
            btnGravarReceita.Name = "btnGravarReceita";
            btnGravarReceita.Size = new Size(75, 23);
            btnGravarReceita.TabIndex = 28;
            btnGravarReceita.Text = "Gravar Receita";
            btnGravarReceita.UseVisualStyleBackColor = true;
            // 
            // Receita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 473);
            Controls.Add(btnGravarReceita);
            Controls.Add(btnEliminarIngrediente);
            Controls.Add(btnAdiconarIngrediente);
            Controls.Add(lblIngredientes);
            Controls.Add(cmbUnidadeIngrediente);
            Controls.Add(txtQuantidadeIngrediente);
            Controls.Add(txtNomeIngrediente);
            Controls.Add(lblUnidade);
            Controls.Add(lblQuantidadeIngrediente);
            Controls.Add(lblNomeIngrediente);
            Controls.Add(lstViewIngredientes);
            Controls.Add(txtPreparaco);
            Controls.Add(txtDescricao);
            Controls.Add(lblMinutos);
            Controls.Add(numTempo);
            Controls.Add(txtPorcoes);
            Controls.Add(cmbCategoria);
            Controls.Add(cmbDificuldade);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(lblPreparacao);
            Controls.Add(lblDescricao);
            Controls.Add(lblTempo);
            Controls.Add(lblPorcoes);
            Controls.Add(lblDificuldade);
            Controls.Add(lblCategory);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Name = "Receita";
            Text = "Receitas";
            ((System.ComponentModel.ISupportInitialize)numTempo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNome;
        private Label lblCategory;
        private Label lblDificuldade;
        private Label lblPorcoes;
        private Label lblTempo;
        private Label lblDescricao;
        private Label lblPreparacao;
        private TextBox txtId;
        private TextBox txtNome;
        private ComboBox cmbDificuldade;
        private ComboBox cmbCategoria;
        private TextBox txtPorcoes;
        private NumericUpDown numTempo;
        private Label lblMinutos;
        private TextBox txtDescricao;
        private TextBox txtPreparaco;
        private ListView lstViewIngredientes;
        private ColumnHeader nome;
        private ColumnHeader Quantidade;
        private ColumnHeader Unidade;
        private Label lblNomeIngrediente;
        private Label lblQuantidadeIngrediente;
        private Label lblUnidade;
        private TextBox txtNomeIngrediente;
        private TextBox txtQuantidadeIngrediente;
        private ComboBox cmbUnidadeIngrediente;
        private Label lblIngredientes;
        private Button btnAdiconarIngrediente;
        private Button btnEliminarIngrediente;
        private Button btnGravarReceita;
    }
}