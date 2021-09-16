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
    public partial class MediaAritmetica3Form : Form
    {

        Verifications Verificar = new Verifications();

        public MediaAritmetica3Form()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            double media = Verificar.MediaArtimetica3(int.Parse(txtValor.Text), int.Parse(txtValor1.Text), int.Parse(txtValor2.Text));
            MessageBox.Show(String.Format("A media dos numbers digitados => {0}", media));
        }
    }
}
