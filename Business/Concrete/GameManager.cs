using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GameManager:ISalesUnit
    {
        private IApplicantService _applicantService;
        public GameManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveGame(Person person)
        {
            GameManager gameManager = new GameManager(new PersonManager());
          
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine("Kullanıcı bilgileri girildi: ");
                Console.WriteLine(person.FirstName+" için oyun satışı gerçekleşti.");

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(person.FirstName+" kullanıcı doğrulanamadı.Doğru bilgi giriniz.");
                Console.ReadLine();
            }
        }
    }
}
