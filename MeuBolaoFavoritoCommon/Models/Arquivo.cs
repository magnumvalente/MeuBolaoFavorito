using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MeuBolaoFavoritoCommon.Models
{
    [DataContract]
    public class Arquivo
    {
        [DataMember]
        public System.Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public byte[] File { get; set; }     
    }
}
