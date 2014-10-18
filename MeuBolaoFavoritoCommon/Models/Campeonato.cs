using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MeuBolaoFavoritoCommon.Models
{
    [DataContract]
    public class Competicao
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string ShortName { get; set; }
        [DataMember]
        public string LongName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public bool Active { get; set; }
        [DataMember]
        public Guid? IdArquivo { get; set; }

        [DataMember]
        public virtual Arquivo Arquivo { get; set; }
        [DataMember]
        public virtual ICollection<Rodada> Rodadas { get; set; }

    }
}
