using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMVC.Controlador
{
    public class ControladorCli
    {
        ClasseConexao conn;
        DataTable dt;
        int qtdeDados = 0;
        int pos = 0;

        public void buscarClientes(){
            pos = 0;
            qtdeDados = 0;
            String sql = "select * from cliente";
            conn = new ClasseConexao();
            dt = new DataTable();
            dt = conn.executa_sql(sql);
            qtdeDados = dt.Rows.Count - 1;
        }

        public void inserirCliente(Modelo.Cliente cli) {
            String sql = "Insert into cliente (nome, endereco, numero, complemento, bairro, cep, cidade, estado)" + "values('" + cli.getNome() + "','" + cli.getEndereco() + "','" + cli.getCidade() + "','" + cli.getEstado() + "')";
            conn = new ClasseConexao();
            dt = new DataTable();
            dt = conn.executa_sql(sql);
        }

        public Modelo.Cliente primeiro()
        {
            Modelo.Cliente cli = new Modelo.Cliente();
            try
            {
                cli.setCodigo((int)dt.Rows[0]["código"]);
                cli.setNome(dt.Rows[0]["nome"] + "");
                cli.setEndereco(dt.Rows[0]["endereco"] + "");
                cli.setNumero(dt.Rows[0]["numero"] + "");
                cli.setComplemento(dt.Rows[0]["complemento"] + "");
                cli.setBairro(dt.Rows[0]["bairro"] + "");
                cli.setCep(dt.Rows[0]["cep"] + "");
                cli.setCidade(dt.Rows[0]["cidade"] + "");
                cli.setEstado(dt.Rows[0]["estado"] + "");
            }
            catch (Exception e) {
                cli = null;
            }
            return cli;
        }

        public Modelo.Cliente proximo()
        {
            Modelo.Cliente cli = new Modelo.Cliente();
            try
            {
                pos++;
                if (pos > qtdeDados)
                {
                    pos = qtdeDados;
                    cli.setCodigo((int)dt.Rows[pos]["codigo"]);
                    cli.setNome(dt.Rows[pos]["nome"] + "");
                    cli.setEndereco(dt.Rows[pos]["nome"] + "");
                    cli.setNumero(dt.Rows[pos]["nome"] + "");
                    cli.setComplemento(dt.Rows[pos]["nome"] + "");
                    cli.setBairro(dt.Rows[pos]["nome"] + "");
                    cli.setCep(dt.Rows[pos]["nome"] + "");
                    cli.setCidade(dt.Rows[pos]["nome"] + "");
                    cli.setEstado(dt.Rows[pos]["nome"] + "");
                }
            }
            catch (Exception e) {
                cli = null;
            }
            return cli;
        }
    }
}
