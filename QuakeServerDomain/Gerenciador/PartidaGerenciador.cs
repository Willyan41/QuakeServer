﻿using QuakeServerDomain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuakeServerDomain.Gerenciador
{
    public class PartidaGerenciador : BaseGerenciador
    {
        public PartidaGerenciador()
        {
            _context = new Context.QuakeContext();
        }

        public void Add(Partida partida)
        {
            try
            {
                if (partida != null)
                {
                    if (partida.Id == 0)
                    {
                        _context.Add(partida);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public Partida RecuperarPorId(int id)
        {
            return _context.Partida.Find(id);
        }

        public IQueryable<Partida> RecuperarPartida()
        {
            return _context.Partida.Select(c => new Partida()
            {
                Id              = c.Id,
                Cliente         = c.Cliente,
                NMaxJogadores   = c.NMaxJogadores,
                ScoreCliente    = c.ScoreCliente,
                Tipo            = c.Tipo,
                TotalMortes     = c.TotalMortes,
            });
        }

        public void Delete(Partida partida)
        {
            try
            {
                if (partida != null)
                {
                    _context.Remove(partida);
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
