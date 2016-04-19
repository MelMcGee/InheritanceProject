using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class CrystalBall:Magic,IRandomPhrase
    {
        //changed from field to Property b/c of Interface.
        public Random Rnd { get; set; } = new Random();

        //properties
        public List<string> Phrases { get; set; } = new List<string>();

        public override string Name { get; set; } = "Crystal Ball";

        public override Enum Difficulty { get; set; } = DifficultyOptions.easy;
        

        public override void Work()
        {
            base.Work();
            Console.WriteLine("This work is {0}", this.Difficulty);
            //now let's call a method that will get a result for the crystal ball
            this.Result = GetPhrase();

        }
        
        public void CreatePhrases()
        {
            Phrases.Add("Night time is a dark place for you.");
            Phrases.Add("I see shiny objects in your near future");
            Phrases.Add("The decorating around you needs some help.");
        }

        //let's create an overloaded method now
        public void CreatePhrases(string phrase)
        {
            Phrases.Add(phrase);
        }

        public string GetPhrase()
        {
            //local variable
            int randomNumber = Rnd.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumber);

        }
        public override string ToString()
        {
            return this.Name;
        }

        public virtual void StateEffectiveness()
        {
            Console.WriteLine("In case you're wondering, this method is {2} percent effective.", this.Name, this.Result, this.PercentEffective);
        }

        //constructor
        //let's override some of the properties of what we inherited from magic and service here.
        public CrystalBall()
        {
            this.Price = 45.00M;
            this.PercentEffective = 65;
            this.BlackMagic = false;
            this.Expertise = "beginner";
            Program.AvailableServices.Add((Service)this);
            //I want to call my initializer for phrases.
            CreatePhrases();
        }

    }
}
