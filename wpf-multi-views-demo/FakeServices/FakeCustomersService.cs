using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_multi_views_demo.FakeServices.Fakers;
using wpf_multi_views_demo.IServices;
using wpf_multi_views_demo.Models;

namespace wpf_multi_views_demo.FakeServices
{
    public class FakeCustomersService : ICustomersService
    {
        private readonly CustomerFaker customerFaker;

        private ICollection<Customer> customers;

        public FakeCustomersService(CustomerFaker customerFaker)
        {
            this.customerFaker = customerFaker;

            customers = customerFaker.Generate(50);
        }

        public IEnumerable<Customer> Get()
        {
            return customers;
        }
    }
}
