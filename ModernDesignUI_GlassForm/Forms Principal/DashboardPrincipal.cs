using Bunifu.Framework.UI;
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
    public partial class DashboardPrincipal : Form
    {
        public DashboardPrincipal()
        {
            InitializeComponent();
            AplicaElipse();


            panelNOTIFICACAO.Location = new Point(864, 67);
            panelNOTIFICACAO.SendToBack();
        }
        #region Functions

        void AplicaElipse()
        {
            BunifuDragControl c = new BunifuDragControl();
            c.TargetControl = panelCabecalho;

            BunifuElipse elipse = new BunifuElipse();
            elipse.ApplyElipse(lblTotalNotificacao, 100);
            elipse.ApplyElipse(panelNOTIFICACAO, 25);
            elipse.ApplyElipse(panelBaseNotificacao, 25);
        }
        void SairApp()
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timerExit.Start();
                timerExit.Enabled = true;
            }
        }
        #endregion

        private void timerExit_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            SairApp();
        }
        int LX, LY;
        int QualDirect = 0;
        private void btnmax_Click(object sender, EventArgs e)
        {
            if (QualDirect == 0)
            {
                LX = this.Location.X;
                LY = this.Location.Y;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                //btnRest.Visible = true;
                //btnMaximizar.Visible = false;
                QualDirect = 1;
            }
            else if (QualDirect == 1)
            {
                this.Size = new Size(1204, 660);
                this.Location = new Point(LX, LY);
                //btnRest.Visible = false;
                //btnMaximizar.Visible = true;
                QualDirect = 0;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            if (panelLateral.Width == 250)
                panelLateral.Width = 65;
            else if (panelLateral.Width == 65)
                panelLateral.Width = 250;
        }

        int TotalNotificacao = 2;
        private void btnNotificacao_Click(object sender, EventArgs e)
        {
            if (TotalNotificacao > 0)
            {
                if (panelNOTIFICACAO.Visible == false)
                {
                    panelNOTIFICACAO.Visible = true;
                    panelNOTIFICACAO.BringToFront();
                }
                else
                {
                    panelNOTIFICACAO.Visible = false;
                    panelNOTIFICACAO.SendToBack();
                }
            }
        }


    }
}
