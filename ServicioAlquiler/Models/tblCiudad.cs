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

    public partial class tblCiudad
    {
        public tblCiudad()
        {
            this.tblSedes = new HashSet<tblSede>();
        }
    
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public int CodigoDepartamento { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual tblDepartamento tblDepartamento { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<tblSede> tblSedes { get; set; }
    }
}
