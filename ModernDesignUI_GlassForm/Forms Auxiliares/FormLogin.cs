using Bunifu.Framework.UI;
using ModernDesignUI_GlassForm.Forms_Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernDesignUI_GlassForm.Forms_Auxiliares
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            Elipse();
        }

        void Elipse()
        {
            BunifuDragControl c = new BunifuDragControl();
            c.TargetControl = panelLateral;

            BunifuDragControl c1 = new BunifuDragControl();
            c1.TargetControl = panelCentral;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardPrincipal frm = new DashboardPrincipal();
            frm.Show();
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardPrincipal frm = new DashboardPrincipal();
            frm.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
