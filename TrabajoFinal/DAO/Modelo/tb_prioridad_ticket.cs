//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_prioridad_ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_prioridad_ticket()
        {
            this.tb_ticket = new HashSet<tb_ticket>();
        }
    
        public int idPrioridad_ticket { get; set; }
        public string cod_prioridad_ticket { get; set; }
        public string prioridad_ticket { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ticket> tb_ticket { get; set; }
    }
}
