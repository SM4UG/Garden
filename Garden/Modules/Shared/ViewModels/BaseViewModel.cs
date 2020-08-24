using System;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace Garden.Modules.Shared.ViewModels
{
    public class BaseViewModel<T> : ViewModelBase
    {
        public T Model { get; set; } = Activator.CreateInstance<T>();

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}
