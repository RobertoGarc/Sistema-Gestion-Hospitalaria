using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_Especialidades_10_Repository
    {

        //Crear registro
        public void NewEspecialidad(ESPECIALIDADES nuevaEspecialidad)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.ESPECIALIDADES.Add(nuevaEspecialidad);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateEspecialidad(ESPECIALIDADES atcEspecialidad)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.ESPECIALIDADES.Attach(atcEspecialidad);
                context.Entry(atcEspecialidad).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteEspecialidad(ESPECIALIDADES borrarEspecialidad)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.ESPECIALIDADES.Attach(borrarEspecialidad);
                context.Entry(borrarEspecialidad).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //listar registros
        public List<ESPECIALIDADES> GetEspecialidades()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listespecialidades = from listespecialidad in context.ESPECIALIDADES select listespecialidad;
                return listespecialidades.ToList();

            }
        }

        //listar registros por id

        public List<ESPECIALIDADES> GetEspecialidades_id(int id_Especialidad)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listespecialidades = from listespecialidad in context.ESPECIALIDADES
                                    where listespecialidad.Id_especialidad == id_Especialidad
                                    select listespecialidad;
                return listespecialidades.ToList();

            }
        }

     
    }
}
