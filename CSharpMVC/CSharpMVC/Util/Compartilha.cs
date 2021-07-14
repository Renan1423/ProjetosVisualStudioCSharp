using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMVC.Util
{
    public class Compartilha
    {
        private static String tabela;
        private static String campo1;
        private static String campo2;

        public void setTabela(String tab) {
            tabela = tab;
        }

        public String getTabela() {
            return tabela;
        }

        public void setCampo1(String cmp1) {
            campo1 = cmp1;
        }

        public String getCampo1() {
            return campo1;
        }

    }
}
