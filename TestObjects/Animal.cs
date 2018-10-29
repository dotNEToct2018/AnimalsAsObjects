using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestObjects
{
    class Animal
    {
        protected string name;
        protected bool hasFur;
        protected int numberOfLegs;

        public Animal()
        {
            //any initialization goes here
        }
        public Animal(string type, bool fur, int legs)
        {
            name = type;
            hasFur = fur;
            numberOfLegs = legs;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public bool HasFur
        {
            get
            {
                return hasFur;
            }
            set
            {
                hasFur = value;
            }
        }
        public int NumberOfLegs
        {
            get
            {
                return numberOfLegs;
            }
            set
            {
                numberOfLegs = value;
            }
        }
        public virtual void Eat()
        {
            Console.WriteLine("food in mouth, swallow!");
            Console.WriteLine("eat, eat!!!");
        }
        public override string ToString()
        {
            StringBuilder myString = new StringBuilder();
            myString.Append("I have an animal. ");
            if (name != null)
            {
                myString.Append("It is a ");
                myString.Append(name);
                myString.Append(". ");
            }
            if (hasFur)
            {
                myString.Append("It has fur. ");
            }
            if (numberOfLegs > 0)
            {
                myString.Append("It has ").Append(numberOfLegs).Append(" legs. ");
            }
            return myString.ToString();
        }
    }
}
