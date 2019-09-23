using Parcial1_Ap1.UI.Consultas;
using Parcial1_Ap1.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_Ap1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void EvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEvaluacion evaluacion = new rEvaluacion();
            evaluacion.MdiParent = this;
            evaluacion.Show();
        }

        private void EvaluacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cEvaluacion evaluacion = new cEvaluacion();
            evaluacion.MdiParent = this;
            evaluacion.Show();
        }
    }
}
