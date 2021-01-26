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
    public partial class SerchProvincia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lb_Buscar_Click(object sender, EventArgs e)
        {
            GAC_Provincias_10_Logica datos = new GAC_Provincias_10_Logica();
            List<PROVINCIAS> listprovincias = new List<PROVINCIAS>();

            if (txt_Criterio.Text == string.Empty)
            {
                listprovincias = datos.getProvincias();

            }
            else
            {
                listprovincias = datos.getProvincias_id(Convert.ToInt32(txt_Criterio.Text));
            }

            gv_provincia.DataSource = listprovincias;
            gv_provincia.DataBind();
        }
        protected void gv_Provincia_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);
            int idprovincia = Convert.ToInt32(gv_provincia.Rows[indice].Cells[0].Text);

            if (e.CommandName == "Actualizar")
            {
                Session["id_provincia"] = idprovincia;
                Response.Redirect("updateProvincia.aspx");
            }

            if (e.CommandName == "Eliminar")
            {
                PROVINCIAS borrarProvincia = new PROVINCIAS();
                List<PROVINCIAS> listprovincia = new List<PROVINCIAS>();
                GAC_Provincias_10_Logica datos = new GAC_Provincias_10_Logica();

                listprovincia = datos.getProvincias_id(idprovincia);
                foreach (PROVINCIAS registro in listprovincia)
                {
                    borrarProvincia.Id_provincia = registro.Id_provincia;
                    borrarProvincia.Provincia = registro.Provincia;
                    borrarProvincia.Region = registro.Region;




                }
                datos.deleteProvincia(borrarProvincia);
            }
        }

        protected void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("newProvincias.aspx");
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}