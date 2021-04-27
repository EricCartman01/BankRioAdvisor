using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComissionBankAdvisor.Data;
using ComissionBankAdvisor.Models;

namespace ComissionBankAdvisor.Services
{
    public class PanService
    {
        private readonly ComissionBankContext _context;

        public PanService(ComissionBankContext context)
        {
            _context = context;
        }

        public double GetTotal()
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            month = 12;
            year = 2018;

            double totalPan = _context.Pan.Where(x => x.Date.Month == month).Where(x => x.Date.Year == year).Sum(x => x.BankValue);

            return totalPan;
        }

        public List<Pan> GetComissions(int? id)
        {
            return _context.Pan.Where(x => x.AdvisorId == id.Value).ToList();
        }

        public Pan FindById(int id)
        {
            return  _context.Pan.FirstOrDefault(x => x.Id == id);
        }
    }
}
