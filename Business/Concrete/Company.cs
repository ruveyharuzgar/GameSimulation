using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class Company : ICompany
    {
        public void Campaign(Person person)
        {
            if(person.Department=="Öğrenci")
            {
                Console.WriteLine("Öğrenciye özel kampanya kazandınız.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Size özel bir kampanyamız bulunamamaktadır.");
                Console.ReadLine();
            }
        }
    }
}
