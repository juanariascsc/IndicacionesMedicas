﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SISTMEDProcedures : DbContext
    {
        public SISTMEDProcedures()
            : base("name=SISTMEDProcedures")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PRO_Asociacion_Procedimiento> PRO_Asociacion_Procedimiento { get; set; }
        public virtual DbSet<PRO_Asociacion_Procedimiento_Proc> PRO_Asociacion_Procedimiento_Proc { get; set; }
        public virtual DbSet<PRO_Procedimiento> PRO_Procedimiento { get; set; }
        public virtual DbSet<PRO_Historial_SuministroDeProcedimiento> PRO_Historial_SuministroDeProcedimiento { get; set; }
        public virtual DbSet<PRO_SuministroDeProcedimiento> PRO_SuministroDeProcedimiento { get; set; }
        public virtual DbSet<PRO_Generico> PRO_Generico { get; set; }
    
        public virtual int ActualizaPuntajeObraSocial(string codEmp, string cli_Cod, Nullable<decimal> puntaje)
        {
            var codEmpParameter = codEmp != null ?
                new ObjectParameter("codEmp", codEmp) :
                new ObjectParameter("codEmp", typeof(string));
    
            var cli_CodParameter = cli_Cod != null ?
                new ObjectParameter("cli_Cod", cli_Cod) :
                new ObjectParameter("cli_Cod", typeof(string));
    
            var puntajeParameter = puntaje.HasValue ?
                new ObjectParameter("puntaje", puntaje) :
                new ObjectParameter("puntaje", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizaPuntajeObraSocial", codEmpParameter, cli_CodParameter, puntajeParameter);
        }
    
        public virtual ObjectResult<Get_Paciente_Result> Get_Paciente(Nullable<int> pACIENTE_ID)
        {
            var pACIENTE_IDParameter = pACIENTE_ID.HasValue ?
                new ObjectParameter("PACIENTE_ID", pACIENTE_ID) :
                new ObjectParameter("PACIENTE_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Paciente_Result>("Get_Paciente", pACIENTE_IDParameter);
        }
    
        public virtual ObjectResult<Get_Paciente_Por_Sede_Result> Get_Paciente_Por_Sede(Nullable<int> sEDE_ID, Nullable<int> pISO_ID)
        {
            var sEDE_IDParameter = sEDE_ID.HasValue ?
                new ObjectParameter("SEDE_ID", sEDE_ID) :
                new ObjectParameter("SEDE_ID", typeof(int));
    
            var pISO_IDParameter = pISO_ID.HasValue ?
                new ObjectParameter("PISO_ID", pISO_ID) :
                new ObjectParameter("PISO_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Paciente_Por_Sede_Result>("Get_Paciente_Por_Sede", sEDE_IDParameter, pISO_IDParameter);
        }
    
        public virtual ObjectResult<Get_Piso_Por_Sede_Result> Get_Piso_Por_Sede(Nullable<int> sEDE_ID)
        {
            var sEDE_IDParameter = sEDE_ID.HasValue ?
                new ObjectParameter("SEDE_ID", sEDE_ID) :
                new ObjectParameter("SEDE_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Piso_Por_Sede_Result>("Get_Piso_Por_Sede", sEDE_IDParameter);
        }
    
        public virtual ObjectResult<MED_TraeModuloEmpresaCosto_Result> MED_TraeModuloEmpresaCosto(string codEmp)
        {
            var codEmpParameter = codEmp != null ?
                new ObjectParameter("codEmp", codEmp) :
                new ObjectParameter("codEmp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MED_TraeModuloEmpresaCosto_Result>("MED_TraeModuloEmpresaCosto", codEmpParameter);
        }
    
        public virtual ObjectResult<PuntajeObraSocial_Result> PuntajeObraSocial(string codEmp)
        {
            var codEmpParameter = codEmp != null ?
                new ObjectParameter("codEmp", codEmp) :
                new ObjectParameter("codEmp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PuntajeObraSocial_Result>("PuntajeObraSocial", codEmpParameter);
        }
    
        public virtual ObjectResult<TraeListaEspera_Result> TraeListaEspera()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TraeListaEspera_Result>("TraeListaEspera");
        }
    
        public virtual ObjectResult<TraeObrasSociales_Result> TraeObrasSociales()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TraeObrasSociales_Result>("TraeObrasSociales");
        }
    
        public virtual ObjectResult<Nullable<decimal>> ObtieneUltimoId(string tABLA)
        {
            var tABLAParameter = tABLA != null ?
                new ObjectParameter("TABLA", tABLA) :
                new ObjectParameter("TABLA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("ObtieneUltimoId", tABLAParameter);
        }
    
        public virtual ObjectResult<TRAEENTERALES_Result> TRAEENTERALES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TRAEENTERALES_Result>("TRAEENTERALES");
        }
    
        public virtual ObjectResult<TraeHabitacionesLibres_Result> TraeHabitacionesLibres(Nullable<int> sede, Nullable<int> actualiza, Nullable<int> habID)
        {
            var sedeParameter = sede.HasValue ?
                new ObjectParameter("Sede", sede) :
                new ObjectParameter("Sede", typeof(int));
    
            var actualizaParameter = actualiza.HasValue ?
                new ObjectParameter("Actualiza", actualiza) :
                new ObjectParameter("Actualiza", typeof(int));
    
            var habIDParameter = habID.HasValue ?
                new ObjectParameter("HabID", habID) :
                new ObjectParameter("HabID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TraeHabitacionesLibres_Result>("TraeHabitacionesLibres", sedeParameter, actualizaParameter, habIDParameter);
        }
    
        public virtual ObjectResult<MED_Get_Medicamento_Solicitado_Result> MED_Get_Medicamento_Solicitado(Nullable<bool> aUTORIZA, Nullable<bool> pENDIENTE)
        {
            var aUTORIZAParameter = aUTORIZA.HasValue ?
                new ObjectParameter("AUTORIZA", aUTORIZA) :
                new ObjectParameter("AUTORIZA", typeof(bool));
    
            var pENDIENTEParameter = pENDIENTE.HasValue ?
                new ObjectParameter("PENDIENTE", pENDIENTE) :
                new ObjectParameter("PENDIENTE", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MED_Get_Medicamento_Solicitado_Result>("MED_Get_Medicamento_Solicitado", aUTORIZAParameter, pENDIENTEParameter);
        }
    
        public virtual ObjectResult<TRAEDESCARTABLES_Result> TRAEDESCARTABLES(string descartable)
        {
            var descartableParameter = descartable != null ?
                new ObjectParameter("Descartable", descartable) :
                new ObjectParameter("Descartable", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TRAEDESCARTABLES_Result>("TRAEDESCARTABLES", descartableParameter);
        }
    
        public virtual ObjectResult<TRAEMEDICAMENTOS_Result> TRAEMEDICAMENTOS(string medicamento_id)
        {
            var medicamento_idParameter = medicamento_id != null ?
                new ObjectParameter("Medicamento_id", medicamento_id) :
                new ObjectParameter("Medicamento_id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TRAEMEDICAMENTOS_Result>("TRAEMEDICAMENTOS", medicamento_idParameter);
        }
    }
}