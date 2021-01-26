using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Tipo_Examen_10_Logica
    {
        //agregar registro

        public void newTipo_Examen(TIPO_EXAMENES nuevoTipo_examen)
        {
            GAC_Tipo_Examen_10_Repository datos = new GAC_Tipo_Examen_10_Repository();
            datos.NewTipo_Examen(nuevoTipo_examen);
        }

        //actualizar registro
        public void updateTipo_Examen(TIPO_EXAMENES actTipo_examen)
        {
            GAC_Tipo_Examen_10_Repository datos = new GAC_Tipo_Examen_10_Repository();
            datos.UpdateTipoExamen(actTipo_examen);
        }

        //eliminar registro
        public void deleteTipo_Examen(TIPO_EXAMENES borrarTipo_examen)
        {
            GAC_Tipo_Examen_10_Repository datos = new GAC_Tipo_Examen_10_Repository();
            datos.DeleteTipo_Examen(borrarTipo_examen);
        }

        //listar todos los registros

        public List<TIPO_EXAMENES>getTipo_Examen()
        {
            List<TIPO_EXAMENES> listtipo_examenes = new List<TIPO_EXAMENES>();
            GAC_Tipo_Examen_10_Repository datos = new GAC_Tipo_Examen_10_Repository();
            listtipo_examenes = datos.GetTipo_Examenes();
            return listtipo_examenes;
        }

        //listar registros por id
        public List<TIPO_EXAMENES>getTipo_Examen_id(int idTipo_examen)
        {
            List<TIPO_EXAMENES> listtipo_examen = new List<TIPO_EXAMENES>();
            GAC_Tipo_Examen_10_Repository datos = new GAC_Tipo_Examen_10_Repository();
            listtipo_examen = datos.GetTipo_Examenes_id(idTipo_examen);
            return listtipo_examen;
        }
    }
}
