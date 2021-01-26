using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_categorias_10_Logica
    {
        //agregar registro

        public void newCategoria(CATEGORIAS nuevoCategoria)
        {
            GAC_Categorias_10_Repository datos = new GAC_Categorias_10_Repository();
            datos.NewCategoria(nuevoCategoria);
        }

        //actualizar registro
        public void updateCategoria(CATEGORIAS actCategoria)
        {
            GAC_Categorias_10_Repository datos = new GAC_Categorias_10_Repository();
            datos.UpdateCategoria(actCategoria);
        }

        //eliminar registro
        public void deleteCategoria(CATEGORIAS borrarCategoria)
        {
            GAC_Categorias_10_Repository datos = new GAC_Categorias_10_Repository();
            datos.DeleteCategoria(borrarCategoria);
        }

        //listar todos los registros

        public List<CATEGORIAS>getCategorias()
        {
            List<CATEGORIAS> listcategorias = new List<CATEGORIAS>();
            GAC_Categorias_10_Repository datos = new GAC_Categorias_10_Repository();
            listcategorias = datos.GetCategorias();
            return listcategorias;
        }

        //listar registros por id
        public List<CATEGORIAS>getCategorias_id(int idCategoria)
        {
            List<CATEGORIAS> listcategorias = new List<CATEGORIAS>();
            GAC_Categorias_10_Repository datos = new GAC_Categorias_10_Repository();
            listcategorias = datos.GetCategorias_id(idCategoria);
            return listcategorias;
        }
    }
}
