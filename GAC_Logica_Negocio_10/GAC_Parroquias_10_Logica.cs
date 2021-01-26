using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Parroquias_10_Logica
    {
        //agregar registro

        public void newParroquia(PARROQUIAS nuevaParroquia)
        {
            GAC_PARROQUIAS_10_Repository datos = new GAC_PARROQUIAS_10_Repository();
            datos.NewParroquia(nuevaParroquia);
        }

        //actualizar registro
        public void updateParroquia(PARROQUIAS actParroquia)
        {
            GAC_PARROQUIAS_10_Repository datos = new GAC_PARROQUIAS_10_Repository();
            datos.UpdateParroquia(actParroquia);
        }

        //eliminar registro
        public void deleteParroquia(PARROQUIAS borrarParroquia)
        {
            GAC_PARROQUIAS_10_Repository datos = new GAC_PARROQUIAS_10_Repository();
            datos.DeleteParroquia(borrarParroquia);
        }

        //listar todos los registros

        public List<PARROQUIAS>getParroquias()
        {
            List<PARROQUIAS> listparroquias = new List<PARROQUIAS>();
            GAC_PARROQUIAS_10_Repository datos = new GAC_PARROQUIAS_10_Repository();
            listparroquias = datos.GetParroquias();
            return listparroquias;
        }

        //listar registros por id
        public List<PARROQUIAS> getParroquias_id(int idParroquia)
        {
            List<PARROQUIAS> listparroquias = new List<PARROQUIAS>();
            GAC_PARROQUIAS_10_Repository datos = new GAC_PARROQUIAS_10_Repository();
            listparroquias = datos.GetParroquias_id(idParroquia);
            return listparroquias;
        }
        public PARROQUIAS get_Registro_Parroquias(int registro_id)
        {
            PARROQUIAS listaregistros = new PARROQUIAS();
            GAC_PARROQUIAS_10_Repository datos = new GAC_PARROQUIAS_10_Repository();
            listaregistros = datos.get_Registro_Parroquias(registro_id);
            return listaregistros;
        }
    }
}
