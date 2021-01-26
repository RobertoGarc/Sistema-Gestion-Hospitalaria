using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_Cita_Estados_10_Repository
    {
        //Crear registro
        public void NewCitaEstados(CITA_ESTADOS nuevoCitaEstados)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CITA_ESTADOS.Add(nuevoCitaEstados);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateCitaEstados(CITA_ESTADOS atcCitaEstados)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CITA_ESTADOS.Attach(atcCitaEstados);
                context.Entry(atcCitaEstados).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteCitaEstados(CITA_ESTADOS borrarCitaEstados)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CITA_ESTADOS.Attach(borrarCitaEstados);
                context.Entry(borrarCitaEstados).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //listar registros
        public List<CITA_ESTADOS> GetCitaEstados()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listcitaestados = from listcitaestado in context.CITA_ESTADOS select listcitaestado;
                return listcitaestados.ToList();

            }
        }

        //listar registros por id

        public List<CITA_ESTADOS> GetCitaEstados_id(int id_CitaEstados)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listcitaestados = from listcitaestado in context.CITA_ESTADOS
                                    where listcitaestado.Id_estado == id_CitaEstados
                                    select listcitaestado;
                return listcitaestados.ToList();

            }
        }

        //nombre completo
        /* public List<PacienteNombreCompleto> GetPacientes_NombreCompleto()
         {
             using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
             {
                 var listpacientes = from listpaciente in context.CITAESTADOS select new PacienteNombreCompleto(Id_paciente=listpaciente.Id_paciente;
                 return listpacientes.ToList();

             }
         }*/

    }
}
