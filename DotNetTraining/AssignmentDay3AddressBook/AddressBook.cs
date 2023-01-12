class AddressBook
{
    //field
    private readonly List<Contact> _contacts;
    public AddressBook()
    {
        _contacts = new List<Contact>();
    }
    public void AddContact(Contact contact)
    {
        _contacts.Add(contact);
    }
    public void RemoveContact(Contact contact)
    {
        _contacts.Remove(contact);
    }
    public void SortContact()
    {
        _contacts.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));
    }
    public void PrintContacts()
    {
        foreach (var item in _contacts)
        {
            Console.WriteLine(item);
        }
    }
}