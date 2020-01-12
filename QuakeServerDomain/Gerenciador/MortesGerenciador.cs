using QuakeServerDomain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuakeServerDomain.Gerenciador
{
    public class MortesGerenciador : BaseGerenciador
    {

        public MortesGerenciador()
        {
            _context = new Context.QuakeContext();
        }

        public void Add(Mortes mortes)
        {
            try
            {
                if (mortes != null)
                {
                    if (mortes.Id == 0)
                    {
                        _context.Add(mortes);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public Mortes RecuperarPorId(int id)
        {
            return _context.Mortes.Find(id);
        }

        public IQueryable<Mortes> RecuperarMortes()
        {
            return _context.Mortes.Select(c => new Mortes()
            {
                Id              = c.Id,
                IdArma          = c.IdArma,
                IdClienteMatou  = c.IdClienteMatou,
                IdClienteMorto  = c.IdClienteMorto,
                IdPartida       = c.IdPartida,
                Quantidade      = c.Quantidade,
            });
        }

        public void Delete(Mortes mortes)
        {
            try
            {
                if (mortes != null)
                {
                    _context.Remove(mortes);
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
