using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using MeuBolaoFavoritoCommon.Models;

namespace MeuBolaoFavoritoCommon.Contracts
{
    [DataContract]
    public class RequestBolao : Request
    {
        [DataMember]
        public Bolao Bolao
        {
            get;
            set;
        }
    }
}
