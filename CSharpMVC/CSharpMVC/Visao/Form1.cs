using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpMVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            controladorCli = new Controlador.ControladorCli();
            controladorCli.buscarClientes();
            setCliente(controladorCli.primeiro());
        }

        public void setCliente(Modelo.Cliente cli) {
            try {
                txtCodigo.Text = cli.getCodigo() + "";
                txtNome.Text = cli.getNome();
                txtEndereco.Text = cli.getEndereco();
                txtNumero.Text = cli.getNumero();
                txtComplemento.Text = cli.getComplemento();
                txtBairro.Text = cli.getBairro();
                txtCEP.Text = cli.getCep();
                txtCidade.Text = cli.getCidade();
                cboEstado.Text = cli.getEstado();
            }
            catch(Exception e)
            {

            }
        }

        public Modelo.Cliente getCliente() {
            Modelo.Cliente cli = new Modelo.Cliente();
            if (!(txtCodigo.Text.Equals(""))) {
                cli.setCodigo(int.Parse(txtCodigo.Text));
            }
            cli.setNome(txtNome.Text);
            cli.setEndereco(txtEndereco.Text);
            cli.setNumero(txtNumero.Text);
            cli.setComplemento(txtComplemento.Text);
            cli.setBairro(txtBairro.Text);
            cli.setCep(txtCEP.Text);
            cli.setCidade(txtCidade.Text);
            if (cboEstado.SelectedIndex == -1)
            {
                cli.setEstado("");
            }
            else
            {
                cli.setEstado(cboEstado.Items[cboEstado.SelectedIndex] + "");
                return cli;
            }
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Modelo.Cliente cli = getCliente();
            controladorCli.inserirCliente(cli);
            MessageBox.Show("Cliente cadastrado");
            controladorCli.buscarClientes();
            setCliente(controladorCli.ultimo());
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            setCliente(controladorCli.primeiro());
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                setCliente(controladorCli.anterior());
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                setCliente(controladorCli.proximo());
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            setCliente(controladorCli.ultimo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Util.Compartilha cp = new Util.Compartilha();
            cp.setTabela("cliente");
            cp.setCampo1("nome");
            Visao.Pesquisar frmPesquisar = new Visao.Pesquisar();
            frmPesquisar.ShowDialog();
            if (cp.getCampo1() != "") {
                controladorCli.pesquisarClientes(cp.getCampo1());
                setCliente(controladorCli.primeiro());
            }
        }
    }
}
