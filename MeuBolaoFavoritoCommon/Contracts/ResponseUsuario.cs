using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using MeuBolaoFavoritoCommon.Models;

namespace MeuBolaoFavoritoCommon.Contracts
{
    [DataContract]
    public class ResponseUsuario : Response
    {
        public ResponseUsuario()
        { 
            Code = Constantes.COD_FILTRO_VAZIO;
            Usuarios = new List<Models.Usuario>();
        }

        [DataMember]
        public ICollection<Usuario> Usuarios
        {
            get;
            set;
        }
    }
}
