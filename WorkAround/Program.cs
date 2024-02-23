using Business.Concreate;
using Entities.Concreate;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.FirstName = "Merve";
        person.LastName = "KOK";
        person.DateOfBirthYear = 2003;
        person.NationalIdentity = 123;
        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person);
    }
    
}
