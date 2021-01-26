using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_Tipo_Examen_10_Repository
    {
        //Crear registro
        public void NewTipo_Examen(TIPO_EXAMENES nuevoTipo_Examen)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.TIPO_EXAMENES.Add(nuevoTipo_Examen);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateTipoExamen(TIPO_EXAMENES atcTipo_Examen)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.TIPO_EXAMENES.Attach(atcTipo_Examen);
                context.Entry(atcTipo_Examen).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteTipo_Examen(TIPO_EXAMENES borrarTipo_Examen)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.TIPO_EXAMENES.Attach(borrarTipo_Examen);
                context.Entry(borrarTipo_Examen).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //listar registros
        public List<TIPO_EXAMENES> GetTipo_Examenes()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listexamenes = from listexamen in context.TIPO_EXAMENES select listexamen;
                return listexamenes.ToList();

            }
        }

        //listar registros por id

        public List<TIPO_EXAMENES> GetTipo_Examenes_id(int id_Tipo_Examen)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listtipoexamenes = from listtipoexamen in context.TIPO_EXAMENES
                                    where listtipoexamen.Id_examen == id_Tipo_Examen
                                    select listtipoexamen;
                return listtipoexamenes.ToList();
            }
        }

    }
}
