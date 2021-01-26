using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;

namespace GAC_Acceso_Datos_10
{
    public class GAC_Pacientes_10_Repository
    {

        //Crear Registro

        public void NewPaciente(PACIENTES nuevoPaciente)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {

                context.PACIENTES.Add(nuevoPaciente);
                context.SaveChanges();
            }

        }

        //Actualizar Registro
        public void updatePaciente(PACIENTES actPaciente)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.PACIENTES.Attach(actPaciente);
                context.Entry(actPaciente).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //Eliminar Registro

        public void deletePaciente(PACIENTES borrarPaciente)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.PACIENTES.Attach(borrarPaciente);
                context.Entry(borrarPaciente).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }

        }

        //Listar Registro

        public List<PACIENTES> getPacientes()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listpacientes = from listpaciente in context.PACIENTES
                                    select listpaciente;
                return listpacientes.ToList();
            }
        }
        // Listar Registro por ID

        public List<PACIENTES> getPacientes_id(int id_Paciente)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listpacientes = from listpaciente in context.PACIENTES
                                    where listpaciente.Id_paciente == id_Paciente
                                    select listpaciente;
                return listpacientes.ToList();
            }
        }

        //Listar Registro Nombre Completo

        public List<Paciente_NombreCompleto> getPacientes_NombreCompleto()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listpacientes = from listpaciente in context.PACIENTES

                                    select new Paciente_NombreCompleto{Id_paciente=listpaciente.Id_paciente,NombreCompleto=listpaciente.Apellido1+" "+listpaciente.Apellido2+" "+listpaciente.Nombre1+" "+listpaciente.Nombre2};
                return listpacientes.ToList();
            }
        }

        public PACIENTES get_Registro_Pacientes(int registro_id)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var registros = from registro in context.PACIENTES
                                where registro.Id_paciente == registro_id
                                select registro;
                return registros.First<PACIENTES>();
            }

        }





    }
}
