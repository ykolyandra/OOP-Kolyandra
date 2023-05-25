using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    internal interface IWorker
    {
        void ChangeStatus(string code, Status newStatus);
        void ChangePayStatus(string code, PaymentStatus newStatus);
        void ChangeDetails(string code, string new_location);
        void SetLastDay(string code, DateTime arrivalDate);

    }
}
