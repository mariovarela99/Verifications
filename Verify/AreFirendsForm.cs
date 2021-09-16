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
    public partial class AreFirendsForm : Form
    {

        Verifications Verificar = new Verifications();

        public AreFirendsForm()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("São Amigos ?? R: {0}", (Verificar.AreFriends(int.Parse(txtValor.Text), int.Parse(txtValor1.Text)))));
        }
    }
}
