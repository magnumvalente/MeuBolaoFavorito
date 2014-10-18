using System.ServiceModel;

using MeuBolaoFavoritoCommon.Contracts;

namespace MeuBolaoFavoritoService.Interface
{ 
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        ResponseBolao GetBolao(RequestBolao request);
        [OperationContract]
        ResponseBolao GetBolaoById(RequestBolao request);
        [OperationContract]
        ResponseArquivo GetArquivo(RequestArquivo request);
        [OperationContract]
        ResponseArquivo GetArquivoById(RequestArquivo request);
        [OperationContract]
        ResponseUsuario GetUsuario(RequestUsuario request);
        [OperationContract]
        ResponseUsuario GetUsuarioById(RequestUsuario request);
        [OperationContract]
        ResponseUsuario SaveUsuario(RequestUsuario request);
    }
}