using QuakeServerDomain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuakeServerDomain.Gerenciador
{
    public class ClienteGerenciador : BaseGerenciador
    {

        public ClienteGerenciador()
        {
            _context = new Context.QuakeContext();

        }


        public void Add(Cliente cliente)
        {
            try
            {
                if (cliente != null)
                {
                    if (cliente.Id == 0)
                        _context.Add(cliente);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public Cliente RecuperarPorId(int id)
        {
            return _context.Cliente.Find(id);
        }

        public IQueryable<Cliente> RecuperarCliente()
        {

            return _context.Cliente.Select(c => new Cliente()
            {
                Id                  = c.Id,
                IdPosicao           = c.IdPosicao,
                Escudo              = c.Escudo,
                Matou               = c.Matou,
                Morreu              = c.Morreu,
                NickName            = c.NickName,
                Personagem          = c.Personagem,
                Personagem_Alterado = c.Personagem_Alterado,
                Vida                = c.Vida,
            });
        }

        public void Delete(Cliente cliente)
        {
            try
            {
                if (cliente != null)
                {
                    _context.Remove(cliente);
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
