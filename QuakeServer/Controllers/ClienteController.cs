using Microsoft.AspNetCore.Mvc;
using QuakeServer.Models;
using QuakeServerDomain.Entidade;
using QuakeServerDomain.Gerenciador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuakeServer.Controllers
{
    public class ClienteController : Controller
    {
        ClienteGerenciador gerenciadorCliente;

        public ClienteController()
        {
            gerenciadorCliente = new ClienteGerenciador();

        }


        public IActionResult Index()
        {


            var Clientes = gerenciadorCliente.RecuperarCliente()
                .Select(p => new ClienteViewModel()
                {
                    Id = p.Id,
                    IdPosicao = p.IdPosicao,
                    NickName = p.NickName,
                    Personagem = p.Personagem,
                    Personagem_Alterado = p.Personagem_Alterado,
                    Vida = p.Vida,
                    Escudo = p.Escudo,
                    Matou = p.Matou,
                    Morreu = p.Morreu,

                });

            var model = new ClienteViewModel();
            model.Clientes = Clientes;

            return View(model);

        }

        [HttpGet]
        public IActionResult Add(int id)
        {
            var p = gerenciadorCliente.RecuperarPorId(id);
            var model = new ClienteViewModel
            {
                Id = p.Id,
                IdPosicao = p.IdPosicao,
                NickName = p.NickName,
                Personagem = p.Personagem,
                Personagem_Alterado = p.Personagem_Alterado,
                Vida = p.Vida,
                Escudo = p.Escudo,
                Matou = p.Matou,
                Morreu = p.Morreu,
            };

            return PartialView(model);
        }

        [HttpPost]
        public IActionResult Add(ClienteViewModel model)
        {

            if (ModelState.IsValid)
            {
                Cliente p = null;

                if (model.Id > 0)
                {
                    p = gerenciadorCliente.RecuperarPorId(model.Id);
                }

                else

                {
                    p = new Cliente();

                }

                p.IdPosicao = model.IdPosicao;
                p.NickName = model.NickName;
                p.Personagem = model.Personagem;
                p.Personagem_Alterado = model.Personagem_Alterado;
                p.Vida = model.Vida;
                p.Escudo = model.Escudo;
                p.Matou = model.Matou;
                p.Morreu = model.Morreu;

                gerenciadorCliente.Add(p);

            }

            return RedirectToAction("Index");


        }

































    }
}
