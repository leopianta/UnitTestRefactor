using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestsRefactor.Storage.DTOs;

namespace UnitTestsRefactor.Storage.Repository
{
    public class ContactRepository
    {
        public static List<ContactDto> ContactsList = new List<ContactDto>();

        public ContactRepository()
        {
        }

        public void Add(ContactDto contact)
        {
            ContactsList.Add(contact);
        }

        public void Delete(ContactDto contact)
        {
            ContactsList.Remove(contact);
        }

        public List<ContactDto> GetAll()
        {
            return ContactsList;
        }

    }
}
