using System;
using Garden.Modules.Home.ViewModels;
using Garden.Modules.Shared.Services.Implementions;
using Garden.Modules.Shared.Services.Interfaces;
using Unity;

namespace Garden.Modules.Shared.ViewModels
{
    public class Locator
    {
        private readonly IUnityContainer _container;

        private static readonly Locator _instance = new Locator();

        public static Locator Instance
        {
            get { return _instance; }
        }

        public Locator()
        {
            _container = new UnityContainer();

            //Registro de Interfaces
            _container.RegisterType<INavigationService, NavigationService>();

            //registro de ViewModel
            _container.RegisterType<HomeViewModel>();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }
    }
}