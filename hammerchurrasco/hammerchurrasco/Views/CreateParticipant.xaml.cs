
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using hammerchurrasco.Interfaces;
using hammerchurrasco.Models;
using hammerchurrasco.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hammerchurrasco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateParticipant : ContentPage
    {

        private BarbecueRepository BarbecueRepository = new BarbecueRepository();
        private EmployeeModel _employeeModel = new EmployeeModel();
        private ParticipantModel _participantModel = new ParticipantModel();
        private GuestModel _guestModel = new GuestModel();
        private IToastMessage _toast = DependencyService.Get<IToastMessage>();

        public CreateParticipant()
        {
            InitializeComponent();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            if (_employeeModel != null)
            {
                var existParticipant = BarbecueRepository.GetParticipants();
                var existEmployee = BarbecueRepository.GetAllEmployee();
                var listParticipant = new List<ParticipantModel>();
                var employeeList = new List<EmployeeModel>();

                if (existParticipant.Count < 1 && existEmployee.Count < 1)
                {
                    var funcionario = new EmployeeModel { Name = entryName.Text, Surname = entrSurname.Text, Gender = pickerGender.SelectedItem.ToString() };
                    BarbecueRepository.InsertEmployee(funcionario);
                    employeeList.Add(funcionario);
                    var participantes = new ParticipantModel { IdEmployee = funcionario.Id };
                    BarbecueRepository.InsertParticipant(participantes);
                    listParticipant.Add(participantes);

                    _employeeModel.Id = funcionario.Id;
                }

                else
                {
                    var funcionario = new EmployeeModel { Name = entryName.Text, Surname = entrSurname.Text, Gender = pickerGender.SelectedItem.ToString() };
                    BarbecueRepository.InsertEmployee(funcionario);
                    employeeList.Add(funcionario);
                    var participantes = new ParticipantModel { IdEmployee = funcionario.Id };
                    BarbecueRepository.InsertParticipant(participantes);
                    listParticipant.Add(participantes);
                    _employeeModel.Id = funcionario.Id;
                }
                
            }

            if (swiGuestConvide.IsToggled == true)
            {
                var guestConvided = new GuestModel
                {
                    Name = entryNameGuest.Text,
                    Surname = entrSurname.Text,
                    Gender = pickerGenderGuest.SelectedItem.ToString()
                };

                BarbecueRepository.InsertGuest(guestConvided);
            }

            _toast.shortAlert("Participante salvo com sucesso!");
            await Navigation.PushAsync(new Home(_employeeModel.Id));
        }



        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(entryName.Text))
            {
                _toast.shortAlert("Favor Preencher o campo Nome");
                return false;
            }

            if (string.IsNullOrWhiteSpace(entrSurname.Text))
            {
                _toast.shortAlert("Favor Preencher o campo Sobrenome");
                return false;
            }

            if (pickerGender.SelectedItem == null)
            {
                _toast.shortAlert("Favor selecionar o sexo");
                return false;
            }

            else
             return true;
        }
    }
}
