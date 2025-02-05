using Kreta.Shared.Models;
using Kreta.ViewModelProject.Base;
using System.Collections.ObjectModel;

namespace Kreta.ViewModelProject
{
    public interface IStudentViewModelBase: IBaseViewModel
    {
        public ObservableCollection<Student> Students { get; set; }
    }
}
