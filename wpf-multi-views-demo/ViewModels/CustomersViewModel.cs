using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_multi_views_demo.IServices;
using wpf_multi_views_demo.Models;

namespace wpf_multi_views_demo.ViewModels
{
    public class CustomersViewModel : ViewModelBase
    {
        public IEnumerable<Customer> Customers { get; set; }

        public Customer SelectedCustomer { get; set; }

        private readonly ICustomersService customersService;

        public CustomersViewModel(ICustomersService customersService)
        {
            this.customersService = customersService;

            Load();
        }

        private void Load()
        {
            Customers = customersService.Get();
        }

    }
}
