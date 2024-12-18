﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernDesignUI_GlassForm.Forms_Principal
{
    public partial class FormMyBalance : Form
    {
        public FormMyBalance()
        {
            InitializeComponent();
        }

        #region Function's
        void OR_SWT_SALDO()
        {
            if (swtCadSaldo.Checked == true)
            {
                L_Saldo.Visible = true;

            }
            else if (swtCadSaldo.Checked == false)
            {
                L_Saldo.Visible = false;
            }
        }

        #endregion

        private void swtCadSaldo_CheckedChanged(object sender, EventArgs e)
        {

            OR_SWT_SALDO();
        }

        private void FormMyBalance_Load(object sender, EventArgs e)
        {

            OR_SWT_SALDO();
        }

        private void btnVermais_Click(object sender, EventArgs e)
        {
            panelMaisInfor.BringToFront();
            panelMaisInfor.Visible = true;
            panelPerfil.Visible = false;
        }

        private void btnFecharMais_Click(object sender, EventArgs e)
        {
            panelPerfil.BringToFront();
            panelPerfil.Visible = true;
            panelMaisInfor.Visible = false;
        }
    }
}
