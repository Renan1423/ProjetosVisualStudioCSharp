using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjTresCamadas
{
    public partial class FrmPF : Form
    {
        public FrmPF()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmPF_BLL frmPF_BLL = new FrmPF_BLL();
            bool inc = FrmPF_BLL.incluirPF(txtNome.Text, txtTel.Text);
            if (inc)
            {
                MessageBox.Show("Incluído com sucesso");
            }
            else {
                MessageBox.Show("Falha ao incluir");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmPF_BLL frmPF_BLL = new FrmPF_BLL();
            bool cons = FrmPF_BLL.consultarPF(txtID.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmPF_BLL frmPF_BLL = new FrmPF_BLL();
            bool alt = FrmPF_BLL.alterarPF(txtNome.Text, txtTel.Text);
            if (alt)
            {
                MessageBox.Show("Alterado com sucesso");
            }
            else
            {
                MessageBox.Show("Falha ao alterar");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FrmPF_BLL frmPF_BLL = new FrmPF_BLL();
            bool del = FrmPF_BLL.excluirPF(txtNome.Text, txtTel.Text, txtID.Text);
            if (del)
            {
                MessageBox.Show("Alterado com sucesso");
            }
            else
            {
                MessageBox.Show("Falha ao alterar");
            }
        }
    }
}
