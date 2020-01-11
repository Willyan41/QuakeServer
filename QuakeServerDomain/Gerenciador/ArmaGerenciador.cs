using QuakeServerDomain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuakeServerDomain.Gerenciador
{
    public class ArmaGerenciador : BaseGerenciador
    {

        public ArmaGerenciador()
        {
            _context = new Context.QuakeContext();
        }

        public void Add(Arma arma)
        {
            try
            {
                if (arma != null)
                {
                    if (arma.Id == 0)
                        _context.Arma.Add(arma);

                    _context.SaveChanges();

                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public Arma RecuperarPorId(int id)
        {
            return _context.Arma.Find(id);

        }

        public IQueryable<Arma> RecuperarArma()
        {
            return _context.Arma.Select(c => new Arma
            {

                Id = c.Id,
                IdCliente = c.IdCliente,
                IdArma1 = c.IdArma1,
                IdArma2 = c.IdArma2,
                IdArma3 = c.IdArma3,

            });

        }

        public void Delete(Arma arma)
        {

            try
            {
                if (arma != null)
                {
                    _context.Arma.Remove(arma);

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
