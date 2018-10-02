namespace systemVenda
{
    partial class frm_produtos
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
            this.button1 = new System.Windows.Forms.Button();
            this.vw_cadastro = new System.Windows.Forms.DataGridView();
            this.btn_cad_cancelar = new System.Windows.Forms.Button();
            this.btn_cad_excluir = new System.Windows.Forms.Button();
            this.btn_cad_cadastro = new System.Windows.Forms.Button();
            this.btn_cad_novo = new System.Windows.Forms.Button();
            this.CB_categoria = new System.Windows.Forms.ComboBox();
            this.lab_categoria = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lab_valor = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.lab_descricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vw_cadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // vw_cadastro
            // 
            this.vw_cadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vw_cadastro.Location = new System.Drawing.Point(22, 108);
            this.vw_cadastro.Name = "vw_cadastro";
            this.vw_cadastro.Size = new System.Drawing.Size(530, 197);
            this.vw_cadastro.TabIndex = 21;
            // 
            // btn_cad_cancelar
            // 
            this.btn_cad_cancelar.Location = new System.Drawing.Point(373, 73);
            this.btn_cad_cancelar.Name = "btn_cad_cancelar";
            this.btn_cad_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cad_cancelar.TabIndex = 20;
            this.btn_cad_cancelar.Text = "Cancelar";
            this.btn_cad_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_cad_excluir
            // 
            this.btn_cad_excluir.Location = new System.Drawing.Point(287, 73);
            this.btn_cad_excluir.Name = "btn_cad_excluir";
            this.btn_cad_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_cad_excluir.TabIndex = 19;
            this.btn_cad_excluir.Text = "Excluir";
            this.btn_cad_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_cad_cadastro
            // 
            this.btn_cad_cadastro.Location = new System.Drawing.Point(194, 73);
            this.btn_cad_cadastro.Name = "btn_cad_cadastro";
            this.btn_cad_cadastro.Size = new System.Drawing.Size(75, 23);
            this.btn_cad_cadastro.TabIndex = 18;
            this.btn_cad_cadastro.Text = "Cadatrar";
            this.btn_cad_cadastro.UseVisualStyleBackColor = true;
            // 
            // btn_cad_novo
            // 
            this.btn_cad_novo.Location = new System.Drawing.Point(105, 73);
            this.btn_cad_novo.Name = "btn_cad_novo";
            this.btn_cad_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_cad_novo.TabIndex = 17;
            this.btn_cad_novo.Text = "Novo";
            this.btn_cad_novo.UseVisualStyleBackColor = true;
            // 
            // CB_categoria
            // 
            this.CB_categoria.FormattingEnabled = true;
            this.CB_categoria.Location = new System.Drawing.Point(431, 11);
            this.CB_categoria.Name = "CB_categoria";
            this.CB_categoria.Size = new System.Drawing.Size(121, 21);
            this.CB_categoria.TabIndex = 16;
            // 
            // lab_categoria
            // 
            this.lab_categoria.AutoSize = true;
            this.lab_categoria.Location = new System.Drawing.Point(370, 14);
            this.lab_categoria.Name = "lab_categoria";
            this.lab_categoria.Size = new System.Drawing.Size(52, 13);
            this.lab_categoria.TabIndex = 15;
            this.lab_categoria.Text = "Categoria";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(252, 11);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 14;
            // 
            // lab_valor
            // 
            this.lab_valor.AutoSize = true;
            this.lab_valor.Location = new System.Drawing.Point(191, 14);
            this.lab_valor.Name = "lab_valor";
            this.lab_valor.Size = new System.Drawing.Size(31, 13);
            this.lab_valor.TabIndex = 13;
            this.lab_valor.Text = "Valor";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(80, 11);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(100, 20);
            this.txt_descricao.TabIndex = 12;
            // 
            // lab_descricao
            // 
            this.lab_descricao.AutoSize = true;
            this.lab_descricao.Location = new System.Drawing.Point(19, 14);
            this.lab_descricao.Name = "lab_descricao";
            this.lab_descricao.Size = new System.Drawing.Size(55, 13);
            this.lab_descricao.TabIndex = 11;
            this.lab_descricao.Text = "Descrição";
            // 
            // frm_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 317);
            this.Controls.Add(this.vw_cadastro);
            this.Controls.Add(this.btn_cad_cancelar);
            this.Controls.Add(this.btn_cad_excluir);
            this.Controls.Add(this.btn_cad_cadastro);
            this.Controls.Add(this.btn_cad_novo);
            this.Controls.Add(this.CB_categoria);
            this.Controls.Add(this.lab_categoria);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lab_valor);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.lab_descricao);
            this.Controls.Add(this.button1);
            this.Name = "frm_produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.vw_cadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView vw_cadastro;
        private System.Windows.Forms.Button btn_cad_cancelar;
        private System.Windows.Forms.Button btn_cad_excluir;
        private System.Windows.Forms.Button btn_cad_cadastro;
        private System.Windows.Forms.Button btn_cad_novo;
        private System.Windows.Forms.ComboBox CB_categoria;
        private System.Windows.Forms.Label lab_categoria;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label lab_valor;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label lab_descricao;
    }
}