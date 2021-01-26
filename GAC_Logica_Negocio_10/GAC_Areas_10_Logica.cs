using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Areas_10_Logica
    {
        //agregar registro

        public void newArea(AREAS nuevoArea)
        {
            GAC_Areas_10_Repository datos = new GAC_Areas_10_Repository();
            datos.NewArea(nuevoArea);
        }

        //actualizar registro
        public void updateArea(AREAS actArea)
        {
            GAC_Areas_10_Repository datos = new GAC_Areas_10_Repository();
            datos.UpdateArea(actArea);
        }

        //eliminar registro
        public void deleteArea(AREAS borrarArea)
        {
            GAC_Areas_10_Repository datos = new GAC_Areas_10_Repository();
            datos.DeleteArea(borrarArea);
        }

        //listar todos los registros

        public List<AREAS>getAreas()
        {
            List<AREAS> listareas = new List<AREAS>();
            GAC_Areas_10_Repository datos = new GAC_Areas_10_Repository();
            listareas = datos.GetAreas();
            return listareas;
        }

        //listar registros por id
        public List<AREAS>getAreas_id(int idArea)
        {
            List<AREAS> listareas = new List<AREAS>();
            GAC_Areas_10_Repository datos = new GAC_Areas_10_Repository();
            listareas = datos.GetArea_id(idArea);
            return listareas;
        }
    }
}
