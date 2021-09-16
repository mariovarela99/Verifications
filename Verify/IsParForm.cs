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
    public partial class IsParForm : Form
    {
        Verifications Verificar = new Verifications();

        public IsParForm()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("O Number é Par ?? R: {0}", (Verificar.isPar(int.Parse(txtValor.Text))).ToString()));
        }
    }
}
