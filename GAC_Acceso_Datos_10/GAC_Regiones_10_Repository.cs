using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_REGIONES_10_Repository
    {
        //Crear registro
        public void NewRegion(REGIONES nuevoRegion)
        {
            using (GestionHospitalariaEntities context=new GestionHospitalariaEntities())
            {
                context.REGIONES.Add(nuevoRegion);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateRegion(REGIONES atcRegion)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.REGIONES.Attach(atcRegion);
                context.Entry(atcRegion).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteRegion(REGIONES borrarRegion)
        {
            using(GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.REGIONES.Attach(borrarRegion);
                context.Entry(borrarRegion).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            } 
        }

        //listar registros
        public List<REGIONES> GetRegiones()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listregiones = from listregion in context.REGIONES select listregion;
                return listregiones.ToList();

            }
        }

        //listar registros por id

        public List<REGIONES> GetRegiones_id(int id_Region)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listregiones = from listregion in context.REGIONES where listregion.Id_region == id_Region
                                     select listregion;
                return listregiones.ToList();

            }
        }

    }
}
