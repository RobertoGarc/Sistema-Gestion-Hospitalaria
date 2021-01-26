using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_PARROQUIAS_10_Repository
    {
        //Crear registro
        public void NewParroquia(PARROQUIAS nuevoParroquia)
        {
            using (GestionHospitalariaEntities context=new GestionHospitalariaEntities())
            {
                context.PARROQUIAS.Add(nuevoParroquia);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateParroquia(PARROQUIAS atcParroquia)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.PARROQUIAS.Attach(atcParroquia);
                context.Entry(atcParroquia).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteParroquia(PARROQUIAS borrarParroquia)
        {
            using(GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.PARROQUIAS.Attach(borrarParroquia);
                context.Entry(borrarParroquia).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            } 
        }

        //listar registros
        public List<PARROQUIAS> GetParroquias()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listparroquias = from listparroquia in context.PARROQUIAS select listparroquia;
                return listparroquias.ToList();

            }
        }

        //listar registros por id

        public List<PARROQUIAS> GetParroquias_id(int id_Parroquia)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listparroquias = from listparroquia in context.PARROQUIAS where listparroquia.Id_parroquia == id_Parroquia
                                     select listparroquia;
                return listparroquias.ToList();

            }
        }
        public PARROQUIAS get_Registro_Parroquias(int registro_id)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var registros = from registro in context.PARROQUIAS
                                where registro.Id_parroquia == registro_id
                                select registro;
                return registros.First<PARROQUIAS>();
            }

        }
    }
}
