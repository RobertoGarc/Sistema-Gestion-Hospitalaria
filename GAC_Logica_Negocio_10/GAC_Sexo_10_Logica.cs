using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Sexo_10_Logica
    {
        //agregar registro

        public void newSexo(SEXO nuevoSexo)
        {
            GAC_SEXO_10_Repository datos = new GAC_SEXO_10_Repository();
            datos.NewSexo(nuevoSexo);
        }

        //actualizar registro
        public void updateSexo(SEXO actSexo)
        {
            GAC_SEXO_10_Repository datos = new GAC_SEXO_10_Repository();
            datos.UpdateSexo(actSexo);
        }

        //eliminar registro
        public void deleteSexo(SEXO borrarSexo)
        {
            GAC_SEXO_10_Repository datos = new GAC_SEXO_10_Repository();
            datos.DeleteSexo(borrarSexo);
        }

        //listar todos los registros

        public List<SEXO>getSexos()
        {
            List<SEXO> listsexos = new List<SEXO>();
            GAC_SEXO_10_Repository datos = new GAC_SEXO_10_Repository();
            listsexos = datos.GetSexos();
            return listsexos;
        }

        //listar registros por id
        public List<SEXO>getSexos_id(int idSexo)
        {
            List<SEXO> listsexos = new List<SEXO>();
            GAC_SEXO_10_Repository datos = new GAC_SEXO_10_Repository();
            listsexos = datos.GetSexos_id(idSexo);
            return listsexos;
        }
    }
}
