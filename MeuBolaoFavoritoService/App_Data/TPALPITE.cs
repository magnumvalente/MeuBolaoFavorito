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
    
    public partial class TPALPITE
    {
        public System.Guid IDENTIFICADOR { get; set; }
        public System.Guid ID_USUARIO { get; set; }
        public System.Guid ID_JOGO { get; set; }
        public Nullable<short> GOL_TIME1 { get; set; }
        public Nullable<short> GOL_TIME2 { get; set; }
        public Nullable<System.Guid> ID_RECURSO { get; set; }
        public System.DateTime DATA { get; set; }
        public System.Guid ID_PONTUACAO { get; set; }
    
        public virtual TJOGO TJOGO { get; set; }
        public virtual TRECURSO TRECURSO { get; set; }
        public virtual TUSUARIO TUSUARIO { get; set; }
        public virtual TPONTUACAO TPONTUACAO { get; set; }
    }
}
