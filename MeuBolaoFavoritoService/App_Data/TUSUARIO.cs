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
    
    public partial class TUSUARIO
    {
        public TUSUARIO()
        {
            this.TPALPITE = new HashSet<TPALPITE>();
            this.TUSUARIO_TBOLAO = new HashSet<TUSUARIO_TBOLAO>();
            this.TUSUARIO_TBOLAO_RESPONSAVEL = new HashSet<TUSUARIO_TBOLAO>();
            this.TUSUARIO_TIME = new HashSet<TUSUARIO_TIME>();
        }
    
        public System.Guid IDENTIFICADOR { get; set; }
        public string LOGIN { get; set; }
        public string NOME { get; set; }
        public bool ATIVO { get; set; }
    
        public virtual ICollection<TPALPITE> TPALPITE { get; set; }
        public virtual ICollection<TUSUARIO_TBOLAO> TUSUARIO_TBOLAO { get; set; }
        public virtual ICollection<TUSUARIO_TBOLAO> TUSUARIO_TBOLAO_RESPONSAVEL { get; set; }
        public virtual ICollection<TUSUARIO_TIME> TUSUARIO_TIME { get; set; }
    }
}
