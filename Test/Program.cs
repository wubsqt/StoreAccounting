using StoreAccounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(StoreDBManager db = new StoreDBManager())
            {
                Products p = new Products()
                {
                    Name = "Ketab",
                    Price = 120000,
                    Description = "just pay it"
                };
                
                db.ProductRepository.Insert(p);
                db.Save();
                db.Dispose();
            }

            using(StoreDBManager db = new StoreDBManager())
            {
                Employees e = new Employees()
                {
                    FullName = "Mahdi",
                    BaseSalary = 12000000,
                };

                db.EmployeeRepository.Insert(e);
                db.Save();
                db.Dispose();
            }
        }
    }
}
