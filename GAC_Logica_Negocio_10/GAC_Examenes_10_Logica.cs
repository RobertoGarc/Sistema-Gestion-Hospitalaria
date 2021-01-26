using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Examenes_10_Logica
    {
        //agregar registro

        public void newExamen(EXAMENES nuevoExamen)
        {
            GAC_Examenes_10_Repository datos = new GAC_Examenes_10_Repository();
            datos.NewExamen(nuevoExamen);
        }

        //actualizar registro
        public void updateExamen(EXAMENES actExamen)
        {
            GAC_Examenes_10_Repository datos = new GAC_Examenes_10_Repository();
            datos.UpdateExamen(actExamen);
        }

        //eliminar registro
        public void deleteExamen(EXAMENES borrarExamen)
        {
            GAC_Examenes_10_Repository datos = new GAC_Examenes_10_Repository();
            datos.DeleteExamen(borrarExamen);
        }

        //listar todos los registros

        public List<EXAMENES>getExamenes()
        {
            List<EXAMENES> listexamenes = new List<EXAMENES>();
            GAC_Examenes_10_Repository datos = new GAC_Examenes_10_Repository();
            listexamenes = datos.GetExamenes();
            return listexamenes;
        }

        //listar registros por id
        public List<EXAMENES>getExamenes_id(int idExamen)
        {
            List<EXAMENES> listexamenes = new List<EXAMENES>();
            GAC_Examenes_10_Repository datos = new GAC_Examenes_10_Repository();
            listexamenes = datos.GetExamenes_id(idExamen);
            return listexamenes;
        }

     
    }
}
