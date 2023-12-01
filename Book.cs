using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi
{
    public class Book : WrittenWork
    {
        public Book(string name,string author,int pablicationYear) : base(name,author,pablicationYear)
        {
        }
    }
}
