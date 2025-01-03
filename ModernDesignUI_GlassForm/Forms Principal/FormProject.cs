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
    public partial class FormProject : Form
    {
        public FormProject()
        {
            InitializeComponent();
            Actualiza();
        }

        #region function
        double Tot_Concluido=2, Tot_Em_Progresso=4, Tot_Pendente=5, Tot_Todas =11;
        Bunifu.DataViz.DataPoint values;
        void RenderChart()
        {
            Chart1.colorSet.Add(Color.FromArgb(61, 211, 80));
            Chart1.colorSet.Add(Color.Fuchsia);
            Chart1.colorSet.Add(Color.FromArgb(254, 23, 64));

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();

            if (rdPadrao.Checked == true)
                values = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_column);
            else if (rdPie.Checked == true)
                values = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_pie);
            else if (rdArea.Checked == true)
                values = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_area);

            //Add Values

            values.addLabely("Concluídos", Tot_Concluido.ToString());
            values.addLabely("Em Progresso", Tot_Em_Progresso.ToString());
            values.addLabely("Pendentes", Tot_Pendente.ToString());

            canvas.addData(values);
            Chart1.Render(canvas);

        }

        void Actualiza()
        {
            DgVisualizador.Rows.Add("01", "Frontend 089", "Frontend", "software", "02-10-2023", "Concluído");
            DgVisualizador.Rows.Add("02", "Frontend 070", "Frontend", "software", "02-10-2023", "Concluído");
            DgVisualizador.Rows.Add("03", "Api de entrega 067", "Backend", "API", "02-10-2023", "Em progresso...");
            DgVisualizador.Rows.Add("03", "Api de entrega 067", "Backend", "API", "02-10-2023", "Em progresso...");
            DgVisualizador.Rows.Add("03", "Api de entrega 067", "Backend", "API", "02-10-2023", "Em progresso...");
            DgVisualizador.Rows.Add("03", "Api de entrega 067", "Backend", "API", "02-10-2023", "Em progresso...");
            DgVisualizador.Rows.Add("04", "Frontend 045", "Frontend", "software", "02-10-2023", "Pendente");
            DgVisualizador.Rows.Add("04", "Frontend 045", "Frontend", "software", "02-10-2023", "Pendente");
            DgVisualizador.Rows.Add("04", "Frontend 045", "Frontend", "software", "02-10-2023", "Pendente");
            DgVisualizador.Rows.Add("04", "Frontend 045", "Frontend", "software", "02-10-2023", "Pendente");
            DgVisualizador.Rows.Add("04", "Frontend 045", "Frontend", "software", "02-10-2023", "Pendente");

            RenderChart();

            for (int i = 0; i < DgVisualizador.Rows.Count; i++)
            {
                if (DgVisualizador.Rows[i].Cells[5].Value.ToString() == "Concluído"){
                    DgVisualizador.Rows[i].Cells[5].Style.ForeColor = Color.FromArgb(61, 211, 80);
                    DgVisualizador.Rows[i].Cells[5].Style.SelectionForeColor = Color.FromArgb(61, 211, 80);
                }
                else if (DgVisualizador.Rows[i].Cells[5].Value.ToString() == "Em progresso...")
                {
                    DgVisualizador.Rows[i].Cells[5].Style.ForeColor = Color.Fuchsia;
                    DgVisualizador.Rows[i].Cells[5].Style.SelectionForeColor = Color.Fuchsia;
                }
                else if (DgVisualizador.Rows[i].Cells[5].Value.ToString() == "Pendente")
                {
                    DgVisualizador.Rows[i].Cells[5].Style.ForeColor = Color.FromArgb(254, 23, 64);
                    DgVisualizador.Rows[i].Cells[5].Style.SelectionForeColor = Color.FromArgb(254, 23, 64);
                }
            }
        }
        #endregion

        private void btnTipoGrafico_Click(object sender, EventArgs e)
        {

            if (panelTG.Width == 283)
                panelTG.Width = 32;
            else if (panelTG.Width == 32)
                panelTG.Width = 283;
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            btnGrafico.Visible = false;
            RenderChart();
            panelTG.Visible = true;
        }

        private void rdPadrao_CheckedChanged(object sender, EventArgs e)
        {

            RenderChart();
        }

        private void rdPie_CheckedChanged(object sender, EventArgs e)
        {

            RenderChart();
        }

        private void rdArea_CheckedChanged(object sender, EventArgs e)
        {

            RenderChart();
        }
    }
}
