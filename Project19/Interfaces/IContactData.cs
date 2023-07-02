using Project19.Entitys;
namespace Project19.Interfaces
{
    public interface IContactData
    {
        IEnumerable<Contact> GetContacts();
        void AddContacts(Contact contact);
    }
}
