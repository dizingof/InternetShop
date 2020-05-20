using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using Moq;
using Ninject;
using ToyShop.Domain.Abstract;
using ToyShop.Domain.Entities;


namespace GameStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            Mock<IToyRepository> mock = new Mock<IToyRepository>();
            mock.Setup(m => m.Toys).Returns(new List<Toy>
                    {
                         new Toy { Name = "SimCity", Price = 1499 },
                         new Toy { Name = "TITANFALL", Price=2299 },
                         new Toy { Name = "Battlefield 4", Price=899.4M }
                    });
            kernel.Bind<IToyRepository>().ToConstant(mock.Object);
        }
    }
}