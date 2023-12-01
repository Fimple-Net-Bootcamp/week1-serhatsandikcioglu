using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi
{
    public class WrittenWork
    {
        private static int _idCounter = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        public WrittenWork(string name, string author, int publicationYear)
        {
            Id = _idCounter++;
            Name = name;
            Author = author;
            PublicationYear = publicationYear;
        }
    }
}
