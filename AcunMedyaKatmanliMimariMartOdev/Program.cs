using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities;

IProgrammingLanguageService programmingLanguageService = new Programm_ngLanguageManager(new InMemoryProgrammingLanguageRepository());
ITechnologyuService technologyService = new TechnologyManager(new InMemoryTechnologyRepository());


Console.WriteLine("Yeni Bir Programlama Dili Ekleyiniz");
Console.Write("Programlama Dili Adı: ");
string languageName = Console.ReadLine();

ProgrammingLanguage newlanguage = new ProgrammingLanguage {ProgrammingLanguageName = languageName };
programmingLanguageService.Add(newlanguage);


Console.WriteLine("/nProgramlama Dilleri Listesi");
var languages = programmingLanguageService.GetListProgrammingLanguages();
foreach (var language in languages)
{
    Console.WriteLine(language.ProgrammingLanguageName);
}

Console.WriteLine("Yeni Bir Teknoloji Ekleyiniz");
Console.Write("Teknoloji Adı: ");
string technologyName = Console.ReadLine();

Technology newTechnology = new Technology { TechnologyName = technologyName };
technologyService.Add(newTechnology);

Console.WriteLine("/nTeknoloji Listesi");
var technologies = technologyService.GetListTechnologies();
foreach (var technology in technologies)
{
    Console.WriteLine(technology.TechnologyName);
}

Console.WriteLine("İşlem tamamlandı. Çıkmak için bir tuşa basınız...");
Console.ReadKey();

