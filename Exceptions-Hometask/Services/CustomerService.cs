using Exceptions_Hometask.Models;
using Exceptions_Hometask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Hometask.Services
{
    internal class CustomerService : ICustomerService
    {
        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }
    }
}
