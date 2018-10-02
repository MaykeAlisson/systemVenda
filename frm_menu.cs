using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemVenda
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_cad_produtos_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void btn_cad_categoria_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void cATEGORIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }
    }
}
