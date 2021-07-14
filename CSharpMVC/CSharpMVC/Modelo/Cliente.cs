using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMVC.Modelo
{
    class Cliente
    {
        private String nome;
        private String endereco;
        private String numero;
        private String bairro;
        private String cep;
        private int codigo;
        private String cidade;
        private String estado;
        private String complemento;


        public String getNome() {
            return nome;
        }
        public void setNome(String nome) {
            this.nome = nome;
        }
        public String getEndereco(){
            return endereco;
        }
        public void setEndereco(String endereco)
        {
            this.endereco = endereco;
        }

        public void setNumero(String numero)
        {
            this.numero = numero;
        }
        public String getNumero()
        {
            return numero;
        }

        public int getCodigo()
        {
            return codigo;
        }
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public String getComplemento()
        {
            return complemento;
        }
        public void setComplemento(String complemento)
        {
            this.complemento = complemento;
        }

        public String getBairro()
        {
            return bairro;
        }
        public void setBairro(String bairro)
        {
            this.bairro = bairro;
        }

        public String getCidade()
        {
            return cidade;
        }
        public void setCidade(String cidade)
        {
            this.cidade = cidade;
        }

        public String getCep()
        {
            return cep;
        }
        public void setCep(String cep)
        {
            this.cep = cep;
        }

        public String getEstado()
        {
            return estado;
        }
        public void setEstado(String estado)
        {
            this.estado = estado;
        }
    }
}
