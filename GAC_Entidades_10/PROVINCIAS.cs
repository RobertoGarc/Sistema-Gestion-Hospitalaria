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
    
    public partial class PROVINCIAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROVINCIAS()
        {
            this.CANTONES = new HashSet<CANTONES>();
            this.HOSPITALES = new HashSet<HOSPITALES>();
        }
    
        public int Id_provincia { get; set; }
        public string Provincia { get; set; }
        public Nullable<int> Region { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CANTONES> CANTONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOSPITALES> HOSPITALES { get; set; }
        public virtual REGIONES REGIONES { get; set; }
    }
}