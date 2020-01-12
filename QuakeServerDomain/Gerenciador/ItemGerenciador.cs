using QuakeServerDomain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuakeServerDomain.Gerenciador
{
    public class ItemGerenciador : BaseGerenciador
    {

        public ItemGerenciador()
        {
            _context = new Context.QuakeContext();
        }

        public void Add(Item item)
        {
            try
            {
                if (item != null)
                {
                    if (item.Id == 0)
                    {
                        _context.Add(item);
                        _context.SaveChanges();
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Item RecuperarPorId(int id)
        {
            return _context.Item.Find(id);
        }

        public IQueryable<Item> RecuperarItem()
        {
            return _context.Item.Select(c => new Item
            {
                Id          = c.Id,
                Escudo      = c.Escudo,
                Nome        = c.Nome,
                Vida        = c.Vida,
            });
        }
        public void Delete(Item item)
        {
            try
            {
                if (item != null)
                {
                    _context.Remove(item);
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
