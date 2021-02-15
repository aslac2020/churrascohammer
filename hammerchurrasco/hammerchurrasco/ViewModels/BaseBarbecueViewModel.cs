using hammerchurrasco.Models;
using hammerchurrasco.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace hammerchurrasco.ViewModels
{
    public class BaseBarbecueViewModel : INotifyPropertyChanged
    {
        public EmployeeModel _employee;
        public GuestModel _guest;
        public IBarbecueRepository _barbecueRepository;

        public BaseBarbecueViewModel()
        {

        }

        public string Name
        {
            get => _employee.Name;
            set
            {
                _employee.Name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        public string Surname
        {
            get => _employee.Name;
            set
            {
                _employee.Surname = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        public string Gender
        {
            get => _employee.Gender;
            set
            {
                _employee.Gender = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        public string NameGuest
        {
            get => _guest.Name;
            set
            {
                _guest.Name = value;
                NotifyPropertyChanged(nameof(NameGuest));
            }
        }

        public string SurnameGuest
        {
            get => _guest.Surname;
            set
            {
                _guest.Surname = value;
                NotifyPropertyChanged(nameof(SurnameGuest));
            }
        }

        public string GenderGuest
        {
            get => _guest.Gender;
            set
            {
                _guest.Gender = value;
                NotifyPropertyChanged(nameof(GenderGuest));
            }
        }

        List<EmployeeModel> _participants;
        public List<EmployeeModel> Participants
        {
            get => _participants;
            set
            {
                _participants = value;
                NotifyPropertyChanged(nameof(Participants));
            }
        }


        #region INotifyPropertyChanged      
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }


}
