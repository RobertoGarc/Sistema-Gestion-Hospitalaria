using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;

namespace GAC_Acceso_Datos_10
{
    public class GAC_Medico_Especialidad_10_Repository
    {
        //Crear registro
        public void NewMedico_Especialidad(MEDICO_ESPECIALIDAD nuevoMedico_Especialidad)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.MEDICO_ESPECIALIDAD.Add(nuevoMedico_Especialidad);
                context.SaveChanges();
            }
        }

        //actualizar
        public void UpdateMedico_Especialidad(MEDICO_ESPECIALIDAD atcMedico_Especialidad)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.MEDICO_ESPECIALIDAD.Attach(atcMedico_Especialidad);
                context.Entry(atcMedico_Especialidad).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        //eliminar
        public void DeleteMedico_Especialidad(MEDICO_ESPECIALIDAD borrarMedico_Especialidad)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                context.MEDICO_ESPECIALIDAD.Attach(borrarMedico_Especialidad);
                context.Entry(borrarMedico_Especialidad).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        //listar registros
        public List<MEDICO_ESPECIALIDAD> GetMedico_Especialidades()
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listmedico_especialidades = from listmedico_especialidad in context.MEDICO_ESPECIALIDAD select listmedico_especialidad;
                return listmedico_especialidades.ToList();

            }
        }

        //listar registros por id

        public List<MEDICO_ESPECIALIDAD> GetMedico_Especialidad_id(int id_Medico_Especialidad)
        {
            using (GestionHospitalariaEntities context = new GestionHospitalariaEntities())
            {
                var listmedicoespecialidades = from listmedicoespecialidad in context.MEDICO_ESPECIALIDAD
                                    where listmedicoespecialidad.Id_medespe == id_Medico_Especialidad
                                    select listmedicoespecialidad;
                return listmedicoespecialidades.ToList();

            }
        }

    

    }
}
