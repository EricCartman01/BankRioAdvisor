using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComissionBankAdvisor.Data;
using ComissionBankAdvisor.Models;

namespace ComissionBankAdvisor.Services
{
    public class DashboardService
    {
        private readonly ComissionBankContext _context;

        public DashboardService(ComissionBankContext comissionBankContext)
        {
            _context = comissionBankContext;
        }

        public double GetTotal(string product, int? id)
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            month = 12;
            year = 2018;

            switch(product)
            {
                case "Pan":
                    return _context.Pan.Where(x => x.AdvisorId == id.Value).Where(x => x.Date.Month == month).Where(x => x.Date.Year == year).Sum(x => x.AdvisorValue);
                case "Xp":
                    return _context.Xp.Where(x => x.AdvisorId == id.Value).Where(x => x.Date.Month == month).Where(x => x.Date.Year == year).Sum(x => x.AdvisorValue);
                case "Protect":
                    return _context.Protect.Where(x => x.AdvisorId == id.Value).Where(x => x.Date.Month == month).Where(x => x.Date.Year == year).Sum(x => x.AdvisorValue);
                case "Exchange":
                    return _context.Exchange.Where(x => x.AdvisorId == id.Value).Where(x => x.Date.Month == month).Where(x => x.Date.Year == year).Sum(x => x.AdvisorValue);
                default:
                    return -100;

            }
        }

    }
}
