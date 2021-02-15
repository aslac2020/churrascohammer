
using System;
using System.Collections.Generic;
using System.Text;
using hammerchurrasco.Models;

namespace hammerchurrasco.Services
{
    public interface IBarbecueRepository
    {
        void InsertEmployee(EmployeeModel employee);
        List<EmployeeModel> GetAllEmployee();
        EmployeeModel GetEmployeeById(int employeeId);
        void InsertGuest(GuestModel guest);
        List<ParticipantModel> GetParticipants();
        ParticipantModel GetParticipantById(int participantId);
        void DeleteAllParticipants();
        void DeleteParticipantId(int participantId);
        void InsertParticipant(ParticipantModel participant);
    }
}
