//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Principal
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRO_PHPV2_ADITIVO
    {
        public int id_php { get; set; }
        public int id_frasco { get; set; }
        public string aditivo_id { get; set; }
        public string aditivo_desc { get; set; }
        public int id { get; set; }
        public Nullable<decimal> dosis { get; set; }
    
        public virtual PRO_PHPV2 PRO_PHPV2 { get; set; }
    }
}