using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial1_Ap1.BLL;
using Parcial1_Ap1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_Ap1.BLL.Tests
{
    [TestClass()]
    public class EvaluacionBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Evaluacion evaluacion = new Evaluacion();
            evaluacion.Estudiante = "Martinsito";
            evaluacion.EvaluacionId = 8;
            evaluacion.Valor = 31;
            evaluacion.Logrado = 26;
            evaluacion.Perdido = 5;
            evaluacion.Pronostico = 0;
            evaluacion.Fecha = DateTime.Now;
            paso = EvaluacionBLL.Guardar(evaluacion);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Evaluacion evaluacion = new Evaluacion();
            evaluacion.Estudiante = "Martinsito";
            evaluacion.EvaluacionId = 2;
            evaluacion.Valor = 31;
            evaluacion.Logrado = 30;
            evaluacion.Perdido = 5;
            evaluacion.Pronostico = 0;
            evaluacion.Fecha = DateTime.Now;
            paso = EvaluacionBLL.Modificar(evaluacion);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = EvaluacionBLL.Eliminar(2);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso = false;
            Evaluacion evaluacion = new Evaluacion();
            evaluacion = EvaluacionBLL.Buscar(1);

            if (evaluacion != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CalcularPronosticoTest()
        {
            bool paso = false;
            int pronostico = EvaluacionBLL.CalcularPronostico(31,26);
            if (pronostico >= 0 && pronostico < 3)
                paso = true;

            Assert.AreEqual(paso, true);
        }
    }
}