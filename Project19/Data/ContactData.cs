using Project19.ContextFolder;
using Project19.Interfaces;
using Project19.Entitys;

namespace Project19.Data
{
    public class ContactData : IContactData
    {
        private readonly DataContext context;

        public ContactData(DataContext Context)
        {
            this.context = Context;
        }

        public void AddContacts(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
        }

        public IEnumerable<Contact> GetContacts()
        {
            return this.context.Contacts;
        }
    }
}
