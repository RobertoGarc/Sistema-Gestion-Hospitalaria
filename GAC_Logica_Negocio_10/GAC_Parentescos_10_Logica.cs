using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Parentescos_10_Logica
    {
        //agregar registro

        public void newParentesco(PARENTESCOS nuevoParentesco)
        {
            GAC_PARENTESCOS_10_Repository datos = new GAC_PARENTESCOS_10_Repository();
            datos.NewParentesco(nuevoParentesco);
        }

        //actualizar registro
        public void updateParentesco(PARENTESCOS actParentesco)
        {
            GAC_PARENTESCOS_10_Repository datos = new GAC_PARENTESCOS_10_Repository();
            datos.UpdateParentesco(actParentesco);
        }

        //eliminar registro
        public void deleteParentesco(PARENTESCOS borrarParentesco)
        {
            GAC_PARENTESCOS_10_Repository datos = new GAC_PARENTESCOS_10_Repository();
            datos.DeletePaciente(borrarParentesco);
        }

        //listar todos los registros

        public List<PARENTESCOS>GetParentescos()
        {
            List<PARENTESCOS> listparentescos = new List<PARENTESCOS>();
            GAC_PARENTESCOS_10_Repository datos = new GAC_PARENTESCOS_10_Repository();
            listparentescos = datos.GetParentescos();
            return listparentescos;
        }

        //listar registros por id
        public List<PARENTESCOS> getParentescos_id(int idParentesco)
        {
            List<PARENTESCOS> listparentescos = new List<PARENTESCOS>();
            GAC_PARENTESCOS_10_Repository datos = new GAC_PARENTESCOS_10_Repository();
            listparentescos = datos.GetParentescos_id(idParentesco);
            return listparentescos;
        }
    }
}
