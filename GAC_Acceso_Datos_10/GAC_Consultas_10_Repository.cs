using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_Consultas_10_Repository
    {
        //Crear registro
        public void NewConsulta(CONSULTAS nuevaConsulta)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CONSULTAS.Add(nuevaConsulta);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateConsulta(CONSULTAS atcConsulta)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CONSULTAS.Attach(atcConsulta);
                context.Entry(atcConsulta).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteConsulta(CONSULTAS borrarConsulta)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CONSULTAS.Attach(borrarConsulta);
                context.Entry(borrarConsulta).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //listar registros
        public List<CONSULTAS> GetConsultas()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listconsultas = from listconsulta in context.CONSULTAS select listconsulta;
                return listconsultas.ToList();

            }
        }

        //listar registros por id

        public List<CONSULTAS> GetConsultas_id(int id_Consulta)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listconsultas = from listconsulta in context.CONSULTAS
                                    where listconsulta.Id_consulta == id_Consulta
                                    select listconsulta;
                return listconsultas.ToList();

            }
        }

    }
}
