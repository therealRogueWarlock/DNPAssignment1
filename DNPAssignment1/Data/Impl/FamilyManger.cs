using FileData;
using Models;

namespace Blazor_Authentication.Data.Impl
{
    public class FamilyManger : IFamilyManager
    {

        private FileContext _fileContext;

        public FamilyManger()
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
        
    }
}