using CsharpBuyPass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBuyPass
{
    
    public class Cadastrar
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        

        public Cadastrar(String cnpjTeatro, String razaoSocial, String marcaEmpresarial, String complemento, String bairro, String uf, String municipio, String endereço, String telefoneTeatro, String emailTeatro, String senhaTeatro)
        {
            cmd.CommandText = "INSERT INTO tblTeatro (cnpjTeatro, razaoSocial, marcaEmpresarial, complemento, bairro, uf, municipio, endereço, telefoneTeatro, emailTeatro, senhaTeatro) values(@cnpjTeatro, @razaoSocial, @marcaEmpresarial, @complemento, @bairro, @uf, @municipio, @endereço, @telefoneTeatro, @emailTeatro, @senhaTeatro)";
            cmd.Parameters.AddWithValue("@cnpjTeatro", cnpjTeatro);
            cmd.Parameters.AddWithValue("@razaoSocial", razaoSocial);
            cmd.Parameters.AddWithValue("@marcaEmpresarial", marcaEmpresarial);
            cmd.Parameters.AddWithValue("@complemento", complemento);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@uf", uf);
            cmd.Parameters.AddWithValue("@municipio", municipio);
            cmd.Parameters.AddWithValue("@endereço", endereço);
            cmd.Parameters.AddWithValue("@telefoneTeatro", telefoneTeatro);
            cmd.Parameters.AddWithValue("@emailTeatro", emailTeatro);
            cmd.Parameters.AddWithValue("@senhaTeatro", senhaTeatro);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados";
            }

        }

    }

    public class Logar
    {

        public bool tem;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool VerificarLogin(String login, String senha)
        {
            cmd.CommandText = "select emailTeatro, senhaTeatro from tblTeatro where emailTeatro = @login and senhaTeatro = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch(SqlException)
            {
                this.mensagem = "Erro ao se conectar com Banco de Dados!";
            }
            return tem;
        }
    }
}

public class CadastrarPeca
{
    Conexao c = new Conexao();
    SqlCommand cmd = new SqlCommand();
    public String mensagem = "";



    public CadastrarPeca(String sinopse, String classind, String nomePeca, String generoPeca, String fichaPeca, String dataPeca, String duracPeca)
    {
        cmd.CommandText = "INSERT INTO tblTeatro (sinopse, classInd, nomePeca, generoPeca, fichaPeca, dataPeca, duracaoPeca) values(@sinopse, @classind, @nomePeca, @generoPeca, @fichaPeca, @dataPeca, @duracPeca)";
        cmd.Parameters.AddWithValue("@sinopse", sinopse);
        cmd.Parameters.AddWithValue("@classind", classind);
        cmd.Parameters.AddWithValue("@nomePeca", nomePeca);
        cmd.Parameters.AddWithValue("@generoPeca", generoPeca);
        cmd.Parameters.AddWithValue("@fichaPeca", fichaPeca);
        cmd.Parameters.AddWithValue("@dataPeca", dataPeca);
        cmd.Parameters.AddWithValue("@duracPeca", duracPeca);

        try
        {
            cmd.Connection = c.conectar();
            cmd.ExecuteNonQuery();
            c.desconectar();
            this.mensagem = "Cadastrado com Sucesso!";
        }
        catch (SqlException e)
        {
            this.mensagem = "Erro ao se conectar com o banco de dados";
        }

    }

}
