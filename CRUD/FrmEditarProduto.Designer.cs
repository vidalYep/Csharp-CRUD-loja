namespace CRUD
{
    partial class FrmEditarProduto
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
            this.btn_salvar = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_fornecedor = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_fornecedor = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.chk_ativo = new System.Windows.Forms.CheckBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_salvar.Location = new System.Drawing.Point(138, 286);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(107, 29);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(72, 74);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 15);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(205, 202);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(40, 15);
            this.lbl_preco.TabIndex = 4;
            this.lbl_preco.Text = "Preço:";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(23, 199);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(72, 15);
            this.lbl_quantidade.TabIndex = 5;
            this.lbl_quantidade.Text = "Quantidade:";
            // 
            // lbl_fornecedor
            // 
            this.lbl_fornecedor.AutoSize = true;
            this.lbl_fornecedor.Location = new System.Drawing.Point(23, 160);
            this.lbl_fornecedor.Name = "lbl_fornecedor";
            this.lbl_fornecedor.Size = new System.Drawing.Size(70, 15);
            this.lbl_fornecedor.TabIndex = 6;
            this.lbl_fornecedor.Text = "Fornecedor:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(50, 118);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(43, 15);
            this.lbl_nome.TabIndex = 7;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(173, 74);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(49, 15);
            this.lbl_codigo.TabIndex = 8;
            this.lbl_codigo.Text = "Código:";
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Location = new System.Drawing.Point(99, 71);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(65, 23);
            this.txt_id.TabIndex = 9;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(249, 199);
            this.txt_preco.MaxLength = 12;
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(100, 23);
            this.txt_preco.TabIndex = 10;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(99, 196);
            this.txt_quantidade.MaxLength = 10;
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(100, 23);
            this.txt_quantidade.TabIndex = 11;
            // 
            // txt_fornecedor
            // 
            this.txt_fornecedor.Location = new System.Drawing.Point(99, 157);
            this.txt_fornecedor.MaxLength = 50;
            this.txt_fornecedor.Name = "txt_fornecedor";
            this.txt_fornecedor.Size = new System.Drawing.Size(250, 23);
            this.txt_fornecedor.TabIndex = 12;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(99, 115);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(250, 23);
            this.txt_nome.TabIndex = 13;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(225, 71);
            this.txt_codigo.MaxLength = 20;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(124, 23);
            this.txt_codigo.TabIndex = 14;
            this.txt_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chk_ativo
            // 
            this.chk_ativo.AutoSize = true;
            this.chk_ativo.Location = new System.Drawing.Point(99, 240);
            this.chk_ativo.Name = "chk_ativo";
            this.chk_ativo.Size = new System.Drawing.Size(54, 19);
            this.chk_ativo.TabIndex = 16;
            this.chk_ativo.Text = "Ativo";
            this.chk_ativo.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_excluir.Location = new System.Drawing.Point(138, 311);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(107, 29);
            this.btn_excluir.TabIndex = 17;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Visible = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // FrmEditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.chk_ativo);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_fornecedor);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_fornecedor);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_salvar);
            this.Name = "FrmEditarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarProduto";
            this.Load += new System.EventHandler(this.FrmEditarProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_salvar;
        private Label lbl_id;
        private Label lbl_preco;
        private Label lbl_quantidade;
        private Label lbl_fornecedor;
        private Label lbl_nome;
        private Label lbl_codigo;
        private TextBox txt_id;
        private TextBox txt_preco;
        private TextBox txt_quantidade;
        private TextBox txt_fornecedor;
        private TextBox txt_nome;
        private TextBox txt_codigo;
        private CheckBox chk_ativo;
        private Button btn_excluir;
    }
}