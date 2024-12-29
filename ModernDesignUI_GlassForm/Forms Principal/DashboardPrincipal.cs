using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using ModernDesignUI_GlassForm.Forms_Auxiliares;
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


            panelUsuario.Width = 50;
            panelNOTIFICACAO.Location = new Point(864, 67);
            panelNOTIFICACAO.SendToBack();
            panelCabecalho.BottomSahddow = false;
        }

        BunifuTransition T1 = new BunifuTransition();
        BunifuTransition T2 = new BunifuTransition();

        #region Functions


        private Form activeForm = null;
        void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelexe.Controls.Add(childForm);
            //panelexe.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

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

        private void btnNotificacao_Click(object sender, EventArgs e)
        {
            if (panelNOTIFICACAO.Visible == false)
            {
                panelNOTIFICACAO.BringToFront();
                panelNOTIFICACAO.Visible = true;
            }
            else
            {
                panelNOTIFICACAO.Visible = false;
                panelNOTIFICACAO.SendToBack();
            }
        }

        private void ptr_User_Click(object sender, EventArgs e)
        {
            if (panelUsuario.Width == 200)
            {
                panelUsuario.Width = 50;
                panelNOTIFICACAO.Location = new Point(864, 67);
            }
            else if (panelUsuario.Width == 50)
            {
                panelUsuario.Width = 200;
                panelNOTIFICACAO.Location = new Point(714, 67);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelCabecalho.BottomSahddow = false;

            panelexe.Controls.Clear();
            panelexe.SendToBack();

            panelMenus.BringToFront();
            panelMenuBase.Visible = false;

            panelNOTIFICACAO.SendToBack();
            panelNOTIFICACAO.Visible = false;
        }

        private void btnCloseMenu_Click(object sender, EventArgs e)
        {

            panelMenuBase.Visible = false;
        }

        private void btnRendimento_Click(object sender, EventArgs e)
        {
            panelCabecalho.BottomSahddow = false;

            panelexe.Controls.Clear();
            panelexe.SendToBack();

            panelMenus.BringToFront();
            panelMenuBase.Visible = true;

            //-----------------------------
            panelMenuRendimento.BringToFront();
            btnCloseMenu.BringToFront();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            panelCabecalho.BottomSahddow = false;

            panelexe.Controls.Clear();
            panelexe.SendToBack();

            panelMenus.BringToFront();
            panelMenuBase.Visible = true;

            //-----------------------------
            panelMenuRendimento.SendToBack();
            panelMenuRelatorios.BringToFront();
            btnCloseMenu.BringToFront();
        }

        private void btnProjecto_Click(object sender, EventArgs e)
        {
            panelCabecalho.BottomSahddow = true;

            openChildForm(new FormProject());

            panelexe.BringToFront();

            panelexe.Visible = false;

            T1.ShowSync(panelexe);
        }

        private void btnMRendiMeuBalanco_Click(object sender, EventArgs e)
        {
            panelCabecalho.BottomSahddow = true;

            openChildForm(new FormMyBalance());

            panelexe.BringToFront();

            panelexe.Visible = false;

            T1.ShowSync(panelexe);
        }

        private void btnMRendiREgistroRenda_Click(object sender, EventArgs e)
        {
            panelCabecalho.BottomSahddow = false;

            panelexe.Controls.Clear();
            panelexe.SendToBack();

            panelMenus.BringToFront();
            panelMenuBase.Visible = false;

            FormIncome frm = new FormIncome();
            frm.ShowDialog();
        }

        private void btnMMProfile_Click(object sender, EventArgs e)
        {
            panelCabecalho.BottomSahddow = true;

            openChildForm(new FormMMProfile());

            panelexe.BringToFront();

            panelexe.Visible = false;

            T1.ShowSync(panelexe);
        }

        private void btnMReAtendimento_Click(object sender, EventArgs e)
        {
            panelCabecalho.BottomSahddow = true;

            openChildForm(new FormReport());

            panelexe.BringToFront();

            panelexe.Visible = false;

            T1.ShowSync(panelexe);
        }

        private void btnTrocarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frm = new FormLogin();
            frm.Show();
        }

    }
}
