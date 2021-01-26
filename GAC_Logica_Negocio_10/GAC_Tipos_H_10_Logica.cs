using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;

namespace GAC_Logica_Negocio_10
{
    public class GAC_Tipos_H_10_Logica
    {
        //agregar registro

        public void newTipo_H(TIPOS_H nuevoTipo_H)
        {
            GAC_Tipos_H_10_Repository datos = new GAC_Tipos_H_10_Repository();
            datos.NewTipo_H(nuevoTipo_H);
        }

        //actualizar registro
        public void updateTipo_H(TIPOS_H actTipo_H)
        {
            GAC_Tipos_H_10_Repository datos = new GAC_Tipos_H_10_Repository();
            datos.UpdateTipo_H(actTipo_H);
        }

        //eliminar registro
        public void deleteTipo_H(TIPOS_H borrarTipo_H)
        {
            GAC_Tipos_H_10_Repository datos = new GAC_Tipos_H_10_Repository();
            datos.DeleteTipo_H(borrarTipo_H);
        }

        //listar todos los registros

        public List<TIPOS_H>getTipo_H()
        {
            List<TIPOS_H> listtipos_h = new List<TIPOS_H>();
            GAC_Tipos_H_10_Repository datos = new GAC_Tipos_H_10_Repository();
            listtipos_h = datos.GetTipos_H();
            return listtipos_h;
        }

        //listar registros por id
        public List<TIPOS_H> getTipo_H_id(int idTipo_H)
        {
            List<TIPOS_H> listtipo_h = new List<TIPOS_H>();
            GAC_Tipos_H_10_Repository datos = new GAC_Tipos_H_10_Repository();
            listtipo_h = datos.GetTipos_H_id(idTipo_H);
            return listtipo_h;
        }
    }
}
