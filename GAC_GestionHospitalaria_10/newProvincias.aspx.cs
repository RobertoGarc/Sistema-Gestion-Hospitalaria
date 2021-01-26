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
    public partial class newProvincias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ddl 
                List<REGIONES> listId_Region = new List<REGIONES>();
                GAC_Regiones_10_Logica datos0 = new GAC_Regiones_10_Logica();
                listId_Region = datos0.getRegiones();
                ddl_Id_Region.DataSource = listId_Region;
                ddl_Id_Region.DataTextField = "Region";
                ddl_Id_Region.DataValueField = "Id_region";
                ddl_Id_Region.DataBind();

            }
        }
        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            PROVINCIAS nuevaProvincia = new PROVINCIAS();
            nuevaProvincia.Region= Convert.ToInt32(ddl_Id_Region.SelectedValue);
            nuevaProvincia.Provincia = txt_Provincia.Text;

            GAC_Provincias_10_Logica datos = new GAC_Provincias_10_Logica();
            datos.newProvincia(nuevaProvincia);
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

    }
}
