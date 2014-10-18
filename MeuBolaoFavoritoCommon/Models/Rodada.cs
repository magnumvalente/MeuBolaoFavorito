using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MeuBolaoFavoritoCommon.Models
{
    [DataContract]
    public class Rodada
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public short Order { get; set; }
        [DataMember]
        public short Peso { get; set; }
        [DataMember]      
        public Guid IdCompeticao { get; set; }

        [DataMember]
        public virtual Competicao Competicao { get; set; }
        [DataMember]
        public virtual ICollection<Jogo> Jogos { get; set; }
    }
}
