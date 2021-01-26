using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Receta_10_Logica
    {
        //agregar registro

        public void newReceta(RECETA nuevaReceta)
        {
            GAC_RECETA_10_Repository datos = new GAC_RECETA_10_Repository();
            datos.NewReceta(nuevaReceta);
        }

        //actualizar registro
        public void updateReceta(RECETA actReceta)
        {
            GAC_RECETA_10_Repository datos = new GAC_RECETA_10_Repository();
            datos.UpdateReceta(actReceta);
        }

        //eliminar registro
        public void deleteReceta(RECETA borrarReceta)
        {
            GAC_RECETA_10_Repository datos = new GAC_RECETA_10_Repository();
            datos.DeleteReceta(borrarReceta);
        }

        //listar todos los registros

        public List<RECETA>getReceta()
        {
            List<RECETA> listreceta = new List<RECETA>();
            GAC_RECETA_10_Repository datos = new GAC_RECETA_10_Repository();
            listreceta = datos.GetReceta();
            return listreceta;
        }

        //listar registros por id
        public List<RECETA>getReceta_id(int idReceta)
        {
            List<RECETA> listreceta = new List<RECETA>();
            GAC_RECETA_10_Repository datos = new GAC_RECETA_10_Repository();
            listreceta = datos.GetReceta_id(idReceta);
            return listreceta;
        }
    }
}
