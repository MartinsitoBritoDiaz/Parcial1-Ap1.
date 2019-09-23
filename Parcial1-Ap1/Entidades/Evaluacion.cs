using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_Ap1.Entidades
{
    public class Evaluacion
    {
        [Key]
        public int EvaluacionId { get; set; }
        public DateTime Fecha { get; set; }

        public string Estudiante { get; set; }

        public decimal Logrado { get; set; }
        public decimal Perdido { get; set; }

        public decimal Valor { get; set; }

        public int Pronostico { get; set; }

        public Evaluacion()
        {
            EvaluacionId = 0;
            Fecha = DateTime.Now;
            Estudiante = "";
            Logrado = 0;
            Perdido = 0;
            Valor = 0;
            Pronostico = 0;
        }
    }
}
