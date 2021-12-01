using System;

namespace HumanAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Adding a value to the object; then passes it to the constructor
            Human newHuman = new Human("Roscoe", 4, 5, 3, 100);
            Console.WriteLine($"This human {newHuman.Name} has a strength of {newHuman.Strength}, intelligence of {newHuman.Intelligence}, dexterity of {newHuman.Dexterity}, and health of {newHuman.Health}");
        }
    }

    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
         
        // add a public "getter" property to access health
        public int Health
        {
            get{ return health; }
        } 

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        // Add a constructor to assign custom values to all fields
        public Human(string n, int s, int i, int d, int h)
        {
            Name = n;
            Strength = s;
            Intelligence = i;
            Dexterity = d;
            health = h;
        }
         
        // Build Attack method
        public int Attack(Human target)
        {
            
            return 0;
        }
    }





}
