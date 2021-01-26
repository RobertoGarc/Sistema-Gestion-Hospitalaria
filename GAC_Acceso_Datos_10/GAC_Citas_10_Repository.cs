using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
namespace GAC_Acceso_Datos_10
{
    public class GAC_Citas_10_Repository
    {
        //Crear registro
        public void NewCita(CITAS nuevaCita)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CITAS.Add(nuevaCita);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateCita(CITAS atcCita)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CITAS.Attach(atcCita);
                context.Entry(atcCita).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteCita(CITAS borrarCita)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.CITAS.Attach(borrarCita);
                context.Entry(borrarCita).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //listar registros
        public List<CITAS> GetCitas()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listcitas = from listcita in context.CITAS select listcita;
                return listcitas.ToList();

            }
        }

        //listar registros por id

        public List<CITAS> GetCitas_id(int id_Cita)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listcitas = from listcita in context.CITAS
                                    where listcita.Id_cita == id_Cita
                                    select listcita;
                return listcitas.ToList();

            }
        }
        public CITAS get_Registro_Citas(int registro_id)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var registros = from registro in context.CITAS
                                where registro.Id_cita == registro_id
                                select registro;
                return registros.First<CITAS>();
            }

        }


    }
}
