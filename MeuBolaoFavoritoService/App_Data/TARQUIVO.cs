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
    
    public partial class TARQUIVO
    {
        public TARQUIVO()
        {
            this.TBOLAO = new HashSet<TBOLAO>();
            this.TTIME = new HashSet<TTIME>();
            this.TCOMPETICAO = new HashSet<TCOMPETICAO>();
        }
    
        public System.Guid IDENTIFICADOR { get; set; }
        public string NOME { get; set; }
        public string TIPO { get; set; }
        public byte[] ARQUIVO { get; set; }
    
        public virtual ICollection<TBOLAO> TBOLAO { get; set; }
        public virtual ICollection<TTIME> TTIME { get; set; }
        public virtual ICollection<TCOMPETICAO> TCOMPETICAO { get; set; }
    }
}
