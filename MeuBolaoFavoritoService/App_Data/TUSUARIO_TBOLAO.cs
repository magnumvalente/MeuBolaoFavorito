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
    
    public partial class TUSUARIO_TBOLAO
    {
        public System.Guid IDENTIFICADOR { get; set; }
        public System.Guid ID_USUARIO { get; set; }
        public System.Guid ID_BOLAO { get; set; }
        public bool ATIVO { get; set; }
        public Nullable<System.Guid> ID_USUARIO_RESPONSAVEL { get; set; }
    
        public virtual TBOLAO TBOLAO { get; set; }
        public virtual TUSUARIO TUSUARIO { get; set; }
        public virtual TUSUARIO TUSUARIO_RESPONSAVEL { get; set; }
    }
}
