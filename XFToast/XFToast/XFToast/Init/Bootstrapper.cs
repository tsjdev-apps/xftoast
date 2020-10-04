using CommonServiceLocator;
using Unity;
using Unity.Lifetime;
using Unity.ServiceLocation;
using XFToast.ViewModels;

namespace XFToast.Init
{
    public static class Bootstrapper
    {
        private static readonly UnityContainer _container = new UnityContainer();

        public static void RegisterDependencies()
        {
            // register platform independent services
            //_container.RegisterType<IService, Service>(new ContainerControlledLifetimeManager());

            // register viewmodels
            _container.RegisterType<MainPageViewModel>(new ContainerControlledLifetimeManager());

            var locator = new UnityServiceLocator(_container);
            ServiceLocator.SetLocatorProvider(() => locator);
        }

        public static void RegisterPlatformDependency<TInterface, TImplementation>(ITypeLifetimeManager lifetimeManager)
        {
            _container.RegisterType(typeof(TInterface), typeof(TImplementation), lifetimeManager);
        }
    }
}
