using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Web;

// tutorial used https://www.youtube.com/watch?v=PzP8mw7JUzI&t

namespace BuildGenerator.Core
{
    internal class ObservableObject : INotifyPropertyChanged
    {
        private string randName = "";
        public string RandName { get { return randName; } 
        set { 
                if (randName != value) 
                {
                    randName = value;
                    OnPropertyChanged("RandName");
                }
                
             }
        }
        private string randRace = "";

        public string RandRace { get { return randRace; }
            set {
                if (randRace != value)
                {
                    randRace = value;
                    OnPropertyChanged("RandRace");
                }
            }
        }
        private string randClass = "";

        public string RandClass
        {
            get { return randClass; }
            set
            {
                if (randClass != value)
                {
                    randClass = value;
                    OnPropertyChanged("RandClass");
                }
            }
        }
        private string randStone = "";
        public string RandStone
        {
            get { return randStone; }
            set
            {
                if (randStone != value)
                {
                    randStone = value;
                    OnPropertyChanged("RandStone");
                }
            }
        }
        private string randTransform = "";
        public string RandTransform
        {
            get { return randTransform; }
            set
            {
                if (randTransform != value)
                {
                    randTransform = value;
                    OnPropertyChanged("RandTransform");
                }
            }
        }
        private string randReligion = "";
        public string RandReligion
        {
            get { return randReligion; }
            set
            {
                if (randReligion != value)
                {
                    randReligion = value;
                    OnPropertyChanged("RandReligion");
                }
            }
        }
        private string randSkills = "";
        public string RandSkills
        {
            get { return randSkills; }
            set
            {
                if (randSkills != value)
                {
                    randSkills = value;
                    OnPropertyChanged("RandSkills");
                }
            }
        }
        private string randArea = "";
        public string RandArea
        {
            get { return randArea; }
            set
            {
                if (randArea != value)
                {
                    randArea = value;
                    OnPropertyChanged("RandArea");
                }
            }
        }






        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));  
        }
    }
}
