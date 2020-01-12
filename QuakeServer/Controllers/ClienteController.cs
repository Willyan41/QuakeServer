using Microsoft.AspNetCore.Mvc;
using QuakeServer.Models;
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




































    }
}
