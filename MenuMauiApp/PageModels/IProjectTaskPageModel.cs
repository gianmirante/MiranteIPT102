using CommunityToolkit.Mvvm.Input;
using MenuMauiApp.Models;

namespace MenuMauiApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}