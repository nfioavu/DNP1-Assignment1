using System.Collections.Generic;

namespace Assignment1
{
    public interface IFileContext
    {
        List<Adult> GetAdults();
        List<Family> GetFamilies();
        void AddAdult(Adult adult);
        void AddFamily(Family family);
    }
}