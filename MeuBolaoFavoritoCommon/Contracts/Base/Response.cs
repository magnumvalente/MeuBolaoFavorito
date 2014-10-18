using System.Runtime.Serialization;

namespace MeuBolaoFavoritoCommon.Contracts
{

    [DataContract]
    public class Response
    {

        [DataMember]
        public int Code
        {
            get;
            set;
        }

        [DataMember]
        public string Mensage
        {
            get;
            set;
        }

        [DataMember]
        public long Duration
        {
            get;
            set;
        }
    }
}
