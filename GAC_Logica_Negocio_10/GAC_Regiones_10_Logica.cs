using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Regiones_10_Logica
    {
        //agregar registro

        public void newRegion(REGIONES nuevaRegion)
        {
            GAC_REGIONES_10_Repository datos = new GAC_REGIONES_10_Repository();
            datos.NewRegion(nuevaRegion);
        }

        //actualizar registro
        public void updateRegion(REGIONES actRegion)
        {
            GAC_REGIONES_10_Repository datos = new GAC_REGIONES_10_Repository();
            datos.UpdateRegion(actRegion);
        }

        //eliminar registro
        public void deleteRegion(REGIONES borrarRegion)
        {
            GAC_REGIONES_10_Repository datos = new GAC_REGIONES_10_Repository();
            datos.DeleteRegion(borrarRegion);
        }

        //listar todos los registros

        public List<REGIONES>getRegiones()
        {
            List<REGIONES> listregiones = new List<REGIONES>();
            GAC_REGIONES_10_Repository datos = new GAC_REGIONES_10_Repository();
            listregiones = datos.GetRegiones();
            return listregiones;
        }

        //listar registros por id
        public List<REGIONES>getRegiones_id(int idRegion)
        {
            List<REGIONES> listregiones = new List<REGIONES>();
            GAC_REGIONES_10_Repository datos = new GAC_REGIONES_10_Repository();
            listregiones = datos.GetRegiones_id(idRegion);
            return listregiones;
        }
    }
}
