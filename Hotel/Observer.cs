using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsLibrary
{
    public interface IObserver
    {
        string GetHotelName();
        string GetHotelId();
        void Update(ReservationType reservation);
    }
}
