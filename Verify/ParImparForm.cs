using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verify
{
    public partial class ParImparForm : Form
    {
        Verifications Verificar = new Verifications();

        public ParImparForm()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("O Number é => {0}", (Verificar.ParOrImpar(int.Parse(txtValor.Text)))));
        }
    }
}
