using QuakeServerDomain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuakeServerDomain.Gerenciador
{
    public class TipoPartidaGerenciador : BaseGerenciador
    {

        public TipoPartidaGerenciador()
        {
            _context = new Context.QuakeContext();
        }

        public void Add(TipoPartida tipoPartida)
        {
            try
            {
                if (tipoPartida != null)
                {
                    if (tipoPartida.Id == 0)
                    {
                        _context.Add(tipoPartida);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TipoPartida RecuperarPorId(int id)
        {
            return _context.TipoPartida.Find(id);
        }

        public IQueryable<TipoPartida> RecuperarTipoPartida()
        {
            return _context.TipoPartida.Select(c => new TipoPartida()
            {
                Id      = c.Id,
                Tipo    = c.Tipo,
            });
        }
        public void Delete(TipoPartida tipoPartida)
        {
            try
            {
                if (tipoPartida != null)
                {
                    _context.Remove(tipoPartida);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
