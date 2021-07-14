using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class FrmPF_DAL
    {
        ClasseConexao con;
        DataSet ds;

        public DataTable consultarPF(String id) {
            con = new ClasseConexao();
            ds = new DataSet();
            string sql = "select * from contatos where id=" + id;
            ds = con.executarSQL(sql);
            return ds.Tables[0];
        }

        public bool incluirPF(String nome, String fone) {
            try
            {
                con = new ClasseConexao();
                string sql = "insert into contatos (nome, fone) values('" + nome + "','" + fone + "')";
                return con.manutencaoDB(sql);
            }
            catch (Exception) {
                return false;
            }
        }

        public bool excluirPF(String id)
        {
            try
            {
                con = new ClasseConexao();
                string sql = "delete * from contatos where id=" + id;
                return con.manutencaoDB(sql);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool alterarPF(String nome, String fone, String id)
        {
            try
            {
                con = new ClasseConexao();
                string sql = "update contatos (nome, fone) set '" + nome + "','" + fone + "' where id=" + id;
                return con.manutencaoDB(sql);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
