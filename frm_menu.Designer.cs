namespace systemVenda
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_produtos = new System.Windows.Forms.Button();
            this.btn_cad_categoria = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.cATEGORIASToolStripMenuItem});
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // cATEGORIASToolStripMenuItem
            // 
            this.cATEGORIASToolStripMenuItem.Name = "cATEGORIASToolStripMenuItem";
            this.cATEGORIASToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cATEGORIASToolStripMenuItem.Text = "Categorias";
            this.cATEGORIASToolStripMenuItem.Click += new System.EventHandler(this.cATEGORIASToolStripMenuItem_Click);
            // 
            // btn_cad_produtos
            // 
            this.btn_cad_produtos.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_produtos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cad_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_produtos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cad_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cad_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_cad_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_produtos.ForeColor = System.Drawing.Color.White;
            this.btn_cad_produtos.Image = global::systemVenda.Properties.Resources.cadastro_produtos_40_x_40;
            this.btn_cad_produtos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_produtos.Location = new System.Drawing.Point(12, 43);
            this.btn_cad_produtos.Name = "btn_cad_produtos";
            this.btn_cad_produtos.Size = new System.Drawing.Size(79, 79);
            this.btn_cad_produtos.TabIndex = 2;
            this.btn_cad_produtos.Text = "Cadatrar Produtos";
            this.btn_cad_produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_produtos.UseVisualStyleBackColor = false;
            this.btn_cad_produtos.Click += new System.EventHandler(this.btn_cad_produtos_Click);
            // 
            // btn_cad_categoria
            // 
            this.btn_cad_categoria.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cad_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_categoria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cad_categoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cad_categoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_cad_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_categoria.ForeColor = System.Drawing.Color.White;
            this.btn_cad_categoria.Image = global::systemVenda.Properties.Resources.relatorios_40_x_40;
            this.btn_cad_categoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_categoria.Location = new System.Drawing.Point(111, 43);
            this.btn_cad_categoria.Name = "btn_cad_categoria";
            this.btn_cad_categoria.Size = new System.Drawing.Size(79, 79);
            this.btn_cad_categoria.TabIndex = 3;
            this.btn_cad_categoria.Text = "Cadatrar Categorias";
            this.btn_cad_categoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_categoria.UseVisualStyleBackColor = false;
            this.btn_cad_categoria.Click += new System.EventHandler(this.btn_cad_categoria_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::systemVenda.Properties.Resources.fundo_sistema_azul;
            this.ClientSize = new System.Drawing.Size(554, 286);
            this.Controls.Add(this.btn_cad_categoria);
            this.Controls.Add(this.btn_cad_produtos);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIASToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_produtos;
        private System.Windows.Forms.Button btn_cad_categoria;
    }
}