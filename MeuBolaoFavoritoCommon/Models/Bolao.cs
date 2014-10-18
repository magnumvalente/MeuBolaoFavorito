using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MeuBolaoFavoritoCommon.Models
{
    [DataContract]
    public class Bolao
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
        public Guid IdRegra { get; set; }
        [DataMember]
        public Guid IdCompeticao{ get; set; }
        [DataMember]
        public Guid? IdArquivo { get; set; }

        [DataMember]
        public Competicao Competicao { get; set; }
        [DataMember]
        public Regra Regra { get; set; }
        [DataMember]
        public Arquivo Arquivo { get; set; }

    }
}
