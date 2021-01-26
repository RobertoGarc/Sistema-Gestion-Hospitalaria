using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Especialidades_10_Logica
    {
        //agregar registro

        public void newEspecialidad(ESPECIALIDADES nuevoEspecialidad)
        {
            GAC_Especialidades_10_Repository datos = new GAC_Especialidades_10_Repository();
            datos.NewEspecialidad(nuevoEspecialidad);
        }

        //actualizar registro
        public void updateEspecialidad(ESPECIALIDADES actEspecialidad)
        {
            GAC_Especialidades_10_Repository datos = new GAC_Especialidades_10_Repository();
            datos.UpdateEspecialidad(actEspecialidad);
        }

        //eliminar registro
        public void deleteEspecialidad(ESPECIALIDADES borrarEspecialidad)
        {
            GAC_Especialidades_10_Repository datos = new GAC_Especialidades_10_Repository();
            datos.DeleteEspecialidad(borrarEspecialidad);
        }

        //listar todos los registros

        public List<ESPECIALIDADES>getEspecialidadees()
        {
            List<ESPECIALIDADES> listespecialidades = new List<ESPECIALIDADES>();
            GAC_Especialidades_10_Repository datos = new GAC_Especialidades_10_Repository();
            listespecialidades = datos.GetEspecialidades();
            return listespecialidades;
        }

        //listar registros por id
        public List<ESPECIALIDADES>getEspecialidades_id(int idEspecialidad)
        {
            List<ESPECIALIDADES> listespecialidades = new List<ESPECIALIDADES>();
            GAC_Especialidades_10_Repository datos = new GAC_Especialidades_10_Repository();
            listespecialidades = datos.GetEspecialidades_id(idEspecialidad);
            return listespecialidades;
        }
    }
}
