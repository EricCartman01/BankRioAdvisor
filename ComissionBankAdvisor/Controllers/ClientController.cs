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
    public class ClientController : Controller
    {
        private readonly ClientService _clientService; 

        public ClientController(ClientService clientService)
        {
            _clientService = clientService;
        }
        public IActionResult Index(int? id)
        {
            int idAvisor = 440;

            if(id != null)
            {
                idAvisor = id.Value;
            }
            
            List<Client> clients = _clientService.GetClients(idAvisor);
            return View(clients);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _clientService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
    }
}