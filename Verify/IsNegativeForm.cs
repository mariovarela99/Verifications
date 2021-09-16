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
    public partial class IsNegativeForm : Form
    {
       Verifications Verificar = new Verifications();

        public IsNegativeForm()
        {
            InitializeComponent();
        }

        private void btnVerify_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("O Number é Negativo ?? R: {0}", (Verificar.isNegative(int.Parse(txtValor.Text))).ToString()));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
