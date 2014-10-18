using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using MeuBolaoFavoritoCommon.Models;

namespace MeuBolaoFavoritoCommon.Contracts
{
    [DataContract]
    public class ResponseArquivo : Response
    {
        public ResponseArquivo()
        { 
            Code = Constantes.COD_FILTRO_VAZIO;
            Arquivos = new List<Models.Arquivo>();
        }

        [DataMember]
        public ICollection<Arquivo> Arquivos
        {
            get;
            set;
        }
    }
}
