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
                f.FamilyId == family.FamilyId);
            _fileContext.SaveChanges();
        }
        
        public Family GetFamily(int familyId)
        {
            return _fileContext.Families.FirstOrDefault(family =>
                family.FamilyId == familyId);
        }

        public void RemoveAdult(int adultId)
        {
            GetAdults().Remove(GetAdult(adultId));
            _fileContext.SaveChanges();
        }

        public IList<Adult> GetAdults()
        {
            List<Adult> _adults = new();

            foreach (var family in _fileContext.Families)
            {
                _adults.AddRange(family.Adults);
            }

            return _adults;
        }

        public Adult GetAdult(int id)
        {
            return GetAdults().FirstOrDefault(adult =>
                adult.Id == id);
        }
    }
}