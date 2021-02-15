using Acr.UserDialogs;
using hammerchurrasco.Models;
using hammerchurrasco.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hammerchurrasco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Participants : ContentPage
    {
        private ParticipantModel participantModel = new ParticipantModel();
        private BarbecueRepository _barbecueRepository = new BarbecueRepository();
        private readonly int _idEmployee;
        public Participants(int id)
        {
            InitializeComponent();
            _idEmployee = id;

            GetAllParticipant(id);

        }

        private void GetAllParticipant(int id)
        {
            var participants = _barbecueRepository.GetParticipants();
            var employee = _barbecueRepository.GetAllEmployee();

            foreach (var item in participants)
            {
                if (participants.Count > 0)
                {
                    foreach(var itens in employee)
                    {
                        var findEmployee = participants.Find(x => x.IdEmployee == id);

                        if (findEmployee == null) continue;

                        else
                            lstParticipants.ItemsSource = participants;
                    }
                  
                }
            }


        }

        //private void CreateParticpant()
        //{


        //    GetAllParticipantes();
        //}

        //private async void GetAllParticipantes()
        //{

        //    try
        //    {
        //        using (UserDialogs.Instance.Loading("Carregando..."))
        //        {
        //            try
        //            {
        //                await Task.Run(() => GetListaParticipantes()).ContinueWith((t) =>
        //                {
        //                    if (t.IsFaulted)
        //                    {
        //                        throw t.Exception;
        //                    }
        //                });
        //            }
        //            catch (AggregateException ex)
        //            {
        //                throw ex;
        //            }
        //        }
        //    }
        //    catch (AggregateException ex)
        //    {
        //        throw ex;
        //    }
        //}

        //private void GetListaParticipantes()
        //{
        //    List<ParticipantModel> listaView = new List<ParticipantModel>();
        //    List<Churrasco.PCL.ModelsDatabase.Participant> listaParticipantes = _databaseAcess.GetAllParticipant();

        //    foreach (var item in listaParticipantes)
        //    {
        //        var convidado = new GuestModel();
        //        var participante = new ParticipantModel();

        //        var funcionarioDb = _databaseAcess.GetEmployee(item.IdEmployee);

        //        var funcionario = new EmployeeModel
        //        {
        //            Id = funcionarioDb.Id,
        //            Name = funcionarioDb.Name,
        //            Surname = funcionarioDb.Surname,
        //            Gender = funcionarioDb.Gender
        //        };

        //        if (item.HasInvited)
        //        {
        //            var convidadoDb = _databaseAcess.GetGuest(item.IdGuest);

        //            convidado = new GuestModel
        //            {
        //                Id = convidadoDb.Id,
        //                Name = convidadoDb.Name,
        //                Surname = convidadoDb.Surname,
        //                Gender = convidadoDb.Gender
        //            };

        //            participante = new ParticipantModel
        //            {
        //                Id = item.Id,
        //                IdBarbecue = item.IdBarbecue,
        //                Employee = funcionario,
        //                Guest = convidado,
        //                ValueParticipant = item.ValueParticipant,
        //                ValueGuest = item.ValueGuest,
        //                ParticipantDrink = item.ParticipantDrink,
        //                GuestDrink = item.GuestDrink,
        //                GuestYes = item.HasInvited
        //            };
        //        }
        //        else
        //        {
        //            participante = new ParticipantModel
        //            {
        //                Id = item.Id,
        //                IdBarbecue = item.IdBarbecue,
        //                Employee = funcionario,
        //                ValueParticipant = item.ValueParticipant,
        //                ValueGuest = item.ValueGuest,
        //                ParticipantDrink = item.ParticipantDrink,
        //                GuestDrink = item.GuestDrink,
        //                GuestYes = item.HasInvited
        //            };

        //            listaView.Add(participante);
        //            lstParticipants.ItemsSource = listaView;


        //        }

        //    }
        //}

        private async void btnCadastro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateParticipant());
        }
    }
}
