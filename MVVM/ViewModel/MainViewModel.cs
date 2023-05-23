using System;
using System.Windows;
using BuildGenerator.Core;
using BuildGenerator.MVVM.View;

namespace BuildGenerator.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand RandomiseViewCommand { get; set; }
        public RelayCommand BackstoryViewCommand { get; set; }
        public RelayCommand LinksViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public RandomiseViewModel RandomiseVM { get; set; }
        public BackstoryViewModel BackstoryVM { get; set; }
        public LinksViewModel LinksVM { get; set; }      

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public void ResetRandomiser() 
        {
            var rv = new RandomiseView();

            rv.OutputName.Text = string.Empty;
            rv.RaceOutput.Text = string.Empty;
            rv.ClassOutput.Text = string.Empty;
            rv.StoneOutput.Text = string.Empty;
            rv.TransformOutput.Text = string.Empty;
            rv.ReligionOutput.Text = string.Empty;
            rv.SkillsMajorOutput.Text = string.Empty;
            rv.AreaOutput.Text = string.Empty;

            Properties.Settings.Default.RandomNameOut = rv.OutputName.Text;
            Properties.Settings.Default.RandomRaceOut = rv.RaceOutput.Text;
            Properties.Settings.Default.RandomClassOut = rv.ClassOutput.Text;
            Properties.Settings.Default.RandomStoneOut = rv.StoneOutput.Text;
            Properties.Settings.Default.RandomTransformOut = rv.TransformOutput.Text;
            Properties.Settings.Default.RandomReligionOut = rv.ReligionOutput.Text;
            Properties.Settings.Default.RandomSkillOut = rv.SkillsMajorOutput.Text;
            Properties.Settings.Default.RandomAreaOut = rv.AreaOutput.Text;

        }
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            RandomiseVM = new RandomiseViewModel();
            BackstoryVM = new BackstoryViewModel();
            LinksVM = new LinksViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });
            RandomiseViewCommand = new RelayCommand(o =>
            {
                CurrentView= RandomiseVM;
            });
            BackstoryViewCommand = new RelayCommand(o =>
            {
                CurrentView = BackstoryVM;
            });
            LinksViewCommand = new RelayCommand(o =>
            {
                CurrentView = LinksVM;
            });           
        }        
    }
}
