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

namespace Parcial1_Ap1.UI.Registros
{
    public partial class rEvaluacion : Form
    {
        public rEvaluacion()
        {
            InitializeComponent();
        }

        private void REvaluacion_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            EstudianteTextBox.Text = string.Empty;
            ValorTextBox.Text = string.Empty;
            LogradoTextBox.Text = string.Empty;
            PerdidoTextBox.Text = string.Empty;
            PronosticoComboBox.ResetText();
            MyErrorProvider.Clear();
        }

        private void LlenaCampo(Evaluacion evalucaion)
        {
            IdNumericUpDown.Value = evalucaion.EvaluacionId;
            FechaDateTimePicker.Value = evalucaion.Fecha;
            EstudianteTextBox.Text = evalucaion.Estudiante;
            ValorTextBox.Text = Convert.ToString(evalucaion.Valor);
            LogradoTextBox.Text = Convert.ToString(evalucaion.Logrado);
            PerdidoTextBox.Text = Convert.ToString(evalucaion.Perdido);
            PronosticoComboBox.SelectedIndex = evalucaion.Pronostico;
        }

        private Evaluacion LlenaClase()
        {
            Evaluacion evaluacion = new Evaluacion();
            evaluacion.EvaluacionId = Convert.ToInt32(IdNumericUpDown.Value);
            evaluacion.Fecha = FechaDateTimePicker.Value;
            evaluacion.Estudiante = EstudianteTextBox.Text;
            evaluacion.Valor = Convert.ToDecimal(ValorTextBox.Text);
            evaluacion.Logrado = Convert.ToDecimal(LogradoTextBox.Text);
            return evaluacion;
        }

        private bool ExisteEnLaBaseDeDatos()
        {

            Evaluacion evaluacion = EvaluacionBLL.Buscar((int)IdNumericUpDown.Value);

            return (evaluacion != null);
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(EstudianteTextBox.Text))
            {
                MyErrorProvider.SetError(EstudianteTextBox, "El campo estudiante no puede estar vacio");
                EstudianteTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ValorTextBox.Text))
            {
                MyErrorProvider.SetError(ValorTextBox, "El campo valor no puede estar vacio");
                ValorTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(LogradoTextBox.Text))
            {
                MyErrorProvider.SetError(LogradoTextBox, "El campo logrado no puede estar vacio");
                LogradoTextBox.Focus();
                paso = false;
            }

            if (Convert.ToDecimal(ValorTextBox.Text) < Convert.ToDecimal(LogradoTextBox.Text))
            {
                MyErrorProvider.SetError(LogradoTextBox, "El campo logrado no puede ser mayor que el valor");
                LogradoTextBox.Focus();
                paso = false;
            }

            if(Convert.ToDecimal(ValorTextBox.Text) <= 0)
            {
                MyErrorProvider.SetError(ValorTextBox, "El campo valor no puede ser menor o igual que cero");
                ValorTextBox.Focus();
                paso = false;
            }

            if (Convert.ToDecimal(LogradoTextBox.Text) < 0)
            {
                MyErrorProvider.SetError(LogradoTextBox, "El campo logrado no puede ser menor que cero");
                LogradoTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Evaluacion evaluacion;

            if (!Validar())
                return;

            evaluacion = LlenaClase();

            if (IdNumericUpDown.Value == 0)
                paso = EvaluacionBLL.Guardar(evaluacion);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una evaluacion que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = EvaluacionBLL.Modificar(evaluacion);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puede guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
         }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(Convert.ToString(IdNumericUpDown.Value), out id);

            Limpiar();

            if(EvaluacionBLL.Buscar(id) != null)
            {
                EvaluacionBLL.Eliminar(id);
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyErrorProvider.SetError(IdNumericUpDown, "No se puede eliminar una evaluacion que no existe");
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(Convert.ToString(IdNumericUpDown.Value), out id);
            Evaluacion evaluacion = new Evaluacion();

            Limpiar();

            evaluacion = EvaluacionBLL.Buscar(id);

            if(evaluacion != null)
            {
                LlenaCampo(evaluacion);
            }
            else
            {
                MessageBox.Show("Evaluacion no encontrada");
            }

        }

        private void CalificacionGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PronosticoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PerdidoTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void ValorTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal valor;
            decimal logrado;

            if(LogradoTextBox.Text == "")
                logrado = 0;
            else
                logrado = Convert.ToDecimal(LogradoTextBox.Text);

            if (ValorTextBox.Text == "")
                valor = 0;
            else
                valor = Convert.ToDecimal(ValorTextBox.Text);

            if (ValorTextBox.Text.Trim().Length > 0 && LogradoTextBox.Text.Trim().Length == 0)
            {
                PerdidoTextBox.Text = Convert.ToString(valor);
                PronosticoComboBox.SelectedIndex = EvaluacionBLL.CalcularPronostico(valor, 0);
            }
            else
            {
                PronosticoComboBox.SelectedIndex = EvaluacionBLL.CalcularPronostico(valor, logrado);
                PerdidoTextBox.Text = Convert.ToString(valor - logrado);
            }
            
        }

        private void LogradoTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal valor;
            decimal logrado;

            if (LogradoTextBox.Text == "")
                logrado = 0;
            else
                logrado = Convert.ToDecimal(LogradoTextBox.Text);

            if (ValorTextBox.Text == "")
                valor = 0;
            else
                valor = Convert.ToDecimal(ValorTextBox.Text);

            if (LogradoTextBox.Text.Trim().Length > 0 && ValorTextBox.Text.Trim().Length == 0)
            {
                PronosticoComboBox.SelectedIndex = EvaluacionBLL.CalcularPronostico(valor, 0);
                LogradoTextBox.Text = ValorTextBox.Text;
            }
            else
            {                
                if (logrado > valor)
                {
                    PronosticoComboBox.SelectedIndex = EvaluacionBLL.CalcularPronostico(valor, valor);
                    PerdidoTextBox.Text = Convert.ToString(valor);
                }
                else
                {
                    PronosticoComboBox.SelectedIndex = EvaluacionBLL.CalcularPronostico(valor, logrado);
                    PerdidoTextBox.Text = Convert.ToString(valor - logrado);
                }         
            }       
        }
    }
}
