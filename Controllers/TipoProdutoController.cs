using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;
using SmartCity.Models;
using SmartCity.Repository;
using System.Collections.Generic;

namespace SmartCity.Controllers
{
    public class TipoProdutoController : Controller
    {
        private readonly TipoProdutoRepository tipoProdutoRepository;

        public TipoProdutoController()
        {
            tipoProdutoRepository = new TipoProdutoRepository();
        }

        public IActionResult Index()
        {
            // Criando o atributo da lista - COLLECTIONS
            //IList<Models.TipoProduto> listaTipo = new List<Models.TipoProduto>();

            var listaTipo = tipoProdutoRepository.Listar();

            // Retornando para View a lista de Tipos
            return View(listaTipo);

        }

        // Anotação de uso do Verb HTTP Get
        [HttpGet]
        public IActionResult Cadastrar()
        {

            // Retorna para a View Cadastrar um 
            // objeto modelo com as propriedades em branco 
            return View(new TipoProduto());
        }

        [HttpPost]
        public IActionResult Cadastrar(Models.TipoProduto tipoProduto)
        {
            //// Validando o Campo Descricao - sem Data Annotation
            //if (string.IsNullOrEmpty(tipoProduto.DescricaoTipo))
            //{
            //    // Adicionando a mensagem de Erro para descrição em branco
            //    ModelState.AddModelError("Descricao", "Descrição obrigatória!");
            //}

            // Se o ModelState não tem nenhum erro
            if (ModelState.IsValid)
            {
                tipoProdutoRepository.Inserir(tipoProduto);

                // Gravando mensagem de sucesso na TempData
                @TempData["mensagem"] = "Tipo cadastrado com sucesso!";

                return RedirectToAction("Index", "TipoProduto");

                // Encontrou um erro no preenchimento do campo descriçao
            }
            else
            {
                // retorna para tela do formulário
                return View(tipoProduto);
            }
        }

        [HttpGet]
        public IActionResult Editar(int Id)
        {
            var tipoProduto = tipoProdutoRepository.Consultar(Id);

            // Retorna para a View o objeto modelo 
            // com as propriedades preenchidas com dados do banco de dados 
            return View(tipoProduto);
        }

        [HttpPost]
        public IActionResult Editar(Models.TipoProduto tipoProduto)
        {
            tipoProdutoRepository.Alterar(tipoProduto);

            // Substituímos o return View()
            // pelo método de redirecionamento
            return RedirectToAction("Index", "TipoProduto");
        }

        [HttpGet]
        public IActionResult Consultar(int Id)
        {
            var tipoProduto = tipoProdutoRepository.Consultar(Id);
            return View(tipoProduto);
        }

        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            tipoProdutoRepository.Excluir(Id);

            // Substituímos o return View()
            // pelo método de redirecionamento
            return RedirectToAction("Index", "TipoProduto");
        }
    }
}