using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_PROVINCIAS_10_Repository
    {
        //Crear registro
        public void NewProvincia(PROVINCIAS nuevoProvincia)
        {
            using (GestionHospitalariaEntities context=new GestionHospitalariaEntities())
            {
                context.PROVINCIAS.Add(nuevoProvincia);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateProvincia(PROVINCIAS atcProvincia)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.PROVINCIAS.Attach(atcProvincia);
                context.Entry(atcProvincia).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteProvincia(PROVINCIAS borrarProvincia)
        {
            using(GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.PROVINCIAS.Attach(borrarProvincia);
                context.Entry(borrarProvincia).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            } 
        }

        //listar registros
        public List<PROVINCIAS> GetProvincias()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listprovincias = from listprovincia in context.PROVINCIAS select listprovincia;
                return listprovincias.ToList();

            }
        }

        //listar registros por id

        public List<PROVINCIAS> GetProvincias_id(int id_Provincia)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listprovincias = from listprovincia in context.PROVINCIAS where listprovincia.Id_provincia == id_Provincia
                                     select listprovincia;
                return listprovincias.ToList();

            }
        }
        public PROVINCIAS get_Registro_Provincias(int registro_id)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var registros = from registro in context.PROVINCIAS
                                where registro.Id_provincia == registro_id
                                select registro;
                return registros.First<PROVINCIAS>();
            }

        }
    }
}
