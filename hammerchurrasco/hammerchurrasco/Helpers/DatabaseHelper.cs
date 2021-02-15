using hammerchurrasco.Models;
using PCLExt.FileStorage;
using PCLExt.FileStorage.Folders;
using SQLite;
using System.Collections.Generic;
using System.Linq;

namespace hammerchurrasco.Helpers
{
    public class DatabaseHelper
    {
        static SQLiteConnection _sqliteConnection;
        public const string DbFileName = "BarbecueDb.db";

        public DatabaseHelper()
        {
            var past = new LocalRootFolder();
            var file = past.CreateFile(DbFileName, CreationCollisionOption.OpenIfExists);
            _sqliteConnection = new SQLiteConnection(file.Path);
            _sqliteConnection.CreateTable<EmployeeModel>();
            _sqliteConnection.CreateTable<GuestModel>();
            _sqliteConnection.CreateTable<ParticipantModel>();

        }
        public void InsertParticipant(ParticipantModel participant)
        {
            _sqliteConnection.Insert(participant);
        }

        public void InsertGuest(GuestModel guest)
        {
            _sqliteConnection.Insert(guest);
        }

        public List<ParticipantModel> GetParticipants()
        {
            return (from data in _sqliteConnection.Table<ParticipantModel>() select data).ToList();
        }
        public ParticipantModel GetParticipantsById(int participantId)
        {
            return _sqliteConnection.Table<ParticipantModel>().FirstOrDefault(f => f.Id == participantId);
        }

        public List<EmployeeModel> GetAllEmployee()
        {
            return (from data in _sqliteConnection.Table<EmployeeModel>() select data).ToList();
        }

        public EmployeeModel GetEmployeeById(int employeeId)
        {
            return _sqliteConnection.Table<EmployeeModel>().FirstOrDefault(f => f.Id == employeeId);
        }

        public void InsertEmployee(EmployeeModel employee)
        {
            _sqliteConnection.Insert(employee);
        }
        public void DeleteAllParticipants()
        {
            _sqliteConnection.DeleteAll<ParticipantModel>();
        }

        public void DeleteParticipantId(int id)
        {
            _sqliteConnection.Delete<ParticipantModel>(id);
        }

    }
}
