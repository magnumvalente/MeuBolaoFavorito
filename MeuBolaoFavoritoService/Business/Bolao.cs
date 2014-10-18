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
    abstract class Bolao: Base.Business
    {
        private static DB_BOLAO _context = new DB_BOLAO();
              
        internal static ResponseBolao GetBolao(RequestBolao request)
        {
            ResponseBolao retornoBolao = new ResponseBolao();

            retornoBolao.Boloes = _context.TBOLAO.Include(b => b.TREGRA)
            .Where(b => b.ATIVO == true)
            .Select(b => new Models.Bolao
            {
                Id = b.IDENTIFICADOR,
                ShortName = b.NOME_CURTO,
                LongName = b.NOME_LONGO,
                Description = b.DESCRICAO,
                StartDate = b.DATA_INICIO,
                EndDate = b.DATA_FIM,
                Active = b.ATIVO,
                IdArquivo = b.ID_ARQUIVO,
                IdCompeticao = b.ID_COMPETICAO,
                IdRegra = b.ID_REGRA,
                Regra = new Models.Regra
                {
                    Id = b.TREGRA.IDENTIFICADOR,
                    Description = b.TREGRA.DESCRICAO,
                    TypeBolao = b.TREGRA.TIPO_BOLAO,
                    AllowResource = b.TREGRA.PERMITE_RECURSO,
                    AllowPremium = b.TREGRA.PREMIADO
                },
                Competicao = new Models.Competicao
                {
                    Id = b.TCOMPETICAO.IDENTIFICADOR,
                    ShortName = b.TCOMPETICAO.NOME_CURTO,
                    LongName = b.TCOMPETICAO.NOME_LONGO,
                    Description = b.TCOMPETICAO.DESCRICAO,
                    StartDate = b.TCOMPETICAO.DATA_INICIO,
                    EndDate = b.TCOMPETICAO.DATA_FIM,
                    Active = b.TCOMPETICAO.ATIVO,
                    IdArquivo = b.TCOMPETICAO.ID_ARQUIVO
                }
            }).ToList();

            return retornoBolao;
        }

        internal static ResponseBolao GetBolaoById(RequestBolao request)
        {
            ResponseBolao retornoBolao = new ResponseBolao();

            if (request != null && request.Bolao != null)
            {

                TBOLAO tbolao = _context.TBOLAO
                .Include(b => b.TREGRA)
                .Include(b => b.TCOMPETICAO)
                .Include(b => b.TCOMPETICAO.TRODADA.Select(r => r.TJOGO.Select(j => j.TTIME1)))
                .Include(b => b.TCOMPETICAO.TRODADA.Select(r => r.TJOGO.Select(j => j.TTIME2)))
                .FirstOrDefault(b => b.ATIVO == true && b.IDENTIFICADOR == request.Bolao.Id);
            
                if (tbolao != null)
                    retornoBolao.Boloes = new List<Models.Bolao> 
                    {
                        new Models.Bolao 
                        {
                            Id = tbolao.IDENTIFICADOR,
                            ShortName = tbolao.NOME_CURTO,
                            LongName = tbolao.NOME_LONGO,
                            Description = tbolao.DESCRICAO,
                            StartDate = tbolao.DATA_INICIO,
                            EndDate = tbolao.DATA_FIM,
                            Active = tbolao.ATIVO,
                            IdArquivo = tbolao.ID_ARQUIVO,
                            IdCompeticao = tbolao.ID_COMPETICAO,
                            IdRegra = tbolao.ID_REGRA,
                            Regra = new Models.Regra 
                            {
                                Id = tbolao.TREGRA.IDENTIFICADOR,
                                Description = tbolao.TREGRA.DESCRICAO,
                                TypeBolao = tbolao.TREGRA.TIPO_BOLAO,
                                AllowResource = tbolao.TREGRA.PERMITE_RECURSO,
                                AllowPremium = tbolao.TREGRA.PREMIADO
                            },
                            Competicao = new Models.Competicao 
                            {
                                Id = tbolao.TCOMPETICAO.IDENTIFICADOR,
                                ShortName = tbolao.TCOMPETICAO.NOME_CURTO,
                                LongName = tbolao.TCOMPETICAO.NOME_LONGO,
                                Description = tbolao.TCOMPETICAO.DESCRICAO,
                                StartDate = tbolao.TCOMPETICAO.DATA_INICIO,
                                EndDate = tbolao.TCOMPETICAO.DATA_FIM,
                                Active = tbolao.TCOMPETICAO.ATIVO,
                                IdArquivo = tbolao.TCOMPETICAO.ID_ARQUIVO,
                                Rodadas = tbolao.TCOMPETICAO.TRODADA.Select(r => new Models.Rodada
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
                        }
                    };
            }

            return retornoBolao;
        }

        private static ResponseBolao SaveBolao(RequestBolao request)
        {
            ResponseBolao retornoBolao = new ResponseBolao();

            if (request.New.HasValue && request.New.Value)
                retornoBolao.Boloes = new List<Models.Bolao> { CreateBolao(request.Bolao) };
            else
                retornoBolao.Boloes = new List<Models.Bolao> { ChangeBolao(request.Bolao) };

            return retornoBolao;
        }

        private static Models.Bolao CreateBolao(Models.Bolao bolao)
        {
            _context.TBOLAO.Add(new TBOLAO 
            { 
                IDENTIFICADOR = bolao.Id,
                NOME_CURTO = bolao.ShortName,
                NOME_LONGO = bolao.LongName,
                DESCRICAO = bolao.Description,
                DATA_INICIO = bolao.StartDate,
                DATA_FIM = bolao.EndDate,
                ATIVO = bolao.Active,
                ID_ARQUIVO = bolao.IdArquivo,
                ID_COMPETICAO = bolao.IdCompeticao,
                ID_REGRA = bolao.IdRegra
            });
            _context.SaveChanges();
            
            return bolao;
        }

        private static Models.Bolao ChangeBolao(Models.Bolao bolao)
        {
            TBOLAO tBolao = _context.TBOLAO.Find(bolao.Id);

            if (tBolao != null)
            {
                tBolao.NOME_CURTO = bolao.ShortName;
                tBolao.NOME_LONGO = bolao.LongName;
                tBolao.DESCRICAO = bolao.Description;
                tBolao.DATA_INICIO = bolao.StartDate;
                tBolao.DATA_FIM = bolao.EndDate;
                tBolao.ATIVO = bolao.Active;
                tBolao.ID_ARQUIVO = bolao.IdArquivo;
                tBolao.ID_COMPETICAO = bolao.IdCompeticao;
                tBolao.ID_REGRA = bolao.IdRegra;
            }

            _context.SaveChanges();

            return bolao;
        }
    }
}