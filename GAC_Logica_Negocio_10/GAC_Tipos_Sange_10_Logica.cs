using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Tipos_Sange_10_Logica
    {
        //agregar registro

        public void newTipo_Sange(TIPOS_SANGE nuevoTipo_sange)
        {
            GAC_Tipos_Sange_10_Repository datos = new GAC_Tipos_Sange_10_Repository();
            datos.NewTipo_Sangre(nuevoTipo_sange);
        }

        //actualizar registro
        public void updateTipo_Sange(TIPOS_SANGE actTipo_sange)
        {
            GAC_Tipos_Sange_10_Repository datos = new GAC_Tipos_Sange_10_Repository();
            datos.UpdateTipo_Sange(actTipo_sange);
        }

        //eliminar registro
        public void deleteTipo_Sange(TIPOS_SANGE borrarTipo_sange)
        {
            GAC_Tipos_Sange_10_Repository datos = new GAC_Tipos_Sange_10_Repository();
            datos.DeleteTipo_Sange(borrarTipo_sange);
        }

        //listar todos los registros

        public List<TIPOS_SANGE>getTipo_Sange()
        {
            List<TIPOS_SANGE> listtipo_sange = new List<TIPOS_SANGE>();
            GAC_Tipos_Sange_10_Repository datos = new GAC_Tipos_Sange_10_Repository();
            listtipo_sange = datos.GetTipos_Sange();
            return listtipo_sange;
        }

        //listar registros por id
        public List<TIPOS_SANGE>getTipo_Sange_id(int idSange)
        {
            List<TIPOS_SANGE> listtipo_sange = new List<TIPOS_SANGE>();
            GAC_Tipos_Sange_10_Repository datos = new GAC_Tipos_Sange_10_Repository();
            listtipo_sange = datos.GetTipos_Sange_id(idSange);
            return listtipo_sange;
        }
    }
}
