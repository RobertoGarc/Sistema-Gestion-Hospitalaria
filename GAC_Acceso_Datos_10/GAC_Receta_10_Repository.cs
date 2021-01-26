using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_RECETA_10_Repository
    {
        //Crear registro
        public void NewReceta(RECETA nuevoReceta)
        {
            using (GestionHospitalariaEntities context=new GestionHospitalariaEntities())
            {
                context.RECETA.Add(nuevoReceta);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateReceta(RECETA atcReceta)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.RECETA.Attach(atcReceta);
                context.Entry(atcReceta).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteReceta(RECETA borrarReceta)
        {
            using(GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.RECETA.Attach(borrarReceta);
                context.Entry(borrarReceta).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            } 
        }

        //listar registros
        public List<RECETA> GetReceta()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listrecetas = from listreceta in context.RECETA select listreceta;
                return listrecetas.ToList();

            }
        }

        //listar registros por id

        public List<RECETA> GetReceta_id(int id_Receta)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listrecetas = from listreceta in context.RECETA where listreceta.Id_receta == id_Receta
                                     select listreceta;
                return listrecetas.ToList();

            }
        }

    }
}
