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
    public partial class Verify : Form
    {
        Verifications Verificar = new Verifications();

        public Verify()
        {
            InitializeComponent();
        }

        private void IsPositive_Click(object sender, EventArgs e)
        {
            IsPositiveForm PositiveForm = new IsPositiveForm();
            PositiveForm.Show();
        }

        private void IsNegative_Click(object sender, EventArgs e)
        {
            IsNegativeForm NegativeForm = new IsNegativeForm();
            NegativeForm.Show();
        }

        private void IsPar_Click(object sender, EventArgs e)
        {
            IsParForm ParForm = new IsParForm();
            ParForm.Show();
        }

        private void IsImpar_Click(object sender, EventArgs e)
        {
            IsImparForm ImparForm = new IsImparForm();
            ImparForm.Show();
        }

        private void SomarDivisores_Click(object sender, EventArgs e)
        {
            SomarDivisoresForm SomarAllDivisores = new SomarDivisoresForm();
            SomarAllDivisores.Show();
        }

        private void ContarDivisores_Click(object sender, EventArgs e)
        {
            ContarDivisoresForm ContarAllContadores = new ContarDivisoresForm();
            ContarAllContadores.Show();
        }

        private void IsPerfect_Click(object sender, EventArgs e)
        {
            IsPerfectForm PerfectForm = new IsPerfectForm();
            PerfectForm.Show();
        }

        private void IsPrimo_Click(object sender, EventArgs e)
        {
            IsPrimoForm PrimoForm = new IsPrimoForm();
            PrimoForm.Show();
        }

        private void GetMax_Click(object sender, EventArgs e)
        {
            GetMaxForm GettingMax = new GetMaxForm();
            GettingMax.Show();
        }

        private void GetMin_Click(object sender, EventArgs e)
        {
            GetMinForm GettingMin = new GetMinForm();
            GettingMin.Show();
        }

        private void AreEquals_Click(object sender, EventArgs e)
        {
            AreEqualsForm EqualsForm = new AreEqualsForm();
            EqualsForm.Show();
        }

        private void AreFriends_Click(object sender, EventArgs e)
        {
            AreFirendsForm FriendsForm = new AreFirendsForm();
            FriendsForm.Show();
        }

        private void ParOrImpar_Click(object sender, EventArgs e)
        {
            ParImparForm ParOrImparForm = new ParImparForm();
            ParOrImparForm.Show();
        }

        private void PosOrNeg_Click(object sender, EventArgs e)
        {
            PositivoOrNegativeForm PosNegForm = new PositivoOrNegativeForm();
            PosNegForm.Show();
        }
    }
}