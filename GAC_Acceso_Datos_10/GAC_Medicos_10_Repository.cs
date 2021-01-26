using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;

namespace GAC_Acceso_Datos_10
{
    public class GAC_Medicos_10_Repository
    {
        //Crear registro
        public void NewMedico(MEDICOS nuevoMedico)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.MEDICOS.Add(nuevoMedico);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateMedico(MEDICOS atcMedico)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.MEDICOS.Attach(atcMedico);
                context.Entry(atcMedico).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteMedico(MEDICOS borrarMedico)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.MEDICOS.Attach(borrarMedico);
                context.Entry(borrarMedico).State = System.Data.Entity.EntityState.Deleted;
                
                context.SaveChanges();
            }
        }

        //listar registros
        public List<MEDICOS> GetMedicos()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listmedicos = from listmedico in context.MEDICOS select listmedico;
                return listmedicos.ToList();
            }
        }

        //listar registros por id

        public List<MEDICOS> GetMedicos_id(int id_Medico)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listmedicos = from listmedico in context.MEDICOS
                                    where listmedico.Id_medico == id_Medico
                                    select listmedico;
                return listmedicos.ToList();
            }
        }

        //listar registros nombre completo
        /* public List<Medico_NombreCompleto> GetMedico_NombreCompleto()
         {
             using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
             {
                 var listmedicos = from listmedico in context.MEDICOS select new Medico_NombreCompleto { Id_medico = listmedico.Id_medico, NombreCompleto = listmedico.Apellidos + " " + listmedico.Nombres};
                 return listmedicos.ToList();
             }
         }*/

        public MEDICOS get_Registro_Medicos(int registro_id)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var registros = from registro in context.MEDICOS
                                where registro.Id_medico == registro_id
                                select registro;
                return registros.First<MEDICOS>();
            }

        }
    }
}
