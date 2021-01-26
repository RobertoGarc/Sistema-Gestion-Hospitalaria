using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_Tipos_H_10_Repository
    {

        //Crear registro
        public void NewTipo_H(TIPOS_H nuevoTipo_H)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.TIPOS_H.Add(nuevoTipo_H);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateTipo_H(TIPOS_H atcTipo_H)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.TIPOS_H.Attach(atcTipo_H);
                context.Entry(atcTipo_H).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteTipo_H(TIPOS_H borrarTipo_H)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.TIPOS_H.Attach(borrarTipo_H);
                context.Entry(borrarTipo_H).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //listar registros
        public List<TIPOS_H> GetTipos_H()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listtipos_h = from listtipo_h in context.TIPOS_H select listtipo_h;
                return listtipos_h.ToList();

            }
        }

        //listar registros por id

        public List<TIPOS_H> GetTipos_H_id(int id_Tipo_H)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listtipos_h = from listtipo_h in context.TIPOS_H
                                    where listtipo_h.Id_tipoh == id_Tipo_H
                                    select listtipo_h;
                return listtipos_h.ToList();
            }
        }   
    }
}
