using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComissionBankAdvisor.Data;
using ComissionBankAdvisor.Models;

namespace ComissionBankAdvisor.Services
{
    public class XpService
    {
        private readonly ComissionBankContext _context;

        public XpService(ComissionBankContext comissionBankContext)
        {
            _context = comissionBankContext;
        }

        public List<Xp> GetComissions(int? id)
        {
            return _context.Xp.Where(x => x.AdvisorId == id.Value).ToList();
        }

        public Xp FindById(int id)
        {
            return _context.Xp.FirstOrDefault(x => x.Id == id);
        }
    }
}
