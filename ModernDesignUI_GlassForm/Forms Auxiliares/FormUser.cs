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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            cmb_funcionario.SelectedIndex = 1;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        Bitmap bmp;
        private void btnBuscarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(dialog.FileName);

                picture_img.Image = bmp;
                picture_img.BorderStyle = BorderStyle.None;
            }
        }
    }
}
