using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAccounting.ViewModels
{
    public class CustomerViewModel
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }
}
