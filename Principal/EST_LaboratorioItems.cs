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
    
    public partial class EST_LaboratorioItems
    {
        public int id_solicitud { get; set; }
        public int nroItem { get; set; }
        public Nullable<int> estudio_id { get; set; }
        public Nullable<int> estado_id { get; set; }
    
        public virtual EST_LaboratorioCab EST_LaboratorioCab { get; set; }
        public virtual EST_LaboratorioDeterminaciones EST_LaboratorioDeterminaciones { get; set; }
    }
}