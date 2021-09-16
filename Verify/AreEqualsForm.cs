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
    public partial class AreEqualsForm : Form
    {

        Verifications Verificar = new Verifications();

        public AreEqualsForm()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("São Iguais ?? R: {0}", (Verificar.AreEquals(int.Parse(txtValor.Text), int.Parse(txtValor1.Text)))));
        }
    }
}
