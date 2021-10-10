using Models;

namespace Blazor_Authentication.Data
{
    public interface IFamilyManager
    {
        void AddFamily(Family family);
        void RemoveFamily(Family family);
        
        
        
    }
}