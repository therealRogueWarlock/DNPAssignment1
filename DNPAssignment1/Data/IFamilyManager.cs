using System.Collections.Generic;
using Models;

namespace Blazor_Authentication.Data
{
    public interface IFamilyManager
    {
        void AddFamily(Family family);
        void RemoveFamily(Family family);
        IList<Family> GetFamilies();
        void Update(Family family);
        Family Get(string streetName, int houseNumber);


    }
}