namespace CrudEmDotNet
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lst_contato = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail :";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(31, 46);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(141, 20);
            this.TxtNome.TabIndex = 3;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(31, 94);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(141, 20);
            this.TxtTelefone.TabIndex = 4;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(31, 152);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(141, 20);
            this.TxtEmail.TabIndex = 5;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(163, 186);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 6;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Buscar contato :";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(233, 34);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(251, 20);
            this.txt_buscar.TabIndex = 8;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(505, 30);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lst_contato
            // 
            this.lst_contato.ContextMenuStrip = this.contextMenuStrip1;
            this.lst_contato.HideSelection = false;
            this.lst_contato.Location = new System.Drawing.Point(233, 75);
            this.lst_contato.MultiSelect = false;
            this.lst_contato.Name = "lst_contato";
            this.lst_contato.Size = new System.Drawing.Size(409, 97);
            this.lst_contato.TabIndex = 10;
            this.lst_contato.UseCompatibleStateImageBehavior = false;
            this.lst_contato.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lst_contato_ItemSelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_excluir});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 26);
            // 
            // tsm_excluir
            // 
            this.tsm_excluir.Name = "tsm_excluir";
            this.tsm_excluir.Size = new System.Drawing.Size(153, 22);
            this.tsm_excluir.Text = "Excluir contato";
            this.tsm_excluir.Click += new System.EventHandler(this.tsm_excluir_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(275, 186);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(384, 186);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 12;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 221);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lst_contato);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ListView lst_contato;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_excluir;
        private System.Windows.Forms.Button btn_excluir;
    }
}

