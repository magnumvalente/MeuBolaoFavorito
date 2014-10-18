using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MeuBolaoFavoritoCommon.Models
{
    [DataContract]
    public class Jogo
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public short Order { get; set; }
        [DataMember]
        public short Peso { get; set; }
        [DataMember]
        public DateTime? Date { get; set; }
        [DataMember]
        public Guid IdRodada { get; set; }
        [DataMember]
        public Guid IdTime1 { get; set; }
        [DataMember]   
        public short? GolsTime1 { get; set; }
        [DataMember]
        public Guid IdTime2 { get; set; }
        [DataMember]
        public short? GolsTime2 { get; set; }

        [DataMember]
        public virtual Rodada Rodada { get; set; }
        [DataMember]
        public virtual Time Time1 { get; set; }
        [DataMember]
        public virtual Time Time2 { get; set; }
    }
}

