using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
using GAC_Acceso_Datos_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Hospitales_10_Logica
    {
        //Agregar Registro
        public void NewHospital(HOSPITALES nuevohospital)
        {
            GAC_Hospitales_10_Repository datos = new GAC_Hospitales_10_Repository();
                datos.NewHospital(nuevohospital);
        }

        //Actualizar Registro

        public void updateHospital(HOSPITALES actHospital)
        {
            GAC_Hospitales_10_Repository datos = new GAC_Hospitales_10_Repository();
            datos.updateHospital(actHospital);

        }

        //Eliminar Registro

        public void deleteHospital(HOSPITALES borrarHospital)
        {
            GAC_Hospitales_10_Repository datos = new GAC_Hospitales_10_Repository();
            datos.deleteHospital(borrarHospital);

        }

        //listar todos los Registros
        public List<HOSPITALES> getHospitales()
        {
            List<HOSPITALES> listhospitales = new List<HOSPITALES>();
            GAC_Hospitales_10_Repository datos = new GAC_Hospitales_10_Repository();
            listhospitales = datos.getHospitales();
            return listhospitales;
        }

        //listar Registro por Id
        public List<HOSPITALES> getHospitales_id(int id_Hospital)
        {

            List<HOSPITALES> listhospitales = new List<HOSPITALES>();
            GAC_Hospitales_10_Repository datos =new  GAC_Hospitales_10_Repository();
            listhospitales = datos.getHospitales_id(id_Hospital);
            return listhospitales;
        }
        
        public HOSPITALES get_Registro_Hospital(int registro_id)
        {
            HOSPITALES listaregistros = new HOSPITALES();
            GAC_Hospitales_10_Repository datos = new GAC_Hospitales_10_Repository();
            listaregistros = datos.get_Registro_Hospitales(registro_id);
            return listaregistros;
        }
    }

}

