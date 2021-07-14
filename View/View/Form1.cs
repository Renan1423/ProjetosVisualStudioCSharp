using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace View
{
    public partial class FormCliente : Form
    {
        BLL.Class1 clienteBLL = new BLL.Class1();

        public FormCliente()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            bool val = clienteBLL.validaIdadeMinima(textBox1.Text);
            if (val)
            {
                MessageBox.Show("Você é maior de idade");
            }
            else {
                MessageBox.Show("Você é menor de idade");
            }

        }
    }
}
