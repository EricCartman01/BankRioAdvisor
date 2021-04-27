using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComissionBankAdvisor.Services;
using ComissionBankAdvisor.Models;

namespace ComissionBankAdvisor.Controllers
{

    public class ExchangeController : Controller
    {
        private readonly ExchangeService _exchangeService;

        public ExchangeController(ExchangeService exchangeService)
        {
            _exchangeService = exchangeService;
        }

        public IActionResult Index(int? id)
        {
            int idAvisor = 440;

            if (id != null)
            {
                idAvisor = id.Value;
            }

            List<Exchange> exchanges = _exchangeService.GetComissions(idAvisor);
            return View(exchanges);
        }

    }
}
