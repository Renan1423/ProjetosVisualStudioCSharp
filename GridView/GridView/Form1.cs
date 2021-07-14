using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridView
{
    public partial class Form1 : Form
    { 
        ClasseConexao con;
        DataSet ds;
        string id = "-1";
        public Form1()
    {
        InitializeComponent();
    }
    private void atualizar_grid()
    {
        con = new ClasseConexao();
        ds = new DataSet();
        ds = con.executa_sql("select * from contatos");
        dataGridView1.DataSource = ds.Tables[0].DefaultView;
    }
    private void formataGrid()
    {
        //permite personalizar o grid
        dataGridView1.AutoGenerateColumns = false;
        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        //altera a cor das linhas alternadas no grid
        dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
        dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        //altera o nome das colunas
        dataGridView1.Columns[0].HeaderText = "ID";
        dataGridView1.Columns[1].HeaderText = "NOME";
        dataGridView1.Columns[2].HeaderText = "FONE";
        //grid.Columns[3].HeaderText = "PREÇO UNITÁRIO";
        dataGridView1.Columns[0].Width = 20;
        dataGridView1.Columns[1].Width = 150;
        dataGridView1.Columns[2].Width = 80;
        //formata a coluna para moeda (currency)
        //grid.Columns[3].DefaultCellStyle.Format = "c";
        //ao clicar, seleciona a linha inteira
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //não permite seleção de multiplas linhas    
        dataGridView1.MultiSelect = false;
        // exibe vazio no lugar de null
        //dataGridView1.DefaultCellStyle.NullValue = "";
        //Expande a célula automáticamente
        dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        //alinha à direita os campos moeda
        //grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    }
    private void button1_Click(object sender, EventArgs e)
    {
            con = new ClasseConexao();
            ds = new DataSet();
            ds = con.executa_sql("select * from contatos");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            formataGrid();
        }

    private void button2_Click(object sender, EventArgs e)
    {
        int max = dataGridView1.Rows.Count - 2;
        string v1 = dataGridView1.Rows[max].Cells[1].Value.ToString(); //Nome
        string v2 = dataGridView1.Rows[max].Cells[2].Value.ToString(); //fone
        string sql = "INSERT INTO contatos(nome,fone) VALUES ('" + v1 + "','" + v2 + "')";
        //insere no banco
        con = new ClasseConexao();
        ds = new DataSet();
        ds = con.executa_sql(sql);
        atualizar_grid();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        try
        {
            if (dataGridView1.Rows.Count > 1)
            {
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    //salva somente os selecionados, OBS. PERMITIR MULTISELECT
                    //if (dataGridView1.Rows[i].Selected)
                    //{
                    string v1 = dataGridView1.Rows[i].Cells[1].Value.ToString(); //Nome
                    string v2 = dataGridView1.Rows[i].Cells[2].Value.ToString(); //fone
                    string sql = "INSERT INTO contatos(nome,fone) VALUES ('" + v1 + "','" + v2 + "')";
                    //insere no banco
                    con = new ClasseConexao();
                    ds = new DataSet();
                    ds = con.executa_sql(sql);
                    //}
                }
            }
            atualizar_grid();
        }
        catch (Exception erro)
        {
            MessageBox.Show("Erro ao Inserir " + erro.ToString());
        }

    }

    private void button4_Click(object sender, EventArgs e)
    {
        con = new ClasseConexao();
        ds = new DataSet();
        int max = dataGridView1.Rows.Count - 2;
        ds = con.executa_sql("delete from contatos where id=" + id);
        //insere no banco
        atualizar_grid();
        formataGrid();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); //Nome
    }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            ds = new DataSet();
            ds = con.executa_sql("select * from contatos");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            formataGrid();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int max = dataGridView1.Rows.Count - 2;
            string v1 = dataGridView1.Rows[max].Cells[1].Value.ToString(); //Nome
            string v2 = dataGridView1.Rows[max].Cells[2].Value.ToString(); //fone
            string sql = "INSERT INTO contatos(nome,fone) VALUES ('" + v1 + "','" + v2 + "')";
            //insere no banco
            con = new ClasseConexao();
            ds = new DataSet();
            ds = con.executa_sql(sql);
            atualizar_grid();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 1)
                {
                    for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                    {
                        //salva somente os selecionados, OBS. PERMITIR MULTISELECT
                        //if (dataGridView1.Rows[i].Selected)
                        //{
                        string v1 = dataGridView1.Rows[i].Cells[1].Value.ToString(); //Nome
                        string v2 = dataGridView1.Rows[i].Cells[2].Value.ToString(); //fone
                        string sql = "INSERT INTO contatos(nome,fone) VALUES ('" + v1 + "','" + v2 + "')";
                        //insere no banco
                        con = new ClasseConexao();
                        ds = new DataSet();
                        ds = con.executa_sql(sql);
                        //}
                    }
                }
                atualizar_grid();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Inserir " + erro.ToString());
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            ds = new DataSet();
            int max = dataGridView1.Rows.Count - 2;
            ds = con.executa_sql("delete from contatos where id=" + id);
            //insere no banco
            atualizar_grid();
            formataGrid();
        }
    }
}
