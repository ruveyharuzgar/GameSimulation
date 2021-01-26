using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            Console.WriteLine("İsminizi giriniz: ");
            firstName = Console.ReadLine();
            string lastName;
            Console.WriteLine("Soyadınızı giriniz: ");
            lastName = Console.ReadLine();
            long nationalIdentity;
            Console.WriteLine("TC giriniz: ");
            nationalIdentity = Convert.ToInt64(Console.ReadLine());
            int dateOfBirthDay;
            Console.WriteLine("Doğum yılınızı giriniz: ");
            dateOfBirthDay = Convert.ToInt32(Console.ReadLine());
            string department;
            Console.WriteLine("Öğrenci/Sivil bilgisi giriniz: ");
            department = Console.ReadLine();


            Person person = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                NationalIdentity = nationalIdentity,
                DateOfBirthDay = dateOfBirthDay,
                Department = department
                
            };
            
            PersonManager personManager = new PersonManager();
            personManager.Add(person);
            //personManager.Delete(person);
            //personManager.Update(person);

            ICompany company = new Company();
            company.Campaign(person);

            GameManager gameManager = new GameManager(new PersonManager());
            gameManager.GiveGame(person);

            ISalesUnit salesUnit = new DataBaseLoggerService(personManager);
            salesUnit.GiveGame(person);

            
           

            Console.ReadLine();
        }
    }
}
