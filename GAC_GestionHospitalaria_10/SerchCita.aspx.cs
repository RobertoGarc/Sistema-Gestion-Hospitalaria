using GAC_Entidades_10;
using GAC_Logica_Negocio_10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GAC_GestionHospitalaria_10
{
    public partial class SerchCita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lb_Buscar_Click(object sender, EventArgs e)
        {
            GAC_Citas_10_Logica datos = new GAC_Citas_10_Logica();
            List<CITAS> listcitas = new List<CITAS>();

            if (txt_Criterio.Text == string.Empty)
            {
                listcitas = datos.getCitas();

            }
            else
            {
                listcitas = datos.getCitas_id(Convert.ToInt32(txt_Criterio.Text));
            }

            gv_Citas.DataSource = listcitas;
            gv_Citas.DataBind();
        }
        protected void gv_Citas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);
            int idcita = Convert.ToInt32(gv_Citas.Rows[indice].Cells[0].Text);

            if (e.CommandName == "Actualizar")
            {
                Session["id_cita"] = idcita;
                Response.Redirect("updateCita.aspx");
            }

            if (e.CommandName == "Eliminar")
            {
                CITAS borrarCita = new CITAS();
                List<CITAS> listcita = new List<CITAS>();
                GAC_Citas_10_Logica datos = new GAC_Citas_10_Logica();

                listcita = datos.getCitas_id(idcita);
                foreach (CITAS registro in listcita)
                {
                    borrarCita.Id_cita = registro.Id_cita;
                    borrarCita.Id_paciente = registro.Id_paciente;
                    borrarCita.Id_hospital = registro.Id_hospital;
                    borrarCita.Id_medico = registro.Id_medico;
                    borrarCita.Fecha = registro.Fecha;
                    borrarCita.Hora = registro.Hora;
                    borrarCita.Estado = registro.Estado;
                    borrarCita.Observacion = registro.Observacion;
                    


                }
                datos.deleteCita(borrarCita);
            }
        }

        protected void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("newCitas.aspx");
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }


    }
}