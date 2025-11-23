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
            Phone phone1 = new Phone("Apple", "IPhone 13 Pro", 85000);
            Phone phone2 = new Phone("Samsung", "Galaxy S25", 77000);

            phone1.ShowInfo();
            phone2.ShowInfo();

        }
    }
}
