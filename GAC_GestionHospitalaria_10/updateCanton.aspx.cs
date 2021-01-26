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
    public partial class updateCanton : System.Web.UI.Page
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

                int idcanton = Convert.ToInt32(Session["id_canton"]);
                GAC_Cantones_10_Logica datos1 = new GAC_Cantones_10_Logica();
                CANTONES registro_canton = new CANTONES();
                registro_canton = datos1.get_Registro_Cantones(idcanton);


                txt_Id_Cantones.Text = registro_canton.Id_canton.ToString();
                ddl_Id_Provincia.SelectedValue = registro_canton.ToString();
                txt_Canton.Text = registro_canton.Canton.ToString();

            }
        }
        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            CANTONES nuevoCanton = new CANTONES();
            nuevoCanton.Id_canton = Convert.ToInt32(txt_Id_Cantones.Text);
            nuevoCanton.Id_provincia = Convert.ToInt32(ddl_Id_Provincia.SelectedValue);
            nuevoCanton.Canton = txt_Canton.Text;

            GAC_Cantones_10_Logica datos = new GAC_Cantones_10_Logica();
            datos.updateCanton(nuevoCanton);
        }
        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("SerchCanton.aspx");
        }

    }
}