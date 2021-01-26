using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Consultas_10_Logica
    {
        //agregar registro

        public void newConsulta(CONSULTAS nuevoConsulta)
        {
            GAC_Consultas_10_Repository datos = new GAC_Consultas_10_Repository();
            datos.NewConsulta(nuevoConsulta);
        }

        //actualizar registro
        public void updateConsulta(CONSULTAS actConsulta)
        {
            GAC_Consultas_10_Repository datos = new GAC_Consultas_10_Repository();
            datos.UpdateConsulta(actConsulta);
        }

        //eliminar registro
        public void deleteConsulta(CONSULTAS borrarConsulta)
        {
            GAC_Consultas_10_Repository datos = new GAC_Consultas_10_Repository();
            datos.DeleteConsulta(borrarConsulta);
        }

        //listar todos los registros

        public List<CONSULTAS>getConsultas()
        {
            List<CONSULTAS> listconsultas = new List<CONSULTAS>();
            GAC_Consultas_10_Repository datos = new GAC_Consultas_10_Repository();
            listconsultas = datos.GetConsultas();
            return listconsultas;
        }

        //listar registros por id
        public List<CONSULTAS>getConsultas_id(int idConsulta)
        {
            List<CONSULTAS> listconsultas = new List<CONSULTAS>();
            GAC_Consultas_10_Repository datos = new GAC_Consultas_10_Repository();
            listconsultas = datos.GetConsultas_id(idConsulta);
            return listconsultas;
        }
    }
}
