using System;
using System.Threading.Tasks;
using Garden.Modules.Shared.Models;
using Garden.Modules.Shared.ViewModels;

namespace Garden.Modules.Shared.Services.Interfaces
{
    public interface INavigationService
    {
        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>() where TViewModel : BaseViewModel<BaseModel>;

        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : BaseViewModel<BaseModel>;

        Task NavigateToAsync(Type viewModelType);
    }
}
