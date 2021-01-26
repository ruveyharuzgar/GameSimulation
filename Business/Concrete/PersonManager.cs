using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName+" isimli kişi eklendi");
            Console.ReadLine();
        }
        public void Delete(Person person)
        {
            Console.WriteLine("Silme---");
            string firstname = Console.ReadLine();
            person.FirstName = firstname;
            Console.WriteLine(firstname + " isimli kişi silindi");
            Console.ReadLine();

        }

        public void Update(Person person)
        {
            Console.WriteLine("Güncelleme---");
            string firstname = Console.ReadLine();
            person.FirstName = firstname;
            Console.WriteLine(firstname + " isimli kişi bilgileri güncellendi");
            Console.ReadLine();

        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthDay))).Result.Body.TCKimlikNoDogrulaResult;
        }

       
    }
}
