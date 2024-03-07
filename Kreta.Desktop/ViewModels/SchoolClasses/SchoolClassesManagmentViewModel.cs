using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;
using Kreta.Shared.Models;
using System.Collections.ObjectModel;

namespace Kreta.Desktop.ViewModels.SchoolClasses
{
    public partial class SchoolClassesManagmentViewModel : BaseViewModel
    {
        public string Title { get; set; } = "Osztályok kezelése";
        
        [ObservableProperty]
        private SchoolClass _selectedSchoolClass = new SchoolClass();

        [ObservableProperty]
        private ObservableCollection<SchoolClass> _schoolClasses = new ObservableCollection<SchoolClass>();
    }
}
