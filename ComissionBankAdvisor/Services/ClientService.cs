using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComissionBankAdvisor.Data;
using ComissionBankAdvisor.Models;

namespace ComissionBankAdvisor.Services
{
    public class ClientService
    {
        private readonly ComissionBankContext _context;

        public ClientService(ComissionBankContext comissionBankContext)
        {
            _context = comissionBankContext;
        }

        public List<Client> GetClients(int id)
        {
            string advisorInitials = _context.Advisor.Where(x => x.Id == id).Select(x => x.Initials).ToString();
            string teste = "ZSRM";
            return _context.Client.Where(x => x.AdvisorInitials == teste).ToList();
        }

        public Client FindById(int Id)
        {
            return _context.Client.FirstOrDefault(x => x.Id == Id);
        }
    }
}
