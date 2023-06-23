namespace GestaoReceitas
{
    partial class VerReceita
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
            lblId.Location = new Point(82, 31);
            lblId.Name = "lblId";
            lblId.Size = new Size(33, 28);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(48, 75);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(69, 28);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.Location = new Point(17, 113);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(103, 28);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Categoria";
            // 
            // lblDificuldade
            // 
            lblDificuldade.AutoSize = true;
            lblDificuldade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDificuldade.Location = new Point(0, 152);
            lblDificuldade.Name = "lblDificuldade";
            lblDificuldade.Size = new Size(121, 28);
            lblDificuldade.TabIndex = 4;
            lblDificuldade.Text = "Dificuldade";
            // 
            // lblPorcoes
            // 
            lblPorcoes.AutoSize = true;
            lblPorcoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPorcoes.Location = new Point(33, 185);
            lblPorcoes.Name = "lblPorcoes";
            lblPorcoes.Size = new Size(85, 28);
            lblPorcoes.TabIndex = 5;
            lblPorcoes.Text = "Porções";
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTempo.Location = new Point(42, 229);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(75, 28);
            lblTempo.TabIndex = 6;
            lblTempo.Text = "Tempo";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescricao.Location = new Point(17, 269);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(104, 28);
            lblDescricao.TabIndex = 7;
            lblDescricao.Text = "Descrição";
            // 
            // lblPreparacao
            // 
            lblPreparacao.AutoSize = true;
            lblPreparacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPreparacao.Location = new Point(3, 324);
            lblPreparacao.Name = "lblPreparacao";
            lblPreparacao.Size = new Size(118, 28);
            lblPreparacao.TabIndex = 8;
            lblPreparacao.Text = "Preparação";
            // 
            // txtId
            // 
            txtId.Location = new Point(120, 33);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(120, 72);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(341, 27);
            txtNome.TabIndex = 2;
            // 
            // cmbDificuldade
            // 
            cmbDificuldade.FormattingEnabled = true;
            cmbDificuldade.Items.AddRange(new object[] { "Fácil", "Médio", "Dificil", "Muito Díficil" });
            cmbDificuldade.Location = new Point(120, 149);
            cmbDificuldade.Margin = new Padding(3, 4, 3, 4);
            cmbDificuldade.Name = "cmbDificuldade";
            cmbDificuldade.Size = new Size(163, 28);
            cmbDificuldade.TabIndex = 9;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Carne", "Porco", "Vaca", "Frango", "Ovelha", "Peixe", "Sushi", "Arroz", "Vegatais", "Outros" });
            cmbCategoria.Location = new Point(120, 111);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(163, 28);
            cmbCategoria.TabIndex = 10;
            // 
            // txtPorcoes
            // 
            txtPorcoes.Location = new Point(120, 188);
            txtPorcoes.Margin = new Padding(3, 4, 3, 4);
            txtPorcoes.Name = "txtPorcoes";
            txtPorcoes.Size = new Size(163, 27);
            txtPorcoes.TabIndex = 11;
            // 
            // numTempo
            // 
            numTempo.Location = new Point(120, 233);
            numTempo.Margin = new Padding(3, 4, 3, 4);
            numTempo.Name = "numTempo";
            numTempo.Size = new Size(163, 27);
            numTempo.TabIndex = 12;
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Location = new Point(290, 237);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(62, 20);
            lblMinutos.TabIndex = 13;
            lblMinutos.Text = "minutos";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(120, 272);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(341, 27);
            txtDescricao.TabIndex = 14;
            // 
            // txtPreparaco
            // 
            txtPreparaco.Location = new Point(120, 321);
            txtPreparaco.Margin = new Padding(3, 4, 3, 4);
            txtPreparaco.Multiline = true;
            txtPreparaco.Name = "txtPreparaco";
            txtPreparaco.Size = new Size(341, 248);
            txtPreparaco.TabIndex = 15;
            // 
            // lstViewIngredientes
            // 
            lstViewIngredientes.Columns.AddRange(new ColumnHeader[] { nome, Quantidade, Unidade });
            lstViewIngredientes.FullRowSelect = true;
            lstViewIngredientes.Location = new Point(554, 321);
            lstViewIngredientes.Margin = new Padding(3, 4, 3, 4);
            lstViewIngredientes.Name = "lstViewIngredientes";
            lstViewIngredientes.Size = new Size(466, 248);
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
            lblNomeIngrediente.Location = new Point(603, 95);
            lblNomeIngrediente.Name = "lblNomeIngrediente";
            lblNomeIngrediente.Size = new Size(69, 28);
            lblNomeIngrediente.TabIndex = 18;
            lblNomeIngrediente.Text = "Nome";
            // 
            // lblQuantidadeIngrediente
            // 
            lblQuantidadeIngrediente.AutoSize = true;
            lblQuantidadeIngrediente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantidadeIngrediente.Location = new Point(554, 131);
            lblQuantidadeIngrediente.Name = "lblQuantidadeIngrediente";
            lblQuantidadeIngrediente.Size = new Size(122, 28);
            lblQuantidadeIngrediente.TabIndex = 19;
            lblQuantidadeIngrediente.Text = "Quantidade";
            // 
            // lblUnidade
            // 
            lblUnidade.AutoSize = true;
            lblUnidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnidade.Location = new Point(583, 169);
            lblUnidade.Name = "lblUnidade";
            lblUnidade.Size = new Size(90, 28);
            lblUnidade.TabIndex = 20;
            lblUnidade.Text = "Unidade";
            // 
            // txtNomeIngrediente
            // 
            txtNomeIngrediente.Location = new Point(675, 92);
            txtNomeIngrediente.Margin = new Padding(3, 4, 3, 4);
            txtNomeIngrediente.Name = "txtNomeIngrediente";
            txtNomeIngrediente.Size = new Size(265, 27);
            txtNomeIngrediente.TabIndex = 22;
            // 
            // txtQuantidadeIngrediente
            // 
            txtQuantidadeIngrediente.Location = new Point(675, 131);
            txtQuantidadeIngrediente.Margin = new Padding(3, 4, 3, 4);
            txtQuantidadeIngrediente.Name = "txtQuantidadeIngrediente";
            txtQuantidadeIngrediente.Size = new Size(110, 27);
            txtQuantidadeIngrediente.TabIndex = 23;
            // 
            // cmbUnidadeIngrediente
            // 
            cmbUnidadeIngrediente.FormattingEnabled = true;
            cmbUnidadeIngrediente.Items.AddRange(new object[] { "Gramas", "Kilogramas", "Miligramas", "Litros", "Mililitros", "Colheres de Chá", "Colheres de Sopa", "Xícaras", "Unidades" });
            cmbUnidadeIngrediente.Location = new Point(675, 169);
            cmbUnidadeIngrediente.Margin = new Padding(3, 4, 3, 4);
            cmbUnidadeIngrediente.Name = "cmbUnidadeIngrediente";
            cmbUnidadeIngrediente.Size = new Size(188, 28);
            cmbUnidadeIngrediente.TabIndex = 24;
            // 
            // lblIngredientes
            // 
            lblIngredientes.AutoSize = true;
            lblIngredientes.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngredientes.Location = new Point(554, 33);
            lblIngredientes.Name = "lblIngredientes";
            lblIngredientes.Size = new Size(196, 41);
            lblIngredientes.TabIndex = 25;
            lblIngredientes.Text = "Ingredientes";
            // 
            // btnAdiconarIngrediente
            // 
            btnAdiconarIngrediente.Location = new Point(554, 579);
            btnAdiconarIngrediente.Margin = new Padding(3, 4, 3, 4);
            btnAdiconarIngrediente.Name = "btnAdiconarIngrediente";
            btnAdiconarIngrediente.Size = new Size(158, 36);
            btnAdiconarIngrediente.TabIndex = 26;
            btnAdiconarIngrediente.Text = "Adicionar Ingrediente";
            btnAdiconarIngrediente.UseVisualStyleBackColor = true;
            btnAdiconarIngrediente.Click += btnAdiconarIngrediente_Click;
            // 
            // btnEliminarIngrediente
            // 
            btnEliminarIngrediente.Location = new Point(719, 579);
            btnEliminarIngrediente.Margin = new Padding(3, 4, 3, 4);
            btnEliminarIngrediente.Name = "btnEliminarIngrediente";
            btnEliminarIngrediente.Size = new Size(302, 36);
            btnEliminarIngrediente.TabIndex = 27;
            btnEliminarIngrediente.Text = "Eliminar Ingrediente Selecionado";
            btnEliminarIngrediente.UseVisualStyleBackColor = true;
            btnEliminarIngrediente.Click += btnEliminarIngrediente_Click;
            // 
            // btnGravarReceita
            // 
            btnGravarReceita.Location = new Point(120, 581);
            btnGravarReceita.Margin = new Padding(3, 4, 3, 4);
            btnGravarReceita.Name = "btnGravarReceita";
            btnGravarReceita.Size = new Size(86, 31);
            btnGravarReceita.TabIndex = 28;
            btnGravarReceita.Text = "Gravar Receita";
            btnGravarReceita.UseVisualStyleBackColor = true;
            btnGravarReceita.Click += btnGravarReceita_Click;
            // 
            // VerReceita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 631);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "VerReceita";
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