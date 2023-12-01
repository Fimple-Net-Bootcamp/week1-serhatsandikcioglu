using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi
{
    public class LongTermLend : Library
    {
        public override void Lending(int membershipNumber, int bookId)
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
                    Console.WriteLine(book.Name + " Book Was Long Term lent To " + member.Name + " " + member.Surname);
                    break;
                }
            }
            if (book == null)
            {
                Console.WriteLine("Book Not Found.");
                return;
            }
        }
        public override void ReturningBook(int membershipNumber, string bookName)
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
            Console.WriteLine("The Long Term Lented Book Has Been Return");
        }
    }
}
