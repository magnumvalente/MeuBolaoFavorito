using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MeuBolaoFavoritoCommon.Models
{
    [DataContract]
    public class Time
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string ShortName { get; set; }
        [DataMember]
        public string LongName { get; set; }
        [DataMember]      
        public Guid? IdArquivo { get; set; }

        [DataMember]
        public virtual Arquivo Arquivo { get; set; }

    }
}
