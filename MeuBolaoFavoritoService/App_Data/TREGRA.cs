//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeuBolaoFavoritoService.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TREGRA
    {
        public TREGRA()
        {
            this.TBOLAO = new HashSet<TBOLAO>();
        }
    
        public System.Guid IDENTIFICADOR { get; set; }
        public string TIPO_BOLAO { get; set; }
        public bool PERMITE_RECURSO { get; set; }
        public bool PREMIADO { get; set; }
        public string DESCRICAO { get; set; }
    
        public virtual ICollection<TBOLAO> TBOLAO { get; set; }
    }
}
