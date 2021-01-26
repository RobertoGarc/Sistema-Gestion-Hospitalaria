using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Condiciones_10_Logica
    {
        //agregar registro

        public void newCondicion(CONDICIONES nuevoCondicion)
        {
            GAC_Condiciones_10_Repository datos = new GAC_Condiciones_10_Repository();
            datos.NewCondicion(nuevoCondicion);
        }

        //actualizar registro
        public void updateCondicion(CONDICIONES actCondicion)
        {
            GAC_Condiciones_10_Repository datos = new GAC_Condiciones_10_Repository();
            datos.UpdateCondicion(actCondicion);
        }

        //eliminar registro
        public void deleteCondicion(CONDICIONES borrarCondicion)
        {
            GAC_Condiciones_10_Repository datos = new GAC_Condiciones_10_Repository();
            datos.DeleteCondicion (borrarCondicion);
        }

        //listar todos los registros

        public List<CONDICIONES>getCondiciones()
        {
            List<CONDICIONES> listcondiciones = new List<CONDICIONES>();
            GAC_Condiciones_10_Repository datos = new GAC_Condiciones_10_Repository();
            listcondiciones = datos.GetCondiciones();
            return listcondiciones;
        }

        //listar registros por id
        public List<CONDICIONES>getCondiciones_id(int idCondicion)
        {
            List<CONDICIONES> listcondiciones = new List<CONDICIONES>();
            GAC_Condiciones_10_Repository datos = new GAC_Condiciones_10_Repository();
            listcondiciones = datos.GetCondiciones_id(idCondicion);
            return listcondiciones;
        }
    }
}
