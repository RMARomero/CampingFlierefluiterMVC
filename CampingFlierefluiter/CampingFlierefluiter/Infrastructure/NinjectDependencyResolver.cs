using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moq;
using CampingFlierefluiter.Abstract;
using CampingFlierefluiter.Models;
using CampingFlierefluiter.Context;

namespace CampingFlierefluiter.Infrastructure
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
            kernel.Bind<ICampingSiteRepository>().To<CampingSiteRepository>();
            kernel.Bind<IFacilityRepository>().To<FacilityRepository>();
            kernel.Bind<IGuestRepository>().To<GuestRepository>();
            kernel.Bind<IInvoiceRepository>().To<InvoiceRepository>();
            kernel.Bind<IPdfRepository>().To<PdfRepository>();
            kernel.Bind<IReservationRepository>().To<ReservationRepository>();
            kernel.Bind<ISeasonRepository>().To<SeasonRepository>();
            kernel.Bind<IUserRepository>().To<UserRepository>();
        }
    }
}