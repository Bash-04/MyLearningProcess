using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTeam
{
    public class Player
    {
        // properties
        public string Name { get; private set; }
        public int Number { get; private set; }
        public FieldPosition FieldPosition { get; private set; }
        public double salary { get; private set; }

        // functions
        public Player(string name, int number, FieldPosition fieldPosition) // Constructor
        {
            this.Name = name;
            this.Number = number;
            this.FieldPosition = fieldPosition;
        }

        public Player(string name) 
        {
            Name = name;
        }

        private double SignContract()
        {
            switch (FieldPosition)
            {
                case FieldPosition.GoalKeeper:
                    this.salary = 97.90;
                    return this.salary;
                case FieldPosition.Defender:
                    this.salary = 84.50;
                    return this.salary;
                case FieldPosition.Midfielder:
                    this.salary = 87.60;
                    return this.salary;
                case FieldPosition.Attacker:
                    this.salary = 92.10;
                    return this.salary;

                default:
                    this.salary = 124.20;
                    return this.salary;
            }
        }

        public void Play()
        {

        }

        public override string ToString()
        {
            return FieldPosition + " - " + Name + " (" + Number.ToString() + ")" + " - €" + SignContract();
        }
    }
}
