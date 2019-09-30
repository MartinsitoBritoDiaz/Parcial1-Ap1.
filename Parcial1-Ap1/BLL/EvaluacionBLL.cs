using Parcial1_Ap1.DAL;
using Parcial1_Ap1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_Ap1.BLL
{
    public class EvaluacionBLL
    {
        public static bool Guardar(Evaluacion evaluacion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                evaluacion.Pronostico = CalcularPronostico(evaluacion.Valor, evaluacion.Logrado);
                evaluacion.Perdido = evaluacion.Valor - evaluacion.Logrado;

                if (db.Evaluacion.Add(evaluacion) != null)
                    paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Evaluacion evaluacion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                evaluacion.Perdido = evaluacion.Valor - evaluacion.Logrado;
                evaluacion.Pronostico = CalcularPronostico(evaluacion.Valor, evaluacion.Logrado);
                db.Entry(evaluacion).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var evaluacion = db.Evaluacion.Find(id);
                db.Entry(evaluacion).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static Evaluacion Buscar(int id)
        {
            Contexto db = new Contexto();
            Evaluacion evaluacion = new Evaluacion();

            try
            {
                evaluacion = db.Evaluacion.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return evaluacion;
        }

        public static List<Evaluacion> GetList(Expression<Func<Evaluacion, bool>> evaluacion)
        {
            List<Evaluacion> listado = new List<Evaluacion>();
            Contexto db = new Contexto();

            try
            {
                listado = db.Evaluacion.Where(evaluacion).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return listado;
        }

        public static int CalcularPronostico(decimal valor, decimal logrado)
        {
            if (valor == 0)
                valor = 1;

            decimal promedio = (((valor - logrado) * 100) / valor);
            int indice = 0;

            if (promedio < 25)
                indice = 0;

            if (promedio >= 25 && promedio <= 30)
                indice = 1;

            if (promedio > 30)
                indice = 2;

            
            return indice;
        }
    }
}
