using System.Runtime.Serialization;

using MeuBolaoFavoritoCommon.Contracts;
using MeuBolaoFavoritoService.Interface;
using MeuBolaoFavoritoService.Business;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public ResponseBolao GetBolao(RequestBolao request)
    {
        return Bolao.GetBolao(request);
	}

    public ResponseBolao GetBolaoById(RequestBolao request)
    {
        return Bolao.GetBolaoById(request);
    }

    public ResponseArquivo GetArquivo(RequestArquivo request)
    {
        return Arquivo.GetArquivo(request);
    }

    public ResponseArquivo GetArquivoById(RequestArquivo request)
    {
        return Arquivo.GetArquivoById(request);
    }

    public ResponseUsuario GetUsuario(RequestUsuario request)
    {
        return Usuario.GetUsuario(request);
    }

    public ResponseUsuario GetUsuarioById(RequestUsuario request)
    {
        return Usuario.GetUsuarioById(request);
    }

    public ResponseUsuario SaveUsuario(RequestUsuario request)
    {
        return Usuario.SaveUsuario(request);
    }
}
