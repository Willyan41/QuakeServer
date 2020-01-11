using QuakeServerDomain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuakeServerDomain.Gerenciador
{
    public class ArmasGerenciador : BaseGerenciador
    {

        public ArmasGerenciador()
        {
            _context = new Context.QuakeContext();

        }

        public void Add(Armas armas)
        {
            try
            {
                if (armas != null)
                {
                    if (armas.Id == 0)
                        _context.Add(armas);
                    _context.SaveChanges();
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public Armas RecuperarPorId(int id)
        {
            return _context.Armas.Find(id);
        }

        public IQueryable<Armas> RecuperarArmas()
        {

            return _context.Armas.Select(c => new Armas
            {
                Id = c.Id,
                Dano = c.Dano,
                Municao = c.Municao,
                NomeArma = c.NomeArma,

            });
        }

        public void Delete(Armas armas)
        {
            try
            {
                if (armas != null)
                {
                    _context.Remove(armas);
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
