using Business.Abstract;
using Entities.Concreate;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> GetList() 
        {
            return null;
        }
        public bool ChechPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear)
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
