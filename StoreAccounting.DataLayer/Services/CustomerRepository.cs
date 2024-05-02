using StoreAccounting.DataLayer.Context;
using StoreAccounting.DataLayer.Repositories;
using StoreAccounting.ViewModels;
using StoreAccounting.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAccounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        StoreAccounting_DBEntities db;
        public CustomerRepository(StoreAccounting_DBEntities context)
        {
            db = context;
        }

        public List<CustomerViewModel> GetAllCustomer()
        {
            return db.Customers.Select(c => new CustomerViewModel()
            {
                CustomerId = c.CustomerId,
                FullName = c.FullName,
                Mobile = c.Mobile,
                Address = c.Address
            }).ToList();
        }

        public List<CustomerShopingListViewModel> GetShopingList(int Id)
        {
            return db.Customers.Where(c => c.CustomerId == Id)
                .Select(c => new CustomerShopingListViewModel()
                {
                    ShopingList = c.ShopingList
                }).ToList();
        }
    }
}
