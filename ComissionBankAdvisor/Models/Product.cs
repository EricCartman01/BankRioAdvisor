using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComissionBankAdvisor.Models.Enums;

namespace ComissionBankAdvisor.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Market Market { get; set; }
        public string Details { get; set; }

        public Product()
        {

        }

       
    }
}
