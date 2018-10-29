using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal myCat = new Animal();
            //myCat.Name = "cat";
            //myCat.HasFur = true;
            //myCat.NumberOfLegs = 4;

            Cat myCat = new Cat("calico");
            Console.WriteLine(myCat.ToString());
            myCat.Eat();
            myCat.ChaseMouse();
            Console.WriteLine();

            Animal myDog = new Animal("dog", true, 4);
            Console.WriteLine(myDog.ToString());
            myDog.Eat();

            Console.WriteLine("my dog has " + myDog.NumberOfLegs + " legs");

            Console.ReadLine();
        }
    }
}
