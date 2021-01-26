using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_Tipos_Sange_10_Repository
    {
        //Crear registro
        public void NewTipo_Sangre(TIPOS_SANGE nuevoTipo_Sange)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.TIPOS_SANGE.Add(nuevoTipo_Sange);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateTipo_Sange(TIPOS_SANGE atcTipo_Sange)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.TIPOS_SANGE.Attach(atcTipo_Sange);
                context.Entry(atcTipo_Sange).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteTipo_Sange(TIPOS_SANGE borrarTipo_Sange)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.TIPOS_SANGE.Attach(borrarTipo_Sange);
                context.Entry(borrarTipo_Sange).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //listar registros
        public List<TIPOS_SANGE> GetTipos_Sange()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listtipos_sange = from listtipo_sange in context.TIPOS_SANGE select listtipo_sange;
                return listtipos_sange.ToList();
            }
        }

        //listar registros por id

        public List<TIPOS_SANGE> GetTipos_Sange_id(int id_Tipos_Sange)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listtipos_sange = from listtipo_sange in context.TIPOS_SANGE
                                    where listtipo_sange.Id_tipos == id_Tipos_Sange
                                    select listtipo_sange;
                return listtipos_sange.ToList();
            }
        }

    }
}
