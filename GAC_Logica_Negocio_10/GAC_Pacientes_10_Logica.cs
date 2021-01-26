using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;
using GAC_Acceso_Datos_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Pacientes_10_Logica
    {
        //Agregar Registro
        public void NewPacientes(PACIENTES nuevoPaciente)
        {
            GAC_Pacientes_10_Repository datos = new GAC_Pacientes_10_Repository();
                datos.NewPaciente(nuevoPaciente);
        }

        //Actualizar Registro

        public void updatePaciente(PACIENTES actPaciente)
        {
            GAC_Pacientes_10_Repository datos = new GAC_Pacientes_10_Repository();
            datos.updatePaciente(actPaciente);

        }

        //Eliminar Registro

        public void deletepaciente(PACIENTES borrarpaciente)
        {
            GAC_Pacientes_10_Repository datos = new GAC_Pacientes_10_Repository();
            datos.deletePaciente(borrarpaciente);

        }

        //listar todos los Registros
        public List<PACIENTES> getPacientes()
        {
            List<PACIENTES> listPacientes = new List<PACIENTES>();
            GAC_Pacientes_10_Repository datos = new GAC_Pacientes_10_Repository();
            listPacientes = datos.getPacientes();
            return listPacientes;
        }

        //listar Registro por Id
        public List<PACIENTES> getPacientes_id(int id_Paciente)
        {

            List<PACIENTES> listPacientes = new List<PACIENTES>();
            GAC_Pacientes_10_Repository datos =new GAC_Pacientes_10_Repository();
            listPacientes = datos.getPacientes_id(id_Paciente);
            return listPacientes;
        }

        // listar  Nombre Completo
        public List<Paciente_NombreCompleto> getPacientes_NombreCompleto()
        {
            List<Paciente_NombreCompleto> listPacientes = new List<Paciente_NombreCompleto>();
            GAC_Pacientes_10_Repository datos = new GAC_Pacientes_10_Repository();
            listPacientes = datos.getPacientes_NombreCompleto();
            return listPacientes;
        }

        public PACIENTES get_Registro_Paciente(int registro_id)
        {
            PACIENTES listaregistros = new PACIENTES();
            GAC_Pacientes_10_Repository datos = new GAC_Pacientes_10_Repository();
            listaregistros = datos.get_Registro_Pacientes(registro_id);
            return listaregistros;
        }
    }
}

