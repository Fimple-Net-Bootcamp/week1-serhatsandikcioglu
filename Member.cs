using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi
{
    public class Member
    {
        private static int _membershipCounter = 1;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int MembershipNumber { get;private set; }
        public List<Book> Books { get; set; }
        public Member(string name, string surname)
        {
            MembershipNumber = _membershipCounter++;
            Name = name;
            Surname = surname;
            Books = new List<Book>();
        }
    }
}
