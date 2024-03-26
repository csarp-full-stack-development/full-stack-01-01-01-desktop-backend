using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService.Services;
using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.Administration
{
    public partial class EducationLevelViewModel : BaseViewModel
    {
        private readonly IEducationLavelService? _educationLevelService;
        private readonly IStudentService? _studentService;
        
        [ObservableProperty]
        private ObservableCollection<EducationLevel> _educationLevels = new();

        [ObservableProperty]
        private EducationLevel _selectedEducationLevel;

        [ObservableProperty]
        private ObservableCollection<Student> _studentWithEducationLevel = new();

        [ObservableProperty]
        private Student _selectedStudentWithEducationLevel=new();
        
        [ObservableProperty]
        private ObservableCollection<Student> _studentNoEducationLevel = new();

        [ObservableProperty]
        private Student _selectedStudentWithNoEducationLevel=new();

        public string Title { get; set; } = "Tanulmányi szint kezelése";

        public EducationLevelViewModel()
        {
            _selectedEducationLevel = new EducationLevel();
        }

        public EducationLevelViewModel(IEducationLavelService? educationLevelService, IStudentService? studentService)
        {
            _educationLevelService = educationLevelService;
            _studentService = studentService;
            SelectedEducationLevel = new EducationLevel();
        }

        public async override Task InitializeAsync()
        {
            await UpdateView();
        }

        [RelayCommand]
        private async Task DoSave(EducationLevel educationLevels)
        {
            if (_educationLevelService is not null)
            {
                ControllerResponse result;
                if (educationLevels.HasId)
                    result = await _educationLevelService.UpdateAsync(educationLevels);
                else
                    result = await _educationLevelService.InsertAsync(educationLevels);

                if (!result.HasError)
                {
                    await UpdateView();
                }
            }
        }

        [RelayCommand]
        private async Task DoRemove(EducationLevel educationLevel)
        {
            if (_educationLevelService is not null)
            {
                ControllerResponse result = await _educationLevelService.DeleteAsync(educationLevel.Id);
                if (result.IsSuccess)
                {
                    await UpdateView();
                }
            }
        }

        [RelayCommand]
        private void DoNew()
        {
            SelectedEducationLevel = new EducationLevel();
        }
        
        private async Task UpdateView()
        {
            if (_educationLevelService is not null)
            {
                List<EducationLevel> educationLevels = await _educationLevelService.SelectAllAsync();
                EducationLevels = new ObservableCollection<EducationLevel>(educationLevels);
            }
        }
    }
}
