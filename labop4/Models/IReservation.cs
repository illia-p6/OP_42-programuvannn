using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labop4.Models
{
    interface IReservation
    {
        void Reserve(DateTime startDate, DateTime endDate);
        void CancelReservation();
        bool IsReserved { get; }
    }
}
