using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace hammerchurrasco.Services
{
   public interface INavigationService
    {
        Task NavigateToParticipant();
        Task NavigateToDetailsParticipant(int ID);
        Task NavigateToListParticipant();
        void PopAsyncService();
    }
}
