using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBuyPass
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar(String login, String senha)
        {
            Logar cad = new Logar();
            tem = cad.VerificarLogin(login, senha);
            if(!cad.mensagem.Equals(""))
            {
                this.mensagem = cad.mensagem;
            }
            return tem;
        }
    }
}
