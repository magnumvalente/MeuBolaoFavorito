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
    
    public partial class TBOLAO
    {
        public TBOLAO()
        {
            this.TUSUARIO_TBOLAO = new HashSet<TUSUARIO_TBOLAO>();
        }
    
        public System.Guid IDENTIFICADOR { get; set; }
        public string NOME_CURTO { get; set; }
        public string NOME_LONGO { get; set; }
        public string DESCRICAO { get; set; }
        public System.DateTime DATA_INICIO { get; set; }
        public System.DateTime DATA_FIM { get; set; }
        public bool ATIVO { get; set; }
        public System.Guid ID_REGRA { get; set; }
        public Nullable<System.Guid> ID_ARQUIVO { get; set; }
        public System.Guid ID_COMPETICAO { get; set; }
    
        public virtual TARQUIVO TARQUIVO { get; set; }
        public virtual TREGRA TREGRA { get; set; }
        public virtual ICollection<TUSUARIO_TBOLAO> TUSUARIO_TBOLAO { get; set; }
        public virtual TCOMPETICAO TCOMPETICAO { get; set; }
    }
}
