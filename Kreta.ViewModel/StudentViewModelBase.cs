using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.HttpService;
using Kreta.Shared.Models;
using Kreta.ViewModelProject;
using Kreta.ViewModelProject.Base;
using System.Collections.ObjectModel;

namespace Kreta.ViewModelProject
{
    public partial class StudentViewModelBase : BaseViewModel, IStudentViewModelBase
    {
        private readonly IStudentHttpService _httpService;

        [ObservableProperty]
        private Student _selectedStudent = new Student();

        [ObservableProperty]
        private List<string> _educationLevels = new List<string> { "érettségi", "szakmai érettségi", "szakmai vizsga" };

        [ObservableProperty]
        private ObservableCollection<Student> _students = new ObservableCollection<Student>();

        public StudentViewModelBase()
        {
            _selectedStudent = new Student();
            SelectedStudent.BirthDay = DateTime.Now.AddYears(-14);
            _httpService = new StudentHttpService();
        }

        public StudentViewModelBase(IStudentHttpService? httpService)
        {
            _httpService = httpService ?? throw new ArgumentNullException(nameof(httpService));
            _selectedStudent = new Student();
            SelectedStudent.BirthDay = DateTime.Now.AddYears(-14);
        }

        public override async Task LoadDataAsync()
        {
            await UpdateViewAsync();
            await base.LoadDataAsync();
        }

        private async Task UpdateViewAsync()
        {
            List<Student> students = await _httpService.GetAllAsync();
            Students = new ObservableCollection<Student>(students);
        }
    }
}
