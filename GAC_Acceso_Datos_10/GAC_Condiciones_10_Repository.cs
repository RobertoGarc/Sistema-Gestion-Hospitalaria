using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_Condiciones_10_Repository
    {
        //Crear registro
        public void NewCondicion(CONDICIONES nuevoCondicion)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CONDICIONES.Add(nuevoCondicion);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateCondicion(CONDICIONES atcCondicion)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CONDICIONES.Attach(atcCondicion);
                context.Entry(atcCondicion).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteCondicion(CONDICIONES borrarCondicion)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CONDICIONES.Attach(borrarCondicion);
                context.Entry(borrarCondicion).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //listar registros
        public List<CONDICIONES> GetCondiciones()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listcondiciones = from listcondicion in context.CONDICIONES select listcondicion;
                return listcondiciones.ToList();

            }
        }

        //listar registros por id

        public List<CONDICIONES> GetCondiciones_id(int id_Condicion)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listcondiciones = from listcondicion in context.CONDICIONES
                                    where listcondicion.Id_condicion == id_Condicion
                                    select listcondicion;
                return listcondiciones.ToList();
            }
        }

        

    }
}
