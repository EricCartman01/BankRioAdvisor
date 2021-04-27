using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComissionBankAdvisor.Data;
using ComissionBankAdvisor.Models;

namespace ComissionBankAdvisor.Services
{
    public class ExchangeService
    {
        private readonly ComissionBankContext _context;

        public ExchangeService(ComissionBankContext comissionBankContext)
        {
            _context = comissionBankContext;
        }
        public List<Exchange> GetComissions(int? id)
        {
            return _context.Exchange.Where(x => x.AdvisorId == id.Value).ToList();
        }
    }
}
