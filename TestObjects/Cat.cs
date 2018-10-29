using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestObjects
{
    class Cat : Animal
    {
        private string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public Cat()
        {
            hasFur = true;
            numberOfLegs = 4;
            name = "cat";
        }
        public Cat(string furColor)
        {
            hasFur = true;
            numberOfLegs = 4;
            name = "cat";
            color = furColor;
        }

        public override void Eat()
        {
            Console.WriteLine("Can the cat see the bottom of the food bowl? (y/n)");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("The cat cannot eat because its bowl is empty. It meows pitifully for more food");
            }
            else
            {
                base.Eat();
            }

        }
        public override string ToString()
        {
            StringBuilder myString = new StringBuilder(base.ToString());
            if (color != null)
            {
                myString.Append("It is a ").Append(color).Append(" cat.");
            }
            return myString.ToString();
        }
        public void ChaseMouse()
        {
            Console.WriteLine("The cat sees a mouse!");
            Console.WriteLine("The cat chases a mouse!");
        }
        public void Play(string toy)
        {
            Console.WriteLine("The cat is playing with a " + toy);
            Console.WriteLine("The cat takes a nap.");
        }
    }
}
