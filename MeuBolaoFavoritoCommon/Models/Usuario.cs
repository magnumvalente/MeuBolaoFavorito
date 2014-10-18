using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MeuBolaoFavoritoCommon.Models
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool Active { get; set; }

    }
}
