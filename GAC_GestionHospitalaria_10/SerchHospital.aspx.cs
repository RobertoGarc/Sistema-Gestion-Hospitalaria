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
    public partial class SerchHospital : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lb_Buscar_Click(object sender, EventArgs e)
        {
            GAC_Hospitales_10_Logica datos = new GAC_Hospitales_10_Logica();
            List<HOSPITALES> listhospitales = new List<HOSPITALES>();

            if(txt_Criterio.Text ==string.Empty)
            {
                listhospitales = datos.getHospitales();

            }
            else
            {
                listhospitales = datos.getHospitales_id(Convert.ToInt32(txt_Criterio.Text));
            }

            gv_Hospitales.DataSource = listhospitales;
            gv_Hospitales.DataBind();
        }

        protected void gv_Hospitales_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);
            int idhospital = Convert.ToInt32(gv_Hospitales.Rows[indice].Cells[0].Text);

            if (e.CommandName == "Actualizar")
            {
                Session["id_hospital"] = idhospital;
                Response.Redirect("updateHospital.aspx");
            }

            if (e.CommandName == "Eliminar")
            {
                HOSPITALES borrarHospital = new HOSPITALES();
                List<HOSPITALES> listhospital = new List<HOSPITALES>();
                GAC_Hospitales_10_Logica datos = new GAC_Hospitales_10_Logica();

                listhospital = datos.getHospitales_id(idhospital);
                foreach(HOSPITALES registro in listhospital)
                {
                    borrarHospital.Id_hospital = registro.Id_hospital;
                    borrarHospital.Nombre = registro.Nombre;
                    borrarHospital.Tipo = registro.Tipo;
                    borrarHospital.Categoria = registro.Categoria;
                    borrarHospital.Area = registro.Area;
                    
                }
                datos.deleteHospital(borrarHospital);
            }
        }

        protected void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("newHospitales.aspx");
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}