using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_multi_views_demo.FakeServices;
using wpf_multi_views_demo.FakeServices.Fakers;
using wpf_multi_views_demo.IServices;

namespace wpf_multi_views_demo.ViewModels
{
    public class ViewModelLocator
    {
        private IContainer container;

        public ViewModelLocator()
        {
            UseAutoFac();
        }

        private void UseAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ShellViewModel>();
            builder.RegisterType<CustomersViewModel>().SingleInstance();

            builder.RegisterType<CustomerFaker>();
            builder.RegisterType<FakeCustomersService>().As<ICustomersService>();

            container = builder.Build();
        }

        public ShellViewModel ShellViewModel => container.Resolve<ShellViewModel>();
        public CustomersViewModel CustomersViewModel => container.Resolve<CustomersViewModel>();
    }
}
