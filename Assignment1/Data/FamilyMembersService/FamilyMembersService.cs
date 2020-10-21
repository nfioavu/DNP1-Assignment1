using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Assignment1.Data.FamilyMembersService
{
    public class FamilyMembersService:IFamilyMembersService
    {
        private IFileContext FileContext;

        public FamilyMembersService()
        {
            FileContext = new FileContext();
        }
        public List<Family> GetFamilies()
        {
            return FileContext.GetFamilies();
        }

        public List<Adult> GetAdults()
        {
            return FileContext.GetAdults();
        }
        
        
        public void AddAdult(Adult adult)
        {
            FileContext.AddAdult(adult);
        }

        public void AddFamily(Family family)
        {
            FileContext.AddFamily(family);
        }

    }
}