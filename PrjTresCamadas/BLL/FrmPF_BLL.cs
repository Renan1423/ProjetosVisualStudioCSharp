using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class FrmPF_BLL
    {
        FrmPF_BLL frmpf_dal;

        public DataTable consultarPF(String id) {
            frmpf_dal = new FrmPF_DAL();
            return frmpf_dal.consultarPF(id);
        }

        public bool incluirPF(String nome, String fone) {
            frmpf_dal = new FrmPF_DAL();
            return frmpf_dal.incluirPF(nome, fone);
        }

        public bool excluirPF(String id){
            frmpf_dal = new FrmPF_DAL();
            return frmpf_dal.excluirPF(id);
        }

       

    }
}
