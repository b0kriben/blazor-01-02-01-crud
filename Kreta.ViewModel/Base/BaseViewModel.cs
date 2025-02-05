using CommunityToolkit.Mvvm.ComponentModel;

namespace Kreta.ViewModelProject.Base
{
    public  abstract class BaseViewModel : ObservableObject
    {
        public virtual Task LoadDataAsync()
        {
            return Task.CompletedTask;
        }
    }
}
