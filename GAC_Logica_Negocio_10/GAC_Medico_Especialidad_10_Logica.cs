using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Medico_Especialidad_10_Logica
    {
        //agregar registro

        public void newMedico_Especialidad(MEDICO_ESPECIALIDAD nuevoMedico_Especialidad)
        {
            GAC_Medico_Especialidad_10_Repository datos = new GAC_Medico_Especialidad_10_Repository();
            datos.NewMedico_Especialidad(nuevoMedico_Especialidad);
        }

        //actualizar registro
        public void updateMedico_Especialidad(MEDICO_ESPECIALIDAD actMedico_Especialidad)
        {
            GAC_Medico_Especialidad_10_Repository datos = new GAC_Medico_Especialidad_10_Repository();
            datos.UpdateMedico_Especialidad(actMedico_Especialidad);
        }

        //eliminar registro
        public void deleteMedico_Especialidad(MEDICO_ESPECIALIDAD borrarMedico_Especialidad)
        {
            GAC_Medico_Especialidad_10_Repository datos = new GAC_Medico_Especialidad_10_Repository();
            datos.DeleteMedico_Especialidad(borrarMedico_Especialidad);
        }

        //listar todos los registros

        public List<MEDICO_ESPECIALIDAD>getMedico_Especialidad()
        {
            List<MEDICO_ESPECIALIDAD> listmedico_especialidades = new List<MEDICO_ESPECIALIDAD>();
            GAC_Medico_Especialidad_10_Repository datos = new GAC_Medico_Especialidad_10_Repository();
            listmedico_especialidades = datos.GetMedico_Especialidades();
            return listmedico_especialidades;
        }

        //listar registros por id
        public List<MEDICO_ESPECIALIDAD>getMedico_Especialidad_id(int idMedico_Especialidad)
        {
            List<MEDICO_ESPECIALIDAD> listmedico_especialidades = new List<MEDICO_ESPECIALIDAD>();
            GAC_Medico_Especialidad_10_Repository datos = new GAC_Medico_Especialidad_10_Repository();
            listmedico_especialidades = datos.GetMedico_Especialidad_id(idMedico_Especialidad);
            return listmedico_especialidades;
        }
    }
}
