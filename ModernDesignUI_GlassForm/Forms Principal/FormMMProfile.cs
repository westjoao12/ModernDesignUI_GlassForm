using System;
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
    public partial class FormMMProfile : Form
    {
        public FormMMProfile()
        {
            InitializeComponent();
            FillDate();
            OR_SWT();
            OR_SWT_PERCENT_GERAL();
            OR_SWT_SUB_PERCENT();
            OR_SWT_SAQUE_MINIMO();
        }
        #region Function's
        void FillDate()
        {
            DgDepa.Rows.Add("Developers");
            DgDepa.Rows.Add("Marketing");
            DgDepa.Rows.Add("Logistica");

            dg_Tipo_Projecto.Rows.Add("Software");
            dg_Tipo_Projecto.Rows.Add("Audio");

            DgViewBanco.Rows.Add("Master Card", "128204345454556", "AO06 0000 0000 0000 0000");

            DgViewImposto.Rows.Add("IVA", "AO", "14.00", "Insento nos termos da linha a) do artigo 3...");

            dg_Arquivos_MM.Rows.Add("Certidão da empresa");
            dg_Arquivos_MM.Rows.Add("Arquivo 0987-0088");
            dg_Arquivos_MM.Rows.Add("Arquivo 0987-7896");
        }

        void OR_SWT()
        {
            if (swtCadEdit.Checked == true)
            {
                txt_nome.Enabled = true;
                txt_nif.Enabled = true;
                txt_contacto.Enabled = true;
                txt_email.Enabled = true;
                txt_localizacao.Enabled = true;
                btnSalvarProfile.Enabled = true;
                btnBuscarImg.Enabled = true;
            }
            else if (swtCadEdit.Checked == false)
            {
                txt_nome.Enabled = false;
                txt_nif.Enabled = false;
                txt_contacto.Enabled = false;
                txt_email.Enabled = false;
                txt_localizacao.Enabled = false;
                btnSalvarProfile.Enabled = false;
                btnBuscarImg.Enabled = false;
            }
        }

        void OR_SWT_PERCENT_GERAL()
        {
            if (swtCadEditPercentGeral.Checked == true)
            {
                txt_percent_empresa_distri.Enabled = true;
                txt_percent_socios_distri.Enabled = true;
                txt_percent_func_distri.Enabled = true;

                Btn_Save_Percent_Geral.Enabled = true;

            }
            else if (swtCadEditPercentGeral.Checked == false)
            {
                txt_percent_empresa_distri.Enabled = false;
                txt_percent_socios_distri.Enabled = false;
                txt_percent_func_distri.Enabled = false;

                Btn_Save_Percent_Geral.Enabled = false;
            }
        }

        void OR_SWT_SUB_PERCENT()
        {
            if (swtCadEditSubPercent.Checked == true)
            {
                txt_percent_caixa.Enabled = true;
                txt_percent_deposito.Enabled = true;
                txt_percent_despesas.Enabled = true;

                Btn_Save_Sub_Percent.Enabled = true;

            }
            else if (swtCadEditSubPercent.Checked == false)
            {
                txt_percent_caixa.Enabled = false;
                txt_percent_deposito.Enabled = false;
                txt_percent_despesas.Enabled = false;

                Btn_Save_Sub_Percent.Enabled = false;
            }
        }

        void OR_SWT_SAQUE_MINIMO()
        {
            if (swtCadEditSaqueMinimo.Checked == true)
            {
                txt_saque_minimo.Enabled = true;

                Btn_Save_Saque_Minimo.Enabled = true;

            }
            else if (swtCadEditSaqueMinimo.Checked == false)
            {
                txt_saque_minimo.Enabled = false;

                Btn_Save_Saque_Minimo.Enabled = false;
            }
        }

        #endregion

        private void swtCadEdit_CheckedChanged(object sender, EventArgs e)
        {
            OR_SWT();
        }

        private void swtCadEditSubPercent_CheckedChanged(object sender, EventArgs e)
        {
            OR_SWT_SUB_PERCENT();
        }

        private void swtCadEditPercentGeral_CheckedChanged(object sender, EventArgs e)
        {
            OR_SWT_PERCENT_GERAL();
        }

        private void swtCadEditSaqueMinimo_CheckedChanged(object sender, EventArgs e)
        {
            OR_SWT_SAQUE_MINIMO();
        }

        
    }
}
