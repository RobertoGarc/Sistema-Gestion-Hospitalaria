using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Cargos_10_Logica
    {
        //agregar registro

        public void newCargo(CARGOS nuevoCargo)
        {
            GAC_Cargos_10_Repository datos = new GAC_Cargos_10_Repository();
            datos.NewCargo(nuevoCargo);
        }

        //actualizar registro
        public void updateCargo(CARGOS actCargo)
        {
            GAC_Cargos_10_Repository datos = new GAC_Cargos_10_Repository();
            datos.UpdateCargo(actCargo);
        }

        //eliminar registro
        public void deleteCargo(CARGOS borrarCargo)
        {
            GAC_Cargos_10_Repository datos = new GAC_Cargos_10_Repository();
            datos.DeleteCargo(borrarCargo);
        }

        //listar todos los registros

        public List<CARGOS>getCargos()
        {
            List<CARGOS> listcargos = new List<CARGOS>();
            GAC_Cargos_10_Repository datos = new GAC_Cargos_10_Repository();
            listcargos = datos.GetCargos();
            return listcargos;
        }

        //listar registros por id
        public List<CARGOS>getCargos_id(int idCargo)
        {
            List<CARGOS> listcargos = new List<CARGOS>();
            GAC_Cargos_10_Repository datos = new GAC_Cargos_10_Repository();
            listcargos = datos.GetCargos_id(idCargo);
            return listcargos;
        }
    }
}
