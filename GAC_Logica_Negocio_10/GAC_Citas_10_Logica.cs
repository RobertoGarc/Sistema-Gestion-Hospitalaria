using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Citas_10_Logica
    {
        //agregar registro

        public void newCita(CITAS nuevoCita)
        {
            GAC_Citas_10_Repository datos = new GAC_Citas_10_Repository();
            datos.NewCita(nuevoCita);
        }

        //actualizar registro
        public void updateCita(CITAS actCita)
        {
            GAC_Citas_10_Repository datos = new GAC_Citas_10_Repository();
            datos.UpdateCita(actCita);
        }

        //eliminar registro
        public void deleteCita(CITAS borrarCita)
        {
            GAC_Citas_10_Repository datos = new GAC_Citas_10_Repository();
            datos.DeleteCita(borrarCita);
        }

        //listar todos los registros

        public List<CITAS>getCitas()
        {
            List<CITAS> listcitas = new List<CITAS>();
            GAC_Citas_10_Repository datos = new GAC_Citas_10_Repository();
            listcitas = datos.GetCitas();
            return listcitas;
        }

        //listar registros por id
        public List<CITAS>getCitas_id(int idCita)
        {
            List<CITAS> listcitas = new List<CITAS>();
            GAC_Citas_10_Repository datos = new GAC_Citas_10_Repository();
            listcitas = datos.GetCitas_id(idCita);
            return listcitas;
        }

        public CITAS get_Registro_Cita(int registro_id)
        {
            CITAS listaregistros = new CITAS();
            GAC_Citas_10_Repository datos = new GAC_Citas_10_Repository();
            listaregistros = datos.get_Registro_Citas(registro_id);
            return listaregistros;
        }
    }
}
