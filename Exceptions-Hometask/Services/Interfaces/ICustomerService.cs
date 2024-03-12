using Exceptions_Hometask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Hometask.Services.Interfaces
{
    internal interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int? id);
        List<Customer> GetByName(string name);
        int GetCount();
    }
}
