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
    
    public partial class TJOGO
    {
        public TJOGO()
        {
            this.TPALPITE = new HashSet<TPALPITE>();
        }
    
        public System.Guid IDENTIFICADOR { get; set; }
        public System.Guid ID_RODADA { get; set; }
        public System.Guid ID_TIME1 { get; set; }
        public System.Guid ID_TIME2 { get; set; }
        public Nullable<System.DateTime> DATA { get; set; }
        public short NUMERO { get; set; }
        public short PESO { get; set; }
        public Nullable<short> GOLS_TIME1 { get; set; }
        public Nullable<short> GOLS_TIME2 { get; set; }
        public bool ATIVO { get; set; }
    
        public virtual TTIME TTIME1 { get; set; }
        public virtual TTIME TTIME2 { get; set; }
        public virtual ICollection<TPALPITE> TPALPITE { get; set; }
        public virtual TRODADA TRODADA { get; set; }
    }
}
