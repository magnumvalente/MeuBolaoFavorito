using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using MeuBolaoFavoritoCommon.Models;

namespace MeuBolaoFavoritoCommon.Contracts
{
    [DataContract]
    public class RequestCompeticao : Request
    {
        [DataMember]
        public Competicao Competicao
        {
            get;
            set;
        }
    }
}
