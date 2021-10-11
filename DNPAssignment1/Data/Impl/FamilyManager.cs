using System.Collections.Generic;
using System.Linq;
using FileData;
using Models;

namespace Blazor_Authentication.Data.Impl
{
    public class FamilyManager : IFamilyManager
    {

        private FileContext _fileContext;

        public FamilyManager()
        {
            _fileContext = new FileContext();
        }
        
        public void AddFamily(Family family)
        {
            _fileContext.Families.Add(family);
            _fileContext.SaveChanges();
        }

        public void RemoveFamily(Family family)
        {
            _fileContext.Families.Remove(family);
            _fileContext.SaveChanges();
        }

       public IList<Family> GetFamilies()
       {
           return _fileContext.Families;
       }

       public void Update(Family family)
       {
           Family familyToUpdate = _fileContext.Families.First(f =>
               f.StreetName.Equals(family.StreetName) && f.HouseNumber.Equals(family.HouseNumber));
           //familyToUpdate.HouseNumber = 3;
           //familyToUpdate.StreetName = "WOWE";
           _fileContext.SaveChanges();
       }

       public Family Get(string streetName, int houseNumber)
       {
           return _fileContext.Families.FirstOrDefault(f =>
               f.StreetName.Equals(streetName) && f.HouseNumber.Equals(houseNumber));
       }
    }
}