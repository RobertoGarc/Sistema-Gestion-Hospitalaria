//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GAC_Entidades_10
{
    using System;
    using System.Collections.Generic;
    
    public partial class MEDICO_ESPECIALIDAD
    {
        public int Id_medespe { get; set; }
        public Nullable<int> Id_Medico { get; set; }
        public Nullable<int> id_especialidad { get; set; }
    
        public virtual ESPECIALIDADES ESPECIALIDADES { get; set; }
        public virtual MEDICOS MEDICOS { get; set; }
    }
}