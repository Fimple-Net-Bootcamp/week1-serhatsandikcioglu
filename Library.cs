using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi
{
    public class Library : IPrintable
    {
        public List<Book> books = new List<Book>();
        public List<Member> members = new List<Member>();

        public Library() 
        {
            books = new List<Book>();
            members = new List<Member>();
        }
        public void AddBook()
        {
            Console.Write("Please Enter Book Name: ");
            var name = Console.ReadLine();
            Console.Write("Please Enter Book Author: ");
            var author = Console.ReadLine();
            Console.Write("Plase Enter Publication Year: ");
            var publicationYear = int.Parse(Console.ReadLine());
            Book newBook = new Book(name, author, publicationYear);
            books.Add(newBook);
            Console.WriteLine("Book Successfully Added");
        }
        public void DeleteBook()
        {
            Console.Write("Please Enter Book Name: ");
            var name = Console.ReadLine();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Name.ToLower() == name.ToLower())
                {
                    books.Remove(books[i]);
                    Console.WriteLine("The book has been deleted");
                    break;
                }
                    Console.WriteLine("The book not found");
            }
        }
        public void GetAllBook()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine("Book Id :" + books[i].Id);
                Console.WriteLine("Name : " + books[i].Name);
                Console.WriteLine("Author : " + books[i].Author);
                Console.WriteLine("Publication Year :" + books[i].PublicationYear);
                Console.WriteLine("********************");
            }
        }
        public void AddMember()
        {
            Console.Write("Please Enter Name: ");
            var name = Console.ReadLine();
            Console.Write("Please Enter Surname: ");
            var surname = Console.ReadLine();
            Member newMember = new Member(name, surname);
            members.Add(newMember);
            Console.WriteLine("Member Successfully Added");
        }
        public void DeleteMember()
        {
            Console.Write("Please Enter Membership Number: ");
            int membershipNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < members.Count; i++)
            {
                if (membershipNumber == members[i].MembershipNumber)
                {
                    members.Remove(members[i]);
                    Console.WriteLine("The member has been deleted");
                    break;
                }
            }
            Console.WriteLine("Member Not Found");
        }

        public void GetAllMembership()
        {
            for (int i = 0; i < members.Count; i++)
            {
                Console.WriteLine("Membership Number : " + members[i].MembershipNumber);
                Console.WriteLine("Name : " + members[i].Name);
                Console.WriteLine("Surname : " + members[i].Surname);
                Console.Write("Books : ");
                for (int j = 0; j < members[i].Books.Count; j++)
                {
                    Console.Write(members[i].Books[j].Name + ",");
                }
                Console.WriteLine();
                Console.WriteLine("********************");

            }
        }
        public virtual void Lending(int membershipNumber, int bookId)
        {
            Member member = null;
            Book book = null;
            for (int i = 0; i < members.Count; i++)
            {
                if (membershipNumber == members[i].MembershipNumber)
                {
                     member = members[i];
                    break;
                }
            }
            if (member == null)
            {
                Console.WriteLine("Member Not Found");
                return;
            }
            for (int i = 0; i < books.Count; i++)
            {
                if (bookId == books[i].Id)
                {
                        book = books[i];
                        member.Books.Add(book);
                        Console.WriteLine(book.Name + " Book Was lent To " + member.Name + " " + member.Surname);
                        break;
                }
            }
            if (book == null)
            {
                Console.WriteLine("Book Not Found.");
                return;
            }
        }
        public virtual void ReturningBook(int membershipNumber, string bookName)
        {
            Member member = null;
            Book book = null;
            for (int i = 0; i < members.Count; i++)
            {
                if (membershipNumber == members[i].MembershipNumber)
                {
                    member = members[i];
                    break;
                }
            }
            if (member == null)
            {
                Console.WriteLine("Member Not Found");
                return;
            }
            for (int i = 0; i < books.Count; i++)
            {
                if (bookName == books[i].Name)
                {
                    book = books[i];
                    break;
                }
            }
            if (book == null)
            {
                Console.WriteLine("Book Not Found");
                return;
            }
            member.Books.Remove(book);
            Console.WriteLine("The Book Has Been Return");
        }
    }
}
