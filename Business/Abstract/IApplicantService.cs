using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        bool CheckPerson(Person person);

        void Add(Person person);
        void Delete(Person person);
        void Update(Person person);
        
    }
}
