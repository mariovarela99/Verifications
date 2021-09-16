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
    public partial class SomarDivisoresForm : Form
    {

        Verifications Verificar = new Verifications();

        public SomarDivisoresForm()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            lbResult.Text = String.Format("Result: {0}", Verificar.SomarDivisores(int.Parse(txtValor.Text)));
        }
    }
}
