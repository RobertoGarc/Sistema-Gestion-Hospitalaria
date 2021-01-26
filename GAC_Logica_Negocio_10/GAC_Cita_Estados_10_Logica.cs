using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Cita_Estados_10_Logica
    {
        //agregar registro

        public void newCita_Estado(CITA_ESTADOS nuevoCita_Estado)
        {
            GAC_Cita_Estados_10_Repository datos = new GAC_Cita_Estados_10_Repository();
            datos.NewCitaEstados(nuevoCita_Estado);
        }

        //actualizar registro
        public void updateCita_Estado(CITA_ESTADOS actCita_Estado)
        {
            GAC_Cita_Estados_10_Repository datos = new GAC_Cita_Estados_10_Repository();
            datos.UpdateCitaEstados(actCita_Estado);
        }

        //eliminar registro
        public void deleteCita_Estado(CITA_ESTADOS borrarCita_Estado)
        {
            GAC_Cita_Estados_10_Repository datos = new GAC_Cita_Estados_10_Repository();
            datos.DeleteCitaEstados(borrarCita_Estado);
        }

        //listar todos los registros

        public List<CITA_ESTADOS>getCita_Estados()
        {
            List<CITA_ESTADOS> listcita_Estados = new List<CITA_ESTADOS>();
            GAC_Cita_Estados_10_Repository datos = new GAC_Cita_Estados_10_Repository();
            listcita_Estados = datos.GetCitaEstados();
            return listcita_Estados;
        }

        //listar registros por id
        public List<CITA_ESTADOS>getCita_Estado_id(int idCita_Estado)
        {
            List<CITA_ESTADOS> listcita_estados = new List<CITA_ESTADOS>();
            GAC_Cita_Estados_10_Repository datos = new GAC_Cita_Estados_10_Repository();
            listcita_estados = datos.GetCitaEstados_id(idCita_Estado);
            return listcita_estados;
        }
    }
}
