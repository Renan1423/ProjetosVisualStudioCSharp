using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Class1
    {
        private static int idadeMinima = 18;

        public bool validaIdadeMinima(String idade) {
            int ida = int.Parse(idade);
            if (ida < idadeMinima)
            {
                return false;
            }
            else {
                return true;
            }
        }
    }
}
