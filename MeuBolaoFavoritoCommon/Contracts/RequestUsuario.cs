using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using MeuBolaoFavoritoCommon.Models;

namespace MeuBolaoFavoritoCommon.Contracts
{
    [DataContract]
    public class RequestUsuario : Request
    {
        [DataMember]
        public Usuario Usuario
        {
            get;
            set;
        }
    }
}
