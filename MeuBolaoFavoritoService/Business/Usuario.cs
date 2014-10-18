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
    abstract class Usuario : Base.Business
    {
        private static DB_BOLAO _context = new DB_BOLAO();

        internal static ResponseUsuario GetUsuario(RequestUsuario request)
        {
            ResponseUsuario retornoUsuario = new ResponseUsuario();

            retornoUsuario.Usuarios = _context.TUSUARIO.
            Select(u => new Models.Usuario
            {
                Id = u.IDENTIFICADOR,
                Login = u.LOGIN,
                Name = u.NOME,
                Active = u.ATIVO
            }).ToList();

            return retornoUsuario;
        }

        internal static ResponseUsuario GetUsuarioById(RequestUsuario request)
        {
            ResponseUsuario retornoUsuario = new ResponseUsuario();

            if (request != null && request.Usuario != null)
            {

                TUSUARIO tUsuario = _context.TUSUARIO.FirstOrDefault(t => t.IDENTIFICADOR == request.Usuario.Id);

                if (tUsuario != null)
                    retornoUsuario.Usuarios = new List<Models.Usuario> 
                    {
                        new Models.Usuario 
                        {
                            Id = tUsuario.IDENTIFICADOR,
                            Login = tUsuario.LOGIN,
                            Name = tUsuario.NOME,
                            Active = tUsuario.ATIVO
                        }
                    };
            }

            return retornoUsuario;
        }

        public static ResponseUsuario SaveUsuario(RequestUsuario request)
        {
            ResponseUsuario retornoUsuario = new ResponseUsuario();

            if (request.New.HasValue && request.New.Value)
                retornoUsuario.Usuarios = new List<Models.Usuario> { CreateUsuario(request.Usuario) };
            else
                retornoUsuario.Usuarios = new List<Models.Usuario> { ChangeUsuario(request.Usuario) };

            return retornoUsuario;
        }

        private static Models.Usuario CreateUsuario(Models.Usuario usuario)
        {
            _context.TUSUARIO.Add(new TUSUARIO
            {
                IDENTIFICADOR = usuario.Id,
                LOGIN = usuario.Login,
                NOME = usuario.Name,
                ATIVO = usuario.Active
            });
            _context.SaveChanges();

            return usuario;
        }

        private static Models.Usuario ChangeUsuario(Models.Usuario usuario)
        {
            TUSUARIO tUsuario = _context.TUSUARIO.Find(usuario.Id);

            if (tUsuario != null)
            {
                tUsuario.LOGIN = usuario.Login;
                tUsuario.NOME = usuario.Name;
                tUsuario.ATIVO = usuario.Active;
            }

            _context.SaveChanges();

            return usuario;
        }
    }
}