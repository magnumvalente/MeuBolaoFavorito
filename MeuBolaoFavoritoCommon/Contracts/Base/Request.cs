using System.Runtime.Serialization;

namespace MeuBolaoFavoritoCommon.Contracts
{
    [DataContract]
    public class Request
    {
    
        [DataMember]
        public string User
        {
            get;
            set;
        }

        [DataMember]
        public string Key
        {
            get;
            set;
        }

        [DataMember]
        public bool? New
        {
            get;
            set;
        }

        [DataMember]
        public bool Paginar
        {
            get;
            set;
        }

        [DataMember]
        public int CountItems
        {
            get;
            set;
        }

        [DataMember]
        public int PositionLastItem
        {
            get;
            set;
        }

        [DataMember]
        public bool ImpuntListSelection
        {
            get;
            set;
        }
    }
}
