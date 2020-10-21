using System.Collections.Generic;

namespace Assignment1.Data.FamilyMembersService
{
    public interface IFamilyMembersService
    {
        List<Adult> GetAdults();
        List<Family> GetFamilies();
        void AddAdult(Adult adult);
        void AddFamily(Family family);
    }
}
