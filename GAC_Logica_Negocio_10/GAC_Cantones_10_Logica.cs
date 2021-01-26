using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Cantones_10_Logica
    {
        //agregar registro

        public void newCanton(CANTONES nuevoCanton)
        {
            GAC_Cantones_10_Repository datos = new GAC_Cantones_10_Repository();
            datos.NewCantones(nuevoCanton);
        }

        //actualizar registro
        public void updateCanton(CANTONES actCanton)
        {
            GAC_Cantones_10_Repository datos = new GAC_Cantones_10_Repository();
            datos.UpdateCanton(actCanton);
        }

        //eliminar registro
        public void deleteCanton(CANTONES borrarCanton) {
            GAC_Cantones_10_Repository datos = new GAC_Cantones_10_Repository();
            datos.DeleteCanton(borrarCanton);
        }

        //listar todos los registros

        public List<CANTONES>getCantones()
        {
            List<CANTONES> listcantones = new List<CANTONES>();
            GAC_Cantones_10_Repository datos = new GAC_Cantones_10_Repository();
            listcantones = datos.GetCantones();
            return listcantones;
        }

        //listar registros por id
        public List<CANTONES>getCantones_id(int idCanton)
        {
            List<CANTONES> listcantones = new List<CANTONES>();
            GAC_Cantones_10_Repository datos = new GAC_Cantones_10_Repository();
            listcantones = datos.GetCantones_id(idCanton);
            return listcantones;
        }
        public CANTONES get_Registro_Cantones(int registro_id)
        {
            CANTONES listaregistros = new CANTONES();
            GAC_Cantones_10_Repository datos = new GAC_Cantones_10_Repository();
            listaregistros = datos.get_Registro_Cantones(registro_id);
            return listaregistros;
        }
    }
}
