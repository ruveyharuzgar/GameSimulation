using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DataBaseLoggerService:ISalesUnit
    {
        private PersonManager personManager;

        public DataBaseLoggerService(PersonManager personManager)
        {
            this.personManager = personManager;
        }

        public void GiveGame(Person person)
        {
            DataBaseLoggerService dataBaseLoggerService = new DataBaseLoggerService(new PersonManager());
            if(personManager.CheckPerson(person)==true)
            {
                Console.WriteLine(person.NationalIdentity + " kişisi oyun aldı.Loglara kaydedildi.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("alamadı");
                Console.ReadLine();
            }

            
        }
        
    }
}
