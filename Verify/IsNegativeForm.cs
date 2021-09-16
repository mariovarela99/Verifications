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
    }
}
