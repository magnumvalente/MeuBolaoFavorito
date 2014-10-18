using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using MeuBolaoFavoritoCommon.Models;

namespace MeuBolaoFavoritoCommon.Contracts
{
    [DataContract]
    public class ResponseBolao : Response
    {
        public ResponseBolao()
        { 
            Code = Constantes.COD_FILTRO_VAZIO;
            Boloes = new List<Models.Bolao>();
        }

        [DataMember]
        public ICollection<Bolao> Boloes
        {
            get;
            set;
        }
    }
}
