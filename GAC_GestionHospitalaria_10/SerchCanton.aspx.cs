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
    public partial class SerchCanton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lb_Buscar_Click(object sender, EventArgs e)
        {
            GAC_Cantones_10_Logica datos = new GAC_Cantones_10_Logica();
            List<CANTONES> listcantones = new List<CANTONES>();

            if (txt_Criterio.Text == string.Empty)
            {
                listcantones = datos.getCantones();

            }
            else
            {
                listcantones = datos.getCantones_id(Convert.ToInt32(txt_Criterio.Text));
            }

            gv_Canton.DataSource = listcantones;
            gv_Canton.DataBind();
        }
        protected void gv_Canton_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);
            int idcanton = Convert.ToInt32(gv_Canton.Rows[indice].Cells[0].Text);

            if (e.CommandName == "Actualizar")
            {
                Session["id_canton"] = idcanton;
                Response.Redirect("updateCanton.aspx");
            }

            if (e.CommandName == "Eliminar")
            {
                CANTONES borrarCanton = new CANTONES();
                List<CANTONES> listcanton = new List<CANTONES>();
                GAC_Cantones_10_Logica datos = new GAC_Cantones_10_Logica();

                listcanton = datos.getCantones_id(idcanton);
                foreach (CANTONES registro in listcanton)
                {
                    borrarCanton.Id_canton = registro.Id_canton;
                    borrarCanton.Id_provincia = registro.Id_provincia;
                    borrarCanton.Canton = registro.Canton;
                    



                }
                datos.deleteCanton(borrarCanton);
            }
        }

        protected void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("newCantones.aspx");
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

    }
}