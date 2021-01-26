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
    public partial class SerchParroquia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lb_Buscar_Click(object sender, EventArgs e)
        {
            GAC_Parroquias_10_Logica datos = new GAC_Parroquias_10_Logica();
            List<PARROQUIAS> listparroquias = new List<PARROQUIAS>();

            if (txt_Criterio.Text == string.Empty)
            {
                listparroquias = datos.getParroquias();

            }
            else
            {
                listparroquias = datos.getParroquias_id(Convert.ToInt32(txt_Criterio.Text));
            }

            gv_Parroquia.DataSource = listparroquias;
            gv_Parroquia.DataBind();
        }
        protected void gv_Parroquia_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);
            int idParroquia = Convert.ToInt32(gv_Parroquia.Rows[indice].Cells[0].Text);

            if (e.CommandName == "Actualizar")
            {
                Session["id_parroquia"] = idParroquia;
                Response.Redirect("updateParroquia.aspx");
            }

            if (e.CommandName == "Eliminar")
            {
                PARROQUIAS borrarParroquia = new PARROQUIAS();
                List<PARROQUIAS> listparroquia = new List<PARROQUIAS>();
                GAC_Parroquias_10_Logica datos = new GAC_Parroquias_10_Logica();

                listparroquia = datos.getParroquias_id(idParroquia);
                foreach (PARROQUIAS registro in listparroquia)
                {
                    borrarParroquia.Id_parroquia = registro.Id_parroquia;
                    borrarParroquia.Id_canton = registro.Id_canton;
                    borrarParroquia.Parroquia = registro.Parroquia;
                    borrarParroquia.Numhabitantes = registro.Numhabitantes;



                }
                datos.deleteParroquia(borrarParroquia);
            }
        }

        protected void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("newParroquias.aspx");
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

    }
}