using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComissionBankAdvisor.Services;
using ComissionBankAdvisor.Models;
using Microsoft.AspNetCore.Http;

namespace ComissionBankAdvisor.Controllers
{
    public class DashboardController : Controller
    {
        private readonly DashboardService _dashboardService;

        public DashboardController(DashboardService dashboardService )
        {
            _dashboardService = dashboardService;
        }

        public IActionResult Index(int? id)
        {
            int idAdvisor = 10;

            if(id != null)
            {
                idAdvisor = id.Value;
            }

            double totalPan = _dashboardService.GetTotal("Pan", idAdvisor);
            double totalXp = _dashboardService.GetTotal("Xp", idAdvisor);
            double totalProtect = _dashboardService.GetTotal("Protect", idAdvisor);
            double totalExchange = _dashboardService.GetTotal("Exchange", idAdvisor);

            ViewBag.totalPan = totalPan;
            ViewBag.totalXp = totalXp;
            ViewBag.totalProtect = totalProtect;
            ViewBag.totalExchange = totalExchange;

            return View();
        }
    }
}
