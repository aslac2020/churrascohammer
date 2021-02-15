using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace hammerchurrasco.Models
{

    [Table("Participants")]
    public class ParticipantModel
    {
        public ParticipantModel()
        {

        }
        

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int IdEmployee { get; set; }
        public int IdGuest{ get; set; }
        public decimal ValueParticipant { get; set; } = 0;
        public bool ParticipantDrink { get; set; } = false;
        public decimal ValueGuest { get; set; } = 0;
        public bool GuestDrink { get; set; } = false;
        public bool GuestYes { get; set; } = false;
    }
}
