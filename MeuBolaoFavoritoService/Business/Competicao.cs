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
    abstract class Competicao : Base.Business
    {
        private static DB_BOLAO _context = new DB_BOLAO();

        internal static ResponseCompeticao GetCompeticao(RequestCompeticao request)
        {
            ResponseCompeticao retornoCompeticao = new ResponseCompeticao();

            retornoCompeticao.Competicoes = _context.TCOMPETICAO.
            Select(t => new Models.Competicao
            {
                Id = t.IDENTIFICADOR,
                ShortName = t.NOME_CURTO,
                LongName = t.NOME_LONGO,
                IdArquivo = t.ID_ARQUIVO
            }).ToList();

            return retornoCompeticao;
        }

        internal static ResponseCompeticao GetCompeticaoById(RequestCompeticao request)
        {
            ResponseCompeticao retornoCompeticao = new ResponseCompeticao();

            if (request != null && request.Competicao != null)
            {

                TCOMPETICAO tCompeticao = _context.TCOMPETICAO
                    .Include(c => c.TARQUIVO)
                    .Include(c => c.TRODADA.Select(r => r.TJOGO.Select(j => j.TTIME1)))
                    .Include(c => c.TRODADA.Select(r => r.TJOGO.Select(j => j.TTIME2)))
                    .FirstOrDefault(t => t.IDENTIFICADOR == request.Competicao.Id);

                if (tCompeticao != null)
                    retornoCompeticao.Competicoes = new List<Models.Competicao> 
                    {
                        new Models.Competicao 
                        {
                            Id = tCompeticao.IDENTIFICADOR,
                            ShortName = tCompeticao.NOME_CURTO,
                            LongName = tCompeticao.NOME_LONGO,
                            Description = tCompeticao.DESCRICAO,
                            StartDate = tCompeticao.DATA_INICIO,
                            EndDate = tCompeticao.DATA_FIM,
                            Active = tCompeticao.ATIVO,
                            IdArquivo = tCompeticao.ID_ARQUIVO,                            
                            Rodadas = tCompeticao.TRODADA.Select(r => new Models.Rodada
                            {
                                Id = r.IDENTIFICADOR,
                                Name = r.NOME,
                                Order = r.NUMERO,
                                Peso = r.PESO,
                                IdCompeticao = r.ID_COMPETICAO,
                                Jogos = r.TJOGO.Select(j => new Models.Jogo
                                {
                                    Id = j.IDENTIFICADOR,
                                    Date = j.DATA,
                                    Order = j.NUMERO,
                                    Peso = j.PESO,
                                    GolsTime1 = j.GOLS_TIME1,
                                    GolsTime2 = j.GOLS_TIME2,
                                    IdTime1 = j.ID_TIME1,
                                    Time1 = new Models.Time
                                    {
                                        Id = j.TTIME1.IDENTIFICADOR,
                                        ShortName = j.TTIME1.NOME_CURTO,
                                        LongName = j.TTIME1.NOME_LONGO,
                                        IdArquivo = j.TTIME1.ID_ARQUIVO
                                    },
                                    IdTime2 = j.ID_TIME2,
                                    Time2 = new Models.Time
                                    {
                                        Id = j.TTIME2.IDENTIFICADOR,
                                        ShortName = j.TTIME2.NOME_CURTO,
                                        LongName = j.TTIME2.NOME_LONGO,
                                        IdArquivo = j.TTIME2.ID_ARQUIVO
                                    },
                                    IdRodada = r.IDENTIFICADOR                                    
                                }).ToList()
                            }).ToList()
                        }
                    };
            }

            return retornoCompeticao;
        }        
    }
}