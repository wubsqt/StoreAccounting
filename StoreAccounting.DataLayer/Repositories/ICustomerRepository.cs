using StoreAccounting.DataLayer.Context;
using StoreAccounting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAccounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<CustomerViewModel> GetAllCustomer();
    }
}
