using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Provincias_10_Logica
    {
        //agregar registro

        public void newProvincia(PROVINCIAS nuevaProvincia)
        {
            GAC_PROVINCIAS_10_Repository datos = new GAC_PROVINCIAS_10_Repository();
            datos.NewProvincia(nuevaProvincia);
        }

        //actualizar registro
        public void updateProvincia(PROVINCIAS actProvincia)
        {
            GAC_PROVINCIAS_10_Repository datos = new GAC_PROVINCIAS_10_Repository();
            datos.UpdateProvincia(actProvincia);
        }

        //eliminar registro
        public void deleteProvincia(PROVINCIAS borrarProvincia)
        {
            GAC_PROVINCIAS_10_Repository datos = new GAC_PROVINCIAS_10_Repository();
            datos.DeleteProvincia(borrarProvincia);
        }

        //listar todos los registros

        public List<PROVINCIAS>getProvincias()
        {
            List<PROVINCIAS> listprovincias = new List<PROVINCIAS>();
            GAC_PROVINCIAS_10_Repository datos = new GAC_PROVINCIAS_10_Repository();
            listprovincias = datos.GetProvincias();
            return listprovincias;
        }

        //listar registros por id
        public List<PROVINCIAS> getProvincias_id(int idProvincia)
        {
            List<PROVINCIAS> listprovincias = new List<PROVINCIAS>();
            GAC_PROVINCIAS_10_Repository datos = new GAC_PROVINCIAS_10_Repository();
            listprovincias = datos.GetProvincias_id(idProvincia);
            return listprovincias;
        }
        public PROVINCIAS get_Registro_Provincias(int registro_id)
        {
            PROVINCIAS listaregistros = new PROVINCIAS();
            GAC_PROVINCIAS_10_Repository datos = new GAC_PROVINCIAS_10_Repository();
            listaregistros = datos.get_Registro_Provincias(registro_id);
            return listaregistros;
        }
    }
}
