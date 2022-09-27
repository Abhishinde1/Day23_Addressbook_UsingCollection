namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book Program");

            AddressBookCreate createAddressBook = new AddressBookCreate();
            createAddressBook.ReadInput();
        }
    }
}