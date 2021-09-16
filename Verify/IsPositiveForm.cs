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
    public partial class IsPositiveForm : Form
    {
        Verifications Verificar = new Verifications();

        public IsPositiveForm()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("O Number é Positivo ?? R: {0}", (Verificar.isPositive(int.Parse(txtValor.Text))).ToString()));
        }
    }
}
