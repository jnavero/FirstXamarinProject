using MvvmCross.Core.ViewModels;

namespace FirstProject.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {

        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                SetProperty(ref name, value);
                RaisePropertyChanged(() => FullName);
            }
        }

        string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                SetProperty(ref lastName, value);
                RaisePropertyChanged(() => FullName);
            }
        }
        
        public string FullName
        {
            get
            {
                return Name + " " + LastName;
            }
        }

    }
}
