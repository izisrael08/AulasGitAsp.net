﻿using ControleDeContatos.Models;
using ControleDeContatos.repository;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            ContatoModel contato =_contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(ContatoModel contato )
        {
            _contatoRepositorio.Adicionar( contato );
            return RedirectToAction("Index");   
        }

        [HttpPost]
        public IActionResult Editar(ContatoModel Editar)
        {
            _contatoRepositorio.Editar(Editar);
            return RedirectToAction("Index");
        }
    }
}
