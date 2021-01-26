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
    public partial class SerchMedicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void lb_Buscar_Click(object sender, EventArgs e)
        {
            GAC_Medicos_10_Logica datos = new GAC_Medicos_10_Logica();
            List<MEDICOS> listmedicos = new List<MEDICOS>();

            if (txt_Criterio.Text == string.Empty)
            {
                listmedicos = datos.getMedicos();

            }
            else
            {
                listmedicos = datos.getMedicos_id(Convert.ToInt32(txt_Criterio.Text));
            }

            gv_Medicos.DataSource = listmedicos;
            gv_Medicos.DataBind();
        }
        protected void gv_Medicos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);
            int idmedico = Convert.ToInt32(gv_Medicos.Rows[indice].Cells[0].Text);

            if (e.CommandName == "Actualizar")
            {
                Session["id_medico"] = idmedico;
                Response.Redirect("updateMedico.aspx");
            }

            if (e.CommandName == "Eliminar")
            {
                MEDICOS borrarMedico = new MEDICOS();
                List<MEDICOS> listmedico = new List<MEDICOS>();
                GAC_Medicos_10_Logica datos = new GAC_Medicos_10_Logica();

                listmedico = datos.getMedicos_id(idmedico);
                foreach (MEDICOS registro in listmedico)
                {
                    borrarMedico.Id_medico = registro.Id_medico;
                    borrarMedico.Nombres = registro.Nombres;
                    borrarMedico.Apellidos = registro.Apellidos;
                    borrarMedico.Id_hospital = registro.Id_hospital;
                    borrarMedico.Cargo = registro.Cargo;
                    borrarMedico.FechaN = registro.FechaN;
                    borrarMedico.Sexo = registro.Sexo;
                    borrarMedico.Direccion = registro.Direccion;
                    borrarMedico.Telefono = registro.Telefono;
                    borrarMedico.Email = registro.Email;
                    borrarMedico.Login = registro.Login;
                    borrarMedico.Password = registro.Password;
                    borrarMedico.Observacion = registro.Observacion;

                }
                datos.deleteMedico(borrarMedico);
            }
        }

        protected void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("newMedicos.aspx");
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        
    }
}