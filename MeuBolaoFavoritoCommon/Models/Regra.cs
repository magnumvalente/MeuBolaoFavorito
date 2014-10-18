using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MeuBolaoFavoritoCommon.Models
{
    [DataContract]
    public class Regra
    {
        [DataMember]
        public Guid Id { get; set; }       
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string TypeBolao { get; set; }
        [DataMember]
        public bool AllowResource { get; set; }
        [DataMember]
        public bool AllowPremium { get; set; }
    }
}
