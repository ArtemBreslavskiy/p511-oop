using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = {
                new Book("George Orwell", "1984", "Penguin Books", 1949, 328),
                new Book("J.K. Rowling", "Harry Potter", "Bloomshury", 1997, 223),
                new Book(),
                new Book(),
                new Book(),
                new Book(),
                new Book(),
                new Book()
            };
        }
    }
}
