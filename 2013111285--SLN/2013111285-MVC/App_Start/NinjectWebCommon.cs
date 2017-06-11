[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(_2013111285_MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(_2013111285_MVC.App_Start.NinjectWebCommon), "Stop")]

namespace _2013111285_MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using _2013111285_PER.Repositories;
    using _2013111285_ENT.IRepositories;
    using _2013111285_PER;
    using System.Data.Entity;

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
            kernel.Bind<IUnityOfWork>().To<UnityOfWork>();
            kernel.Bind<DbContext>().To<EnsambladoraDbContext>();



            kernel.Bind<IAsientoRepository>().To<AsientoRepository>();      
            kernel.Bind<ICarroRepository>().To<CarroRepository>();
            kernel.Bind<ICinturonRepository>().To<CinturonRepository>();
            kernel.Bind<IEnsambladoraRepository>().To<EnsambladoraRepository>();
            kernel.Bind<ILlantaRepository>().To<LlantaRepository>();
            kernel.Bind<IParabrisasRepository>().To<ParabrisasRepository>();
            kernel.Bind<IPropietarioRepository>().To<PropietarioRepository>();
            kernel.Bind<IVolanteRepository>().To<VolanteRepository>();




        }        
    }
}