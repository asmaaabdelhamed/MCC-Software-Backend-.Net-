using Assignment3;
using static Library_management_system.Person;

namespace Library_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Student("asmaa", 25);
            Person p2 = new Librarian("abdallah", 32); 
            p1.DisplayRole();
            p2.DisplayRole();
            Console.WriteLine("================================");

            Library library = new Library();
            library.AddBooks(new Book("life", 3));
            library.DisplayBooks();
            Console.WriteLine("================================");
            LibraryItem book = new Book("clean code", 1);
            LibraryItem magazine = new Magazine("cook", 4);
            Console.WriteLine(book.GetDetails());
            Console.WriteLine(magazine.GetDetails());
            Console.WriteLine("================================");


           
        }
    }
}
