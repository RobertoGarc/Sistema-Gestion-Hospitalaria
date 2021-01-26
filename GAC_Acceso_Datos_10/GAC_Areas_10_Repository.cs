using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_Areas_10_Repository
    {
        //Crear registro
        public void NewArea(AREAS nuevaArea)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.AREAS.Add(nuevaArea);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateArea(AREAS atcArea)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.AREAS.Attach(atcArea);
                context.Entry(atcArea).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteArea(AREAS borrarArea)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.AREAS.Attach(borrarArea);
                context.Entry(borrarArea).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //listar registros
        public List<AREAS> GetAreas()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listareas = from listarea in context.AREAS select listarea;
                return listareas.ToList();

            }
        }

        //listar registros por id

        public List<AREAS> GetArea_id(int id_Area)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listareas = from listarea in context.AREAS
                                     where listarea.Id_area == id_Area
                                     select listarea;
                return listareas.ToList();

            }
        }
    }
}

