using HotelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsLibrary
{
    public interface ISubject
    {
        void RegisterObserver(IObserver objObserver);
        void RemoveObserver(IObserver observ);
        void NotifyObservers(ReservationType reservation);
    }
}