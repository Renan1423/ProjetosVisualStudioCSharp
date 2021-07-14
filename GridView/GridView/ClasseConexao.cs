using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

    public class ClasseConexao
    {
        SqlConnection conexao = new SqlConnection();

        private SqlConnection conectar()
        {
            try
            {
                String strConexao = "Password=etesp; Persist Security Info=True; User ID=sa; Initial Catalog=Teste; Data Source=" + Environment.MachineName;
                conexao.ConnectionString = strConexao;
                conexao.Open();
                return conexao;
            }
            catch (Exception)
            {
                desconectar();
                return null;
            }
        }

        public void desconectar()
        {
            try
            {
                if ((conexao.State == ConnectionState.Open))
                {
                    conexao.Close();
                    conexao.Dispose();
                    conexao = null;
                }
            }
            catch (Exception) { }
        }

        public DataSet executa_sql(String comando_sql)
        {
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conectar());
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                desconectar();
            }
        }

        public int executa_IncAltExcParametros(SqlCommand comando) //incluir, alterar, excluir
        {
			/*
            con = new ClasseConexao();
            String nome = txtNome.Text;
            String fone = txtFone.Text;
            byte[] imagem = ImgToByte(caminhoImagem);
            SqlCommand cmd = new SqlCommand("INSERT INTO contatosIMG(nome,fone,img) VALUES(@nome,@fone,@img)");
            cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 50).Value = nome;
            cmd.Parameters.Add("@fone", SqlDbType.NVarChar, 50).Value = fone;
            cmd.Parameters.Add("@img", SqlDbType.VarBinary, imagem.Length).Value = imagem;
            int x = con.executa_IncAltExcParametros(cmd); //retorna o número de linhas afetadas no DB
            if(x > 0)
            {
                btnAdicionarImagem.Visible = false;
                btnSalvar.Visible = false;
                atualizar_dados();
                MessageBox.Show("Registro Salvo");
            }
            else
            {
                MessageBox.Show("Falha ao inserir registro");
            }			
			*/
            int retorno = 0;
            try
            {
                comando.Connection = conectar();  //adiciona a conexão ao SQLCommand
                retorno = comando.ExecuteNonQuery(); //devolve o número de linhas afetadas no banco
            }
            catch (Exception){}
            desconectar();
            return retorno;
        }

        public DataTable executa_Procedure(String x)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                conectar();
                cmd = new SqlCommand("minha_procedure", conectar()); //não digitar Exec, não passar os parâmetros
                cmd.Parameters.Add(new SqlParameter("@par1", x));
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception){}
            return dt;
        }


        public bool manutencao(String comando_sql) //teste
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = comando_sql;
                comando.Connection = conectar();
                conexao.Open();
                comando.ExecuteScalar();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                desconectar();
            }
        }
    }
