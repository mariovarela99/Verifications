﻿using System;
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
    public partial class GetMaxForm : Form
    {

        Verifications Verificar = new Verifications();

        public GetMaxForm()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("O Maior Number é: {0}", (Verificar.GetMax(int.Parse(txtValor.Text), int.Parse(txtValor1.Text)))));
        }
    }
}
