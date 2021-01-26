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
    public partial class newPacientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ddl Condicion
                List<CONDICIONES> listcondicion = new List<CONDICIONES>();
                GAC_Condiciones_10_Logica datos0 = new GAC_Condiciones_10_Logica();
                listcondicion = datos0.getCondiciones();
                ddl_Condicion.DataSource = listcondicion;
                ddl_Condicion.DataTextField = "Condicion";
                ddl_Condicion.DataValueField = "Id_condicion";
                ddl_Condicion.DataBind();

                //ddl Parentescos
                List<PARENTESCOS> listparentesco = new List<PARENTESCOS>();
                GAC_Parentescos_10_Logica datos1 = new GAC_Parentescos_10_Logica();
                listparentesco = datos1.GetParentescos();
                ddl_Parentescos.DataSource = listparentesco;
                ddl_Parentescos.DataTextField = "Parentesco";
                ddl_Parentescos.DataValueField = "Id_Parentesco";
                ddl_Parentescos.DataBind();

                //ddl Sexo
                List<SEXO> listsexo = new List<SEXO>();
                GAC_Sexo_10_Logica datos2 = new GAC_Sexo_10_Logica();
                listsexo = datos2.getSexos();
                ddl_Sexo.DataSource = listsexo;
                ddl_Sexo.DataTextField = "Sexo1";
                ddl_Sexo.DataValueField = "Id_sexo";
                ddl_Sexo.DataBind();

                //ddl Tipo_Sangre
                List<TIPOS_SANGE> listtipos_sangre = new List<TIPOS_SANGE>();
                GAC_Tipos_Sange_10_Logica datos3 = new GAC_Tipos_Sange_10_Logica();
                listtipos_sangre = datos3.getTipo_Sange();
                ddl_TipoSangre.DataSource = listtipos_sangre;
                ddl_TipoSangre.DataTextField = "TipoSangre";
                ddl_TipoSangre.DataValueField = "Id_tipos";
                ddl_TipoSangre.DataBind();

            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
           txt_Fecha_Nacimiento.Text = Calendar1.SelectedDate.Date.ToShortDateString();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            PACIENTES nuevoPaciente = new PACIENTES();
            nuevoPaciente.Cedula = txt_Cedula.Text;
            nuevoPaciente.Nombre1 = txt_Nombre1.Text;
            nuevoPaciente.Nombre2= txt_Nombre2.Text;
            nuevoPaciente.Apellido1 = txt_Apellido1.Text;
            nuevoPaciente.Apellido2 = txt_Apellido2.Text;
            nuevoPaciente.TipoSangre = Convert.ToInt32(ddl_TipoSangre.SelectedValue);
            nuevoPaciente.FechaNacimiento = Convert.ToDateTime(txt_Fecha_Nacimiento.Text);
            nuevoPaciente.Sexo = Convert.ToInt32(ddl_Sexo.SelectedValue);
            nuevoPaciente.Condicion = Convert.ToInt32(ddl_Condicion.SelectedValue);
            nuevoPaciente.Direccion = txt_Direccion.Text;
            nuevoPaciente.TelefonoP = txt_Telefonop.Text;
            nuevoPaciente.Email = txt_Email.Text;
            nuevoPaciente.FamliarContacto = txt_FamiliarContacto.Text;
            nuevoPaciente.TelefonoC = txt_TelefonoC.Text;
            nuevoPaciente.Parentesco = Convert.ToInt32(ddl_Parentescos.SelectedValue);


            GAC_Pacientes_10_Logica datos = new GAC_Pacientes_10_Logica();
            datos.NewPacientes(nuevoPaciente);
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}