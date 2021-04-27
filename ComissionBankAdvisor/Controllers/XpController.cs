using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComissionBankAdvisor.Services;
using ComissionBankAdvisor.Models;

namespace ComissionBankAdvisor.Controllers
{
    public class XpController : Controller
    {
        private readonly XpService _xpService;
        public XpController(XpService xpService)
        {
            _xpService = xpService;
        }
        public IActionResult Index(int? id)
        {
            int idAvisor = 440;

            if (id != null)
            {
                idAvisor = id.Value;
            }

            List<Xp> xps = _xpService.GetComissions(idAvisor);
            return View(xps);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _xpService.FindById(id.Value);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
    }
}
