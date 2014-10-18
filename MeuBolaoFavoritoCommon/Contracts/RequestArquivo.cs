using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using MeuBolaoFavoritoCommon.Models;

namespace MeuBolaoFavoritoCommon.Contracts
{
    [DataContract]
    public class RequestArquivo : Request
    {
        [DataMember]
        public Arquivo Arquivo
        {
            get;
            set;
        }
    }
}
