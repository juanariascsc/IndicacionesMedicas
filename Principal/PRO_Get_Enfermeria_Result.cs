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
    
    public partial class PRO_Get_Enfermeria_Result
    {
        public int enfermeria_id { get; set; }
        public Nullable<int> paciente_id { get; set; }
        public string Paciente { get; set; }
        public Nullable<bool> controlVital { get; set; }
        public Nullable<bool> frecuenciaCardiaca { get; set; }
        public Nullable<bool> frecuenciaRespiratoria { get; set; }
        public Nullable<bool> temperaturaAxilar { get; set; }
        public Nullable<bool> diuresis { get; set; }
        public Nullable<bool> glucemiaCapilar { get; set; }
        public Nullable<bool> multistickOrina { get; set; }
        public Nullable<bool> controlSaturacion { get; set; }
        public Nullable<bool> medicionResiduosGastrico { get; set; }
        public Nullable<bool> ecg { get; set; }
        public string observacion { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
    }
}
