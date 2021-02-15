using System;
using System.Collections.Generic;
using System.Text;

namespace hammerchurrasco.Interfaces
{
   public interface IToastMessage
    {
        void longAlert(string message);
        void shortAlert(string message);
    }
}
