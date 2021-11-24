using System;


namespace OOP_Part1
{
    class Program
    {

        class Dog
        {
            //class fields
            string name;
            int spots;
            double happiness;

            public Dog(string _name, int _spots) //constructor
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} has been created");
            }

            //Getters
            public string Name //Name getter
            {
                get { return name; }
            }

            public string Spots
            {
                get { return Spots; }
            }

            public double Happiness
            {
                get { return happiness;  }
            }

            public void Barks()
            {
                Console.WriteLine("Woof-woof");
                happiness += 0.2; //happiness = happiness + 0.2
            }

            public void Wags()
            {
                Console.WriteLine($"{Name} Wiggle-wiggle");
            }

            public void Rename(string NewName)
            {
                name = NewName;
            }

            public void ShowDogData()
            {
                Console.WriteLine($"name: {Name}");
                Console.WriteLine($"spots: {spots}");
                Console.WriteLine($"level of happiness: {Happiness}");

            }
        }

        static void Main(string[] args)
        {
            Dog myDog = new Dog("Koer", 15);
            myDog.Barks();
            Console.WriteLine($"{myDog.Name}'s level of happiness: {myDog.Happiness}");
            Dog newDog = new Dog("Dog", 2);
            Console.WriteLine($"{newDog.Name}'s level of happiness: {newDog.Happiness}");

            while(myDog.Happiness != 1)
            {
                myDog.Barks();
            }
            myDog.Wags();

            Console.WriteLine($"Enter a new name for the dog {myDog.Name}");
            string userInput = Console.ReadLine();
            myDog.Rename(userInput);
            myDog.ShowDogData();
        }
    }
}
