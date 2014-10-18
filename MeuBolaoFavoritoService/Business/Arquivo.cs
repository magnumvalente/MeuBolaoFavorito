using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

using MeuBolaoFavoritoCommon;
using MeuBolaoFavoritoCommon.Contracts;
using Models = MeuBolaoFavoritoCommon.Models;
using MeuBolaoFavoritoService.App_Data;

namespace MeuBolaoFavoritoService.Business
{
    abstract class Arquivo : Base.Business
    {
        private static DB_BOLAO _context = new DB_BOLAO();

        internal static ResponseArquivo GetArquivo(RequestArquivo request)
        {
            ResponseArquivo retornoArquivo = new ResponseArquivo();

            retornoArquivo.Arquivos = _context.TARQUIVO.
            Select(a => new Models.Arquivo
            {
                Id = a.IDENTIFICADOR,
                File = a.ARQUIVO,
                Name = a.NOME,
                Type = a.TIPO
            }).ToList();

            return retornoArquivo;
        }

        internal static ResponseArquivo GetArquivoById(RequestArquivo request)
        {
            ResponseArquivo retornoArquivo = new ResponseArquivo();

            if (request != null && request.Arquivo != null)
            {

                TARQUIVO tArquivo = _context.TARQUIVO.FirstOrDefault(a => a.IDENTIFICADOR == request.Arquivo.Id);
            
                if (tArquivo != null)
                    retornoArquivo.Arquivos = new List<Models.Arquivo> 
                    {
                        new Models.Arquivo 
                        {
                            Id = tArquivo.IDENTIFICADOR,
                            File = tArquivo.ARQUIVO,
                            Name = tArquivo.NOME,
                            Type = tArquivo.TIPO
                        }
                    };
            }

            return retornoArquivo;
        }

        private static ResponseArquivo SaveArquivo(RequestArquivo request)
        {
            ResponseArquivo retornoArquivo = new ResponseArquivo();

            if (request.New.HasValue && request.New.Value)
                retornoArquivo.Arquivos = new List<Models.Arquivo> { CreateArquivo(request.Arquivo) };
            else
                retornoArquivo.Arquivos = new List<Models.Arquivo> { ChangeArquivo(request.Arquivo) };

            return retornoArquivo;
        }

        private static Models.Arquivo CreateArquivo(Models.Arquivo arquivo)
        {
            _context.TARQUIVO.Add(new TARQUIVO 
            {
                IDENTIFICADOR = arquivo.Id,
                ARQUIVO = arquivo.File,
                NOME = arquivo.Name,
                TIPO = arquivo.Type
            });
            _context.SaveChanges();

            return arquivo;
        }

        private static Models.Arquivo ChangeArquivo(Models.Arquivo arquivo)
        {
            TARQUIVO tArquivo = _context.TARQUIVO.Find(arquivo.Id);

            if (tArquivo != null)
            {
                tArquivo.ARQUIVO = arquivo.File;
                tArquivo.NOME = arquivo.Name;
                tArquivo.TIPO = arquivo.Type;
            }

            _context.SaveChanges();

            return arquivo;
        }
    }
}