using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using MeuBolaoFavoritoCommon.Models;

namespace MeuBolaoFavoritoCommon.Contracts
{
    [DataContract]
    public class ResponseTime : Response
    {
        public ResponseTime()
        { 
            Code = Constantes.COD_FILTRO_VAZIO;
            Times = new List<Models.Time>();
        }

        [DataMember]
        public ICollection<Time> Times
        {
            get;
            set;
        }
    }
}
