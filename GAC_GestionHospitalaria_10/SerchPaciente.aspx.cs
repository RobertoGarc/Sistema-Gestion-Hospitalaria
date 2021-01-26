using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GAC_Entidades_10;
using GAC_Logica_Negocio_10;

namespace GAC_GestionHospitalaria_10
{
    public partial class SerchPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lb_Buscar_Click(object sender, EventArgs e)
        {
            GAC_Pacientes_10_Logica datos = new GAC_Pacientes_10_Logica();
            List<PACIENTES> listpacientes = new List<PACIENTES>();

            if (txt_Criterio.Text == string.Empty)
            {
                listpacientes = datos.getPacientes();

            }
            else
            {
                listpacientes = datos.getPacientes_id(Convert.ToInt32(txt_Criterio.Text));
            }

            gv_Pacientes.DataSource = listpacientes;
            gv_Pacientes.DataBind();
        }

        protected void gv_Pacientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);
            int idpaciente = Convert.ToInt32(gv_Pacientes.Rows[indice].Cells[0].Text);

            if (e.CommandName == "Actualizar")
            {
                Session["id_paciente"] = idpaciente;
                Response.Redirect("updatePaciente.aspx");
            }

            if (e.CommandName == "Eliminar")
            {
                PACIENTES borrarPaciente = new PACIENTES();
                List<PACIENTES> listpaciente = new List<PACIENTES>();
                GAC_Pacientes_10_Logica datos = new GAC_Pacientes_10_Logica();

                listpaciente = datos.getPacientes_id(idpaciente);
                foreach (PACIENTES registro in listpaciente)
                {
                    borrarPaciente.Id_paciente = registro.Id_paciente;
                    borrarPaciente.Nombre1 = registro.Nombre1;
                    borrarPaciente.Nombre2 = registro.Nombre2;
                    borrarPaciente.Apellido1 = registro.Apellido1;
                    borrarPaciente.Apellido2 = registro.Apellido2;
                    borrarPaciente.TipoSangre = registro.TipoSangre;
                    borrarPaciente.FechaNacimiento = registro.FechaNacimiento;
                    borrarPaciente.Sexo = registro.Sexo;
                    borrarPaciente.Condicion = registro.Condicion;
                    borrarPaciente.Direccion = registro.Direccion;
                    borrarPaciente.TelefonoP = registro.TelefonoP;
                    borrarPaciente.Email = registro.Email;
                    borrarPaciente.FamliarContacto = registro.FamliarContacto;
                    borrarPaciente.TelefonoC = registro.TelefonoC;
                    borrarPaciente.Parentesco = registro.Parentesco;

                }
                datos.deletepaciente(borrarPaciente);
            }
        }

        protected void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("newPacientes.aspx");
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

       
    }
}