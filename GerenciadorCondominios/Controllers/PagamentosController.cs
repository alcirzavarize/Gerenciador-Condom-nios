using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenciadorCondominios.BLL.Models;
using GerenciadorCondominios.DAL;
using GerenciadorCondominios.DAL.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace GerenciadorCondominios.Controllers
{
    [Authorize]
    public class PagamentosController : Controller
    {
        private readonly IPagamentoRepositorio _pagamentoRepositorio;
        private readonly IAluguelRepositorio _aluguelRepositorio;
        private readonly IHistoricoRecursosRepositorio _historicoRecursosRepositorio;
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        
        

        public PagamentosController(IAluguelRepositorio aluguelRepositorio, IUsuarioRepositorio usuarioRepositorio, IPagamentoRepositorio pagamentoRepositorio, IHistoricoRecursosRepositorio historicoRecursosRepositorio)
        {
            _aluguelRepositorio = aluguelRepositorio;
            _usuarioRepositorio = usuarioRepositorio;
            _pagamentoRepositorio = pagamentoRepositorio;
            _historicoRecursosRepositorio = historicoRecursosRepositorio;
        }

        
        public async Task<IActionResult> Index()
        {
            Usuario usuario = await _usuarioRepositorio.PegarUsuarioPeloNome(User);
            return View(await _pagamentoRepositorio.PegarPagamentoPorUsuario(usuario.Id));
        }

        public async Task<IActionResult> EfetuarPagamento(int id)
        {
            Pagamento pagamento = await _pagamentoRepositorio.PegarPeloId(id);
            pagamento.DataPagamento = DateTime.Now.Date;
            pagamento.Status = StatusPagamento.Pago;
            await _pagamentoRepositorio.Atualizar(pagamento);

            Aluguel aluguel = await _aluguelRepositorio.PegarPeloId(pagamento.AluguelId);

            HistoricoRecurso hr = new HistoricoRecurso
            {
                Valor = aluguel.Valor,
                MesId = aluguel.MesId,
                Dia = DateTime.Now.Day,
                Ano = aluguel.Ano,
                Tipo = Tipos.Entrada,
            };

            await _historicoRecursosRepositorio.Inserir(hr);
            TempData["NovoRegistro"] = $"Pagamento no valor de {pagamento.Aluguel.Valor} realizado";
            return RedirectToAction(nameof(Index));
        }
    }
}
