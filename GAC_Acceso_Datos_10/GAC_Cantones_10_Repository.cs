using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;

namespace GAC_Acceso_Datos_10
{
    public class GAC_Cantones_10_Repository
    {
        //Crear registro
        public void NewCantones(CANTONES nuevoCanton)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CANTONES.Add(nuevoCanton);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateCanton(CANTONES atcCanton)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CANTONES.Attach(atcCanton);
                context.Entry(atcCanton).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteCanton(CANTONES borrarCanton)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CANTONES.Attach(borrarCanton);
                context.Entry(borrarCanton).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //listar registros
        public List<CANTONES> GetCantones()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listcantones = from listcanton in context.CANTONES select listcanton;
                return listcantones.ToList();

            }
        }

        //listar registros por id

        public List<CANTONES> GetCantones_id(int id_Canton)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listcantones = from listcanton in context.CANTONES
                                     where listcanton.Id_canton == id_Canton
                                     select listcanton;
                return listcantones.ToList();
            }
        }

        public CANTONES get_Registro_Cantones(int registro_id)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var registros = from registro in context.CANTONES
                                where registro.Id_canton == registro_id
                                select registro;
                return registros.First<CANTONES>();
            }

        }

    }
}
