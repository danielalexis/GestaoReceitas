namespace GestaoReceitas
{
    partial class VerReceitas
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
            SuspendLayout();
            // 
            // lstViewReceitas
            // 
            lstViewReceitas.Columns.AddRange(new ColumnHeader[] { receitaNome, categoria, dificuldade, tempoPreparacao, descricao });
            lstViewReceitas.FullRowSelect = true;
            lstViewReceitas.Location = new Point(27, 30);
            lstViewReceitas.Name = "lstViewReceitas";
            lstViewReceitas.Size = new Size(907, 444);
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
            // VerReceitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 503);
            Controls.Add(lstViewReceitas);
            Name = "VerReceitas";
            Text = "Receitas";
            ResumeLayout(false);
        }

        #endregion

        private ListView lstViewReceitas;
        private ColumnHeader receitaNome;
        private ColumnHeader tempoPreparacao;
        private ColumnHeader descricao;
        private ColumnHeader dificuldade;
        private ColumnHeader categoria;
    }
}