using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestsRefactor.BusinessLogic.Models;
using UnitTestsRefactor.Storage.DTOs;
using UnitTestsRefactor.Storage.Repository;

namespace UnitTestsRefactor.BusinessLogic.Services
{
    public class UnitTestsRefactorService
    {
        ContactRepository _contactRepository = new ContactRepository();

        public UnitTestsRefactorService(ContactRepository contactRepository)
        {
            contactRepository = _contactRepository;
        }

        public void InsertContact(Contact contact)
        {
            var contactoDto = new ContactDto(contact.Name, contact.Age, contact.cpf);

            _contactRepository.Add(contactoDto);
        }

        public void DeleteContactByName(string name)
        {
            var contact = _contactRepository.GetAll().FirstOrDefault(x => x.Name.Equals(name));

            if (contact != null)
            {
                _contactRepository.Delete(contact);
            }
        }

        public List<Contact> ListContacts()
        {
            var contacts = new List<Contact>();

            var contactsDto = _contactRepository.GetAll();

            foreach (var c in contactsDto)
            {
                var contact = new Contact();

                contact.Name = c.Name;
                contact.Age = c.Age;
                contact.cpf = c.cpf;

                contacts.Add(contact);
            }

            return contacts;
        }
    }
}
