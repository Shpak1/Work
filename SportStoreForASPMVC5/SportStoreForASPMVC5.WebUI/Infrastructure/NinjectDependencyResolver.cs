using Moq;
using Ninject;
using SportStoreForASPMVC.Domain.Abstract;
using SportStoreForASPMVC.Domain.Concrete;
using SportStoreForASPMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStoreForASPMVC5.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        public IKernel kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            this.kernel = kernel;
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
        public void AddBindings()
        {
            kernel.Bind<IProductRepository>().To<EFProductRepository>();
            //Mock<IProductRepository> mock = new Mock<IProductRepository>();
            //mock.Setup(m => m.Products).Returns(new List<Product>
            //    {
            //    new Product {Name = "qwerty", Price=100 },
            //    new Product {Name = "rrtye", Price = 2010 },
            //new Product { Name = "yrtew", Price = 783 },
            //new Product {  Price = 26 , Name = "hgqadkghgksac"}
            //});

            //kernel.Bind<IProductRepository>().ToConstant(mock.Object);
        }
    }
}