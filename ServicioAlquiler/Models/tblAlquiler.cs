//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicioAlquiler.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class tblAlquiler
    {
        public tblAlquiler()
        {
            this.tblDevolucions = new HashSet<tblDevolucion>();
        }
    
        public int Codigo { get; set; }
        public string CedulaCliente { get; set; }
        public string IDEmpleado { get; set; }
        public int IDTipoVehiculo { get; set; }
        public string PlacaVehiculo { get; set; }
        public string EstadoAlquiler { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual tblCliente tblCliente { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual tblEmpleado tblEmpleado { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual tblTipoVehiculo tblTipoVehiculo { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual tblVehiculo tblVehiculo { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<tblDevolucion> tblDevolucions { get; set; }
    }
}
