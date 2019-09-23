using Parcial1_Ap1.BLL;
using Parcial1_Ap1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_Ap1.UI.Consultas
{
    public partial class cEvaluacion : Form
    {
        public cEvaluacion()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Evaluacion>();

            if(CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = EvaluacionBLL.GetList(p => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = EvaluacionBLL.GetList(p => p.EvaluacionId == id);
                        break;

                    case 2:
                        listado = EvaluacionBLL.GetList(p => p.Estudiante.Contains(CriterioTextBox.Text));
                        break;

                    case 3:
                        int pronostico = Convert.ToInt32(CriterioTextBox.Text);
                        listado = EvaluacionBLL.GetList(p => p.Pronostico == pronostico);
                        break;

                }

                listado = listado.Where(c => c.Fecha >= DesdeDateTimePicker.Value && c.Fecha <= HastaDateTimePicker.Value).ToList();
            }
            else
            {
                listado = EvaluacionBLL.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
