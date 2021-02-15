using hammerchurrasco.Models;
using hammerchurrasco.Helpers;
using System.Collections.Generic;

namespace hammerchurrasco.Services
{
    public class BarbecueRepository : IBarbecueRepository
    {
        DatabaseHelper _databaseHelper;
        public BarbecueRepository()
        {
            _databaseHelper = new DatabaseHelper();
        }

        public void InsertEmployee(EmployeeModel employee)
        {
            _databaseHelper.InsertEmployee(employee);
        }

        public List<EmployeeModel> GetAllEmployee()
        {
            return _databaseHelper.GetAllEmployee();
        }

        public EmployeeModel GetEmployeeById(int employeeId)
        {
            return _databaseHelper.GetEmployeeById(employeeId);
        }

        public void InsertGuest(GuestModel guest)
        {
            _databaseHelper.InsertGuest(guest);
        }

        public List<ParticipantModel> GetParticipants()
        {
            return _databaseHelper.GetParticipants();
        }

        public ParticipantModel GetParticipantById(int participantId)
        {
            return _databaseHelper.GetParticipantsById(participantId);
        }

        public void InsertParticipant(ParticipantModel participant)
        {
            _databaseHelper.InsertParticipant(participant);
        }

        public void DeleteAllParticipants()
        {
            _databaseHelper.DeleteAllParticipants();

        }

        public void DeleteParticipantId(int id)
        {
            _databaseHelper.DeleteParticipantId(id);
        }
    }
}
