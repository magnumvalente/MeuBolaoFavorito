using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using MeuBolaoFavoritoCommon.Models;

namespace MeuBolaoFavoritoCommon.Contracts
{
    [DataContract]
    public class RequestTime : Request
    {
        [DataMember]
        public Time Time
        {
            get;
            set;
        }
    }
}
