using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using hammerchurrasco.Models;

namespace hammerchurrasco.Models
{
    [Table("Barbecue")]
    public class BarbecueModel
    {
        public BarbecueModel()
        {
            BarbecueDetails = new BarbecueDetails();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateEvent { get; set; }
        public BarbecueDetails BarbecueDetails { get; set; }

    }
    public class BarbecueDetails
    {

        public BarbecueDetails()
        {
            ListParticipant = new List<ParticipantModel>();
        }

        public decimal TotalCollected { get; set; }
        public decimal TotalSpentFood { get; set; }
        public decimal TotalSpendDrink { get; set; }
        public List<ParticipantModel> ListParticipant { get; set; }
        public List<SpentModel> ListExpendituresFood { get; set; }
        public List<SpentModel> ListDrinksDrink { get; set; }

    }
}

