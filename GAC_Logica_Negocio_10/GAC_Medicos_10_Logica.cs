using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Medicos_10_Logica
    {
        //agregar registro

        public void newMedicos(MEDICOS nuevoMedico)
        {
            GAC_Medicos_10_Repository datos = new GAC_Medicos_10_Repository();
            datos.NewMedico(nuevoMedico);
        }

        //actualizar registro
        public void updateMedico(MEDICOS actMedico)
        {
            GAC_Medicos_10_Repository datos = new GAC_Medicos_10_Repository();
            datos.UpdateMedico(actMedico);
        }

        //eliminar registro
        public void deleteMedico(MEDICOS borrarMedico)
        {
            GAC_Medicos_10_Repository datos = new GAC_Medicos_10_Repository();
            datos.DeleteMedico(borrarMedico);
        }

        //listar todos los registros

        public List<MEDICOS>getMedicos()
        {
            List<MEDICOS> listmedicos = new List<MEDICOS>();
            GAC_Medicos_10_Repository datos = new GAC_Medicos_10_Repository();
            listmedicos = datos.GetMedicos();
            return listmedicos;
        }

        //listar registros por id
        public List<MEDICOS> getMedicos_id(int idMedico)
        {
            List<MEDICOS> listmedicos = new List<MEDICOS>();
            GAC_Medicos_10_Repository datos = new GAC_Medicos_10_Repository();
            listmedicos = datos.GetMedicos_id(idMedico);
            return listmedicos;
        }

        public MEDICOS get_Registro_Medico(int registro_id)
        {
            MEDICOS listaregistros = new MEDICOS();
            GAC_Medicos_10_Repository datos = new GAC_Medicos_10_Repository();
            listaregistros = datos.get_Registro_Medicos(registro_id);
            return listaregistros;
        }
    }
}
