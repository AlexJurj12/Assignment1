using System.Collections.Generic;
using Models;

namespace Assignment1.Data
{
    public interface IAdultService
    {
        void AddAdult(Adult adultToAdd);
        IList<Adult> ReadAllAdults();
        void UpdateAdult(Adult adultToUpdate);
        void DeleteAdult(Adult adultToDelete);
    }
}