using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpMVC.Visao
{
    public partial class Pesquisar : Form
    {
        ClasseConexao conn;
        DataTable dt;
        Util.Compartilha comp;

        public Pesquisar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new ClasseConexao();
            dt = new DataTable();
            comp = new Util.Compartilha();
            dt = conn.executar_sql("select * from" + comp.getTabela() + " where" + comp.getCampo1() + " = " + txtPesquisar.Text);
            dataGridView1.DataSourc = dt.DefaultView;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            comp.setCampo1(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
        }
    }
}
