// See https://aka.ms/new-console-template for more information
using KutuphaneYonetimSistemi;
LongTermLend longTermLend = new LongTermLend();
Library library = longTermLend;
IPrintable printable = library;
int input;
int membershipNumber;
do
{
    Console.WriteLine("Please select the operation you want to perform : \n*************************\n(1) Add a New Book\n(2) Delete the Existing Book\n" +
        "(3) List All Book\n(4) Add a New Member\n(5) Delete the Existing Member\n(6) List All Member\n(7) Lending\n(8) Return Book\n(9)Long Term Lending\n" +
        "(10)Long Term Return Book\n(0) Exit");
    input = int.Parse(Console.ReadLine());
    switch (input)
    {
        case 1:
            library.AddBook();
            break;
        case 2:
            library.DeleteBook();
            break;
        case 3:
            printable.GetAllBook();
            break;
        case 4:
            library.AddMember();
            break;
        case 5:
            library.DeleteMember();
            break;
        case 6:
            printable.GetAllMembership();
            break;
        case 7:
            try
            {
                Console.WriteLine("Membership number :");
                membershipNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Book id:");
                int bookId = int.Parse(Console.ReadLine());
                library.Lending(membershipNumber, bookId);
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Membership and Book id should be number.");
                continue;
            }
        case 8:
            try
            {
                Console.WriteLine("Membership number :");
                membershipNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Book name :");
                string bookName = Console.ReadLine();
                library.ReturningBook(membershipNumber, bookName);
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Membership number should be number. Book name should be letter.");
                continue;
            }
        case 9:
            try
            {
                Console.WriteLine("Membership number :");
                membershipNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Book id:");
                int bookId = int.Parse(Console.ReadLine());
                longTermLend.Lending(membershipNumber, bookId);
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Membership and Book id should be number.");
                continue;
            }
        case 10:
            try
            {
                Console.WriteLine("Membership number :");
                membershipNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Book name :");
                string bookName = Console.ReadLine();
                longTermLend.ReturningBook(membershipNumber, bookName);
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Membership number should be number. Book name should be letter.");
                continue;
            }
        case 0:
            Console.WriteLine("Exit");
            break;
        default:
            Console.WriteLine("Invalid transaction number, try again.");
            break;
    }
} while (input != 0);