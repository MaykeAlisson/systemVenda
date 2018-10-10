namespace systemVenda
{
    partial class frm_categorias
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
            this.vw_categoria = new System.Windows.Forms.DataGridView();
            this.btn_cat_cancelar = new System.Windows.Forms.Button();
            this.btn_cat_excluir = new System.Windows.Forms.Button();
            this.btn_cat_cadastro = new System.Windows.Forms.Button();
            this.btn_cat_novo = new System.Windows.Forms.Button();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.lab_categoria = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vw_categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // vw_categoria
            // 
            this.vw_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vw_categoria.Location = new System.Drawing.Point(12, 82);
            this.vw_categoria.Name = "vw_categoria";
            this.vw_categoria.Size = new System.Drawing.Size(530, 197);
            this.vw_categoria.TabIndex = 33;
            // 
            // btn_cat_cancelar
            // 
            this.btn_cat_cancelar.Location = new System.Drawing.Point(363, 47);
            this.btn_cat_cancelar.Name = "btn_cat_cancelar";
            this.btn_cat_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cat_cancelar.TabIndex = 32;
            this.btn_cat_cancelar.Text = "Cancelar";
            this.btn_cat_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_cat_excluir
            // 
            this.btn_cat_excluir.Location = new System.Drawing.Point(277, 47);
            this.btn_cat_excluir.Name = "btn_cat_excluir";
            this.btn_cat_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_cat_excluir.TabIndex = 31;
            this.btn_cat_excluir.Text = "Excluir";
            this.btn_cat_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_cat_cadastro
            // 
            this.btn_cat_cadastro.Location = new System.Drawing.Point(184, 47);
            this.btn_cat_cadastro.Name = "btn_cat_cadastro";
            this.btn_cat_cadastro.Size = new System.Drawing.Size(75, 23);
            this.btn_cat_cadastro.TabIndex = 30;
            this.btn_cat_cadastro.Text = "Cadatrar";
            this.btn_cat_cadastro.UseVisualStyleBackColor = true;
            // 
            // btn_cat_novo
            // 
            this.btn_cat_novo.Location = new System.Drawing.Point(95, 47);
            this.btn_cat_novo.Name = "btn_cat_novo";
            this.btn_cat_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_cat_novo.TabIndex = 29;
            this.btn_cat_novo.Text = "Novo";
            this.btn_cat_novo.UseVisualStyleBackColor = true;
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(265, 6);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(100, 20);
            this.txt_categoria.TabIndex = 24;
            // 
            // lab_categoria
            // 
            this.lab_categoria.AutoSize = true;
            this.lab_categoria.Location = new System.Drawing.Point(204, 9);
            this.lab_categoria.Name = "lab_categoria";
            this.lab_categoria.Size = new System.Drawing.Size(52, 13);
            this.lab_categoria.TabIndex = 23;
            this.lab_categoria.Text = "Categoria";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 296);
            this.Controls.Add(this.vw_categoria);
            this.Controls.Add(this.btn_cat_cancelar);
            this.Controls.Add(this.btn_cat_excluir);
            this.Controls.Add(this.btn_cat_cadastro);
            this.Controls.Add(this.btn_cat_novo);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.lab_categoria);
            this.Controls.Add(this.button1);
            this.Name = "frm_categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.vw_categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vw_categoria;
        private System.Windows.Forms.Button btn_cat_cancelar;
        private System.Windows.Forms.Button btn_cat_excluir;
        private System.Windows.Forms.Button btn_cat_cadastro;
        private System.Windows.Forms.Button btn_cat_novo;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.Label lab_categoria;
        private System.Windows.Forms.Button button1;
    }
}