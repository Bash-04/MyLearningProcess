using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.SetColor("rood");
            Console.WriteLine("De kleur van de auto is " + myCar.GetColor());

            Person myPerson = new Person();

            myPerson.SetName("Gert");
            Console.WriteLine("De bestuurder van de auto heet " + myPerson.GetName());

            if (System.Diagnostics.Debugger.IsAttached) Console.ReadLine();
        }
    }
    
    public class Car
    {
        private string color;

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return this.color;
        }
    }

    public class Person
    {
        private string name;

        public void SetName(string characterName)
        {
            this.name = characterName;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
