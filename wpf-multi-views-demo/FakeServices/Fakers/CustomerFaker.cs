using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_multi_views_demo.Models;

namespace wpf_multi_views_demo.FakeServices.Fakers
{
    public class CustomerFaker : Faker<Customer>
    {
        public CustomerFaker()
        {
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.FirstName, f => f.Person.FirstName);
            RuleFor(p => p.LastName, f => f.Person.LastName);
            RuleFor(p => p.Salary, f => f.Random.Decimal(1000, 5000));
        }
    }
}
