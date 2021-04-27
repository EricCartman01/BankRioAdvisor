using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComissionBankAdvisor.Services;
using ComissionBankAdvisor.Models;

namespace ComissionBankAdvisor.Controllers
{
    public class PanController : Controller
    {
        private readonly PanService _panService;

        public PanController(PanService panService)
        {
            _panService = panService;
        }
        public IActionResult Index(int? id)
        {
            int idAvisor = 308;

            if (id != null)
            {
                idAvisor = id.Value;
            }

            List<Pan> pans = _panService.GetComissions(idAvisor);
            return View(pans);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _panService.FindById(id.Value);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
    }
}
