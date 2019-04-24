using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_multi_views_demo.Models;

namespace wpf_multi_views_demo.IServices
{
    public interface ICustomersService
    {
        IEnumerable<Customer> Get();
    }
}
