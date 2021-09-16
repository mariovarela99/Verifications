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
    public partial class GetMinForm : Form
    {

        Verifications Verificar = new Verifications();

        public GetMinForm()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("O Menor Number é: {0}", (Verificar.GetMin(int.Parse(txtValor.Text), int.Parse(txtValor1.Text)))));
        }
    }
}
