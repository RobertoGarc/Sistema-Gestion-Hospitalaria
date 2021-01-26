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
    public partial class newParroquias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ddl 
                List<CANTONES> listId_Canton = new List<CANTONES>();
                GAC_Cantones_10_Logica datos0 = new GAC_Cantones_10_Logica();
                listId_Canton = datos0.getCantones();
                ddl_Id_Canton.DataSource = listId_Canton;
                ddl_Id_Canton.DataTextField = "Canton";
                ddl_Id_Canton.DataValueField = "Id_canton";
                ddl_Id_Canton.DataBind();

            }
        }
        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            PARROQUIAS nuevaParroquia = new PARROQUIAS();
            nuevaParroquia.Id_canton = Convert.ToInt32(ddl_Id_Canton.SelectedValue);
            nuevaParroquia.Parroquia = txt_Parroquia.Text;
            nuevaParroquia.Numhabitantes = Convert.ToInt32(txt_Numhabitantes.Text);

            GAC_Parroquias_10_Logica datos = new GAC_Parroquias_10_Logica();
            datos.newParroquia(nuevaParroquia);
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

    }
}