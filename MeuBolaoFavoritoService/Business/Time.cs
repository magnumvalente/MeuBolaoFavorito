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
    abstract class Time : Base.Business
    {
        private static DB_BOLAO _context = new DB_BOLAO();

        internal static ResponseTime GetTime(RequestTime request)
        {
            ResponseTime retornoTime = new ResponseTime();

            retornoTime.Times = _context.TTIME.
            Select(t => new Models.Time
            {
                Id = t.IDENTIFICADOR,
                ShortName = t.NOME_CURTO,
                LongName = t.NOME_LONGO,
                IdArquivo = t.ID_ARQUIVO
            }).ToList();

            return retornoTime;
        }

        internal static ResponseTime GetTimeById(RequestTime request)
        {
            ResponseTime retornoTime = new ResponseTime();

            if (request != null && request.Time != null)
            {

                TTIME tTime = _context.TTIME.Include(t => t.TARQUIVO).FirstOrDefault(t => t.IDENTIFICADOR == request.Time.Id);

                if (tTime != null)
                    retornoTime.Times = new List<Models.Time> 
                    {
                        new Models.Time 
                        {
                            Id = tTime.IDENTIFICADOR,
                            ShortName = tTime.NOME_CURTO,
                            LongName = tTime.NOME_LONGO,
                            IdArquivo = tTime.ID_ARQUIVO,
                            Arquivo = new Models.Arquivo
                            {
                                Id = tTime.TARQUIVO.IDENTIFICADOR,
                                File = tTime.TARQUIVO.ARQUIVO,
                                Name = tTime.TARQUIVO.NOME,
                                Type = tTime.TARQUIVO.TIPO
                            }
                        }
                    };
            }

            return retornoTime;
        }

        internal static ResponseTime GetTimeByCompeticaoId(RequestCompeticao request)
        {
            ResponseTime retornoTime = new ResponseTime();

            if (request != null && request.Competicao != null)
            {

                retornoTime.Times = _context.TTIME.Where(T => T.TJOGO1.Where(j => j.TRODADA.ID_COMPETICAO == request.Competicao.Id).Count() > 0).
                                    Select(t => new Models.Time
                                    {
                                        Id = t.IDENTIFICADOR,
                                        ShortName = t.NOME_CURTO,
                                        LongName = t.NOME_LONGO,
                                        IdArquivo = t.ID_ARQUIVO
                                    }).ToList();
            }

            return retornoTime;
        }        

    }
}