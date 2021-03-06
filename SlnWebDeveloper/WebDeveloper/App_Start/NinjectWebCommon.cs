[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WebDeveloper.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(WebDeveloper.App_Start.NinjectWebCommon), "Stop")]

namespace WebDeveloper.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using WebDeveloper.Application.AppService;
    using WebDeveloper.Application.Interface;
    using WebDeveloper.Domain.Interfaces.Repositories;
    using WebDeveloper.Domain.Interfaces.Services;
    using WebDeveloper.Domain.Services;
    using WebDeveloper.Infra.Data.Repositories;
                                        
    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IDesenvolvedorAppService>().To<DesenvolvedorAppService>();
            kernel.Bind<ITecnologiaAppService>().To<TecnologiaAppService>();
            kernel.Bind<IExperienciaAppService>().To<ExperienciaAppService>();
            kernel.Bind<ISenioridadeAppService>().To<SenioridadeAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IDesenvolvedorService>().To<DesenvolvedorService>();
            kernel.Bind<ITecnologiaService>().To<TecnologiaService>();
            kernel.Bind<IExperienciaService>().To<ExperienciaService>();
            kernel.Bind<ISenioridadeService>().To<SenioridadeService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IDesenvolvedorRepository>().To<DesenvolvedorRepository>();
            kernel.Bind<ITecnologiaRepository>().To<TecnologiaRepository>();
            kernel.Bind<IExperienciaRepository>().To<ExperienciaRepository>();
            kernel.Bind<ISenioridadeRepository>().To<SenioridadeRepository>();
        }        
    }
}
