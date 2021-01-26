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
    public partial class newCantones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ddl 
                List<PROVINCIAS> listId_Provincia = new List<PROVINCIAS>();
                GAC_Provincias_10_Logica datos0 = new GAC_Provincias_10_Logica();
                listId_Provincia = datos0.getProvincias();
                ddl_Id_Provincia.DataSource = listId_Provincia;
                ddl_Id_Provincia.DataTextField = "Provincia";
                ddl_Id_Provincia.DataValueField = "Id_provincia";
                ddl_Id_Provincia.DataBind();

            }
        }
        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            CANTONES nuevoCanton = new CANTONES();
            nuevoCanton.Id_provincia = Convert.ToInt32(ddl_Id_Provincia.SelectedValue);
            nuevoCanton.Canton = txt_Canton.Text;

            GAC_Cantones_10_Logica datos = new GAC_Cantones_10_Logica();
            datos.newCanton(nuevoCanton);
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }


    }
}