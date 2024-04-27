using StoreAccounting.DataLayer.Repositories;
using StoreAccounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAccounting.DataLayer.Context
{
    public class StoreDBManager : IDisposable
    {
        StoreAccounting_DBEntities db = new StoreAccounting_DBEntities();

        private StoreRepository<Employees> _employeeRepository;
        public StoreRepository<Employees> EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new StoreRepository<Employees>(db);

                return _employeeRepository;
            }
        }

        private StoreRepository<Products> _productRepository;
        public StoreRepository<Products> ProductRepository
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new StoreRepository<Products>(db);

                return _productRepository;
            }
        }

        private StoreRepository<Customers> _customerRepository;
        public StoreRepository<Customers> CustomerRepository
        {
            get
            {
                if(_customerRepository == null)
                {
                    _customerRepository = new StoreRepository<Customers>(db);
                }
                return _customerRepository;
            }
        }

        private ICustomerRepository _customerRepo;
        public ICustomerRepository CustomerRepo
        {
            get
            {
                if(_customerRepo == null)
                {
                    _customerRepo = new CustomerRepository(db);
                }
                return _customerRepo;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
