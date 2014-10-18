using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using MeuBolaoFavoritoCommon.Models;

namespace MeuBolaoFavoritoCommon.Contracts
{
    [DataContract]
    public class ResponseCompeticao : Response
    {
        public ResponseCompeticao()
        { 
            Code = Constantes.COD_FILTRO_VAZIO;
            Competicoes = new List<Models.Competicao>();
        }

        [DataMember]
        public ICollection<Competicao> Competicoes
        {
            get;
            set;
        }
    }
}
