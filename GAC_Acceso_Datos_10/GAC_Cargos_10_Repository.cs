using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_Cargos_10_Repository
    {
        //Crear registro
        public void NewCargo(CARGOS nuevoCargo)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CARGOS.Add(nuevoCargo);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateCargo(CARGOS atcCargo)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CARGOS.Attach(atcCargo);
                context.Entry(atcCargo).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteCargo(CARGOS borrarCargo)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CARGOS.Attach(borrarCargo);
                context.Entry(borrarCargo).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //listar registros
        public List<CARGOS> GetCargos()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listcargos = from listcargo in context.CARGOS select listcargo;
                return listcargos.ToList();

            }
        }

        //listar registros por id

        public List<CARGOS> GetCargos_id(int id_Cargo)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listcargos = from listcargo in context.CARGOS
                                    where listcargo.Id_cargo == id_Cargo
                                    select listcargo;
                return listcargos.ToList();

            }
        }

        //nombre completo
        /* public List<PacienteNombreCompleto> GetPacientes_NombreCompleto()
         {
             using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
             {
                 var listpacientes = from listpaciente in context.CARGOS select new PacienteNombreCompleto(Id_paciente=listpaciente.Id_paciente;
                 return listpacientes.ToList();

             }
         }*/

    }
}
