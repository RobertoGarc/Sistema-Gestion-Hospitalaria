using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_Examenes_10_Repository
    {
        //Crear registro
        public void NewExamen(EXAMENES nuevoExamen)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.EXAMENES.Add(nuevoExamen);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateExamen(EXAMENES atcExamen)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.EXAMENES.Attach(atcExamen);
                context.Entry(atcExamen).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteExamen(EXAMENES borrarExamen)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.EXAMENES.Attach(borrarExamen);
                context.Entry(borrarExamen).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //listar registros
        public List<EXAMENES> GetExamenes()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listexamenes = from listexamen in context.EXAMENES select listexamen;
                return listexamenes.ToList();

            }
        }

        //listar registros por id

        public List<EXAMENES> GetExamenes_id(int id_Examen)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listexamenes = from listexamen in context.EXAMENES
                                    where listexamen.Id_examen == id_Examen
                                    select listexamen;
                return listexamenes.ToList();

            }
        }

       

    }
}
