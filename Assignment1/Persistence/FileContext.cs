using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Assignment1;
using Assignment1.Pages;

namespace Assignment1 {
public class FileContext : IFileContext
{
    public IList<Family> Families { get; private set; }
    public IList<Adult> Adults { get; private set; }
    
    private readonly string familiesFile = "families.json";
    private readonly string adultsFile = "adults.json";

    // public FileContext()
    // {
    //     string content = File.ReadAllText(familiesFile);
    //     Families = JsonSerializer.Deserialize < List<Family>>(content);
    //     
    //     string content2 = File.ReadAllText(adultsFile);
    //     Adults = JsonSerializer.Deserialize < List<Adult>>(content2);
    // }

    public FileContext() {
        Families = File.Exists(familiesFile) ? ReadData<Family>(familiesFile) : new List<Family>();
        Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
    }
    
    private IList<T> ReadData<T>(string s) {
        using (var jsonReader = File.OpenText(s)) {
            return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
        }
    }

    public void SaveAdultsToFile()
    {
        // storing persons
        string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions {
            WriteIndented = true
        });

        using (StreamWriter outputFile = new StreamWriter(adultsFile, false)) {
            outputFile.Write(jsonAdults);
        }
    }
    
    public void SaveFamilyToFile()
    {
        string jsonFamilies = JsonSerializer.Serialize(Families, new JsonSerializerOptions {
            WriteIndented = true
        });

        using (StreamWriter outputFile = new StreamWriter(familiesFile, false)) {
            outputFile.Write(jsonFamilies);
        }
    }
    // public void SaveChanges() {
    //     // storing families
    //     string jsonFamilies = JsonSerializer.Serialize(Families, new JsonSerializerOptions {
    //         WriteIndented = true
    //     });
    //
    //     using (StreamWriter outputFile = new StreamWriter(familiesFile, false)) {
    //         outputFile.Write(jsonFamilies);
    //     }
    //
    //     // storing persons
    //     string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions {
    //         WriteIndented = true
    //     });
    //
    //     using (StreamWriter outputFile = new StreamWriter(adultsFile, false)) {
    //         outputFile.Write(jsonAdults);
    //     }
    // }

    public List<Family> GetFamilies()
    {
        List<Family> fam = new List<Family>(Families);
        return fam;
    }

    public List<Adult> GetAdults()
    {
        List<Adult> adl = new List<Adult>(Adults);
        return adl;
    }



    public void AddAdult(Adult adult)
    {
        // int max = Adults.Max(adult => adult.Id);
        // adult.Id = (++max);
        // Adults.Add(adult);
        // string productsAsJson = JsonSerializer.Serialize(Adults);
        // File.WriteAllText(adultsFile, productsAsJson);
        Adults.Add(adult);
        SaveAdultsToFile();
    }

    public void AddFamily(Family family)
    {
        Families.Add(family);
        SaveFamilyToFile();
    }
}
}