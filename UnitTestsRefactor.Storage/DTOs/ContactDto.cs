using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsRefactor.Storage.DTOs
{
    public class ContactDto
    {
        public ContactDto()
        {
                
        }

        public ContactDto(string name, int age, string cpf)
        {
            this.Name = name;
            this.Age = age;
            this.cpf = cpf;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string cpf { get; set; }
    }
}
