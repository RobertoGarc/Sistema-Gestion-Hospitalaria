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
    public partial class updateCita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
           

                //ddl 
                List<HOSPITALES> listId_Hospital = new List<HOSPITALES>();
                GAC_Hospitales_10_Logica datos0 = new GAC_Hospitales_10_Logica();
                listId_Hospital = datos0.getHospitales();
                ddl_Id_Hospital.DataSource = listId_Hospital;
                ddl_Id_Hospital.DataTextField = "Nombre";
                ddl_Id_Hospital.DataValueField = "Id_hospital";
                ddl_Id_Hospital.DataBind();

                //ddl 
                List<PACIENTES> listId_Paciente = new List<PACIENTES>();
                GAC_Pacientes_10_Logica datos1 = new GAC_Pacientes_10_Logica();
                listId_Paciente = datos1.getPacientes();
                ddl_Id_Paciente.DataSource = listId_Paciente;
                ddl_Id_Paciente.DataTextField = "Nombre1";
                ddl_Id_Paciente.DataValueField = "Id_paciente";
                ddl_Id_Paciente.DataBind();

                //ddl 
                List<MEDICOS> listId_Medico = new List<MEDICOS>();
                GAC_Medicos_10_Logica datos2 = new GAC_Medicos_10_Logica();
                listId_Medico = datos2.getMedicos();
                ddl_Id_Medico.DataSource = listId_Medico;
                ddl_Id_Medico.DataTextField = "Nombres";
                ddl_Id_Medico.DataValueField = "Id_medico";
                ddl_Id_Medico.DataBind();

                //ddl Sexo
                List<CITA_ESTADOS> listestado = new List<CITA_ESTADOS>();
                GAC_Cita_Estados_10_Logica datos3 = new GAC_Cita_Estados_10_Logica();
                listestado = datos3.getCita_Estados();
                ddl_Estado.DataSource = listestado;
                ddl_Estado.DataTextField = "Estado";
                ddl_Estado.DataValueField = "Id_estado";
                ddl_Estado.DataBind();

                int idcita = Convert.ToInt32(Session["id_cita"]);
                GAC_Citas_10_Logica datos4 = new GAC_Citas_10_Logica();
                CITAS registro_cita = new CITAS();
                registro_cita = datos4.get_Registro_Cita(idcita);


                txt_Id_Citas.Text = registro_cita.Id_cita.ToString();
                ddl_Id_Paciente.SelectedValue = registro_cita.ToString();
                ddl_Id_Hospital.SelectedValue = registro_cita.ToString();
                ddl_Id_Medico.SelectedValue = registro_cita.ToString();
                txt_Fecha.Text = registro_cita.Fecha.ToString();
                txt_Hora.Text = registro_cita.Hora.ToString();
                ddl_Estado.SelectedValue = registro_cita.ToString();
                txt_Observacion.Text = registro_cita.Observacion.ToString();
               

            }
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txt_Fecha.Text = Calendar1.SelectedDate.Date.ToShortDateString();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            CITAS nuevaCita = new CITAS();
            nuevaCita.Id_cita = Convert.ToInt32(txt_Id_Citas.Text);
            nuevaCita.Id_paciente = Convert.ToInt32(ddl_Id_Paciente.SelectedValue);
            nuevaCita.Id_hospital = Convert.ToInt32(ddl_Id_Hospital.SelectedValue);
            nuevaCita.Id_medico = Convert.ToInt32(ddl_Id_Medico.SelectedValue);
            nuevaCita.Fecha = Convert.ToDateTime(txt_Fecha.Text);
            nuevaCita.Hora = Convert.ToDateTime(txt_Hora.Text);
            nuevaCita.Estado = Convert.ToInt32(ddl_Estado.SelectedValue);
            nuevaCita.Observacion = txt_Observacion.Text;

            GAC_Citas_10_Logica datos = new GAC_Citas_10_Logica();
            datos.updateCita(nuevaCita);
        }
        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("SerchCita.aspx");
        }
    }
}