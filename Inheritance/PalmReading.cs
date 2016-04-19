using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class PalmReading:Magic,IRandomPhrase
    {
        //changed from field to Property b/c of Interface.
        public Random Rnd { get; set; } = new Random();

        //properties
        public List<string> Phrases { get; set; } = new List<string>();

        public override string Name { get; set; } = "Palm Reading";

        public override Enum Difficulty { get; set; } = DifficultyOptions.medium;


        public override void Work()
        {
            base.Work();
            Console.WriteLine("This work is {0}", this.Difficulty);
            //now let's call a method that will get a result for the palm reading
            this.Result = GetPhrase();

        }

        public void CreatePhrases()
        {
            Phrases.Add("You will live a very long life.");
            Phrases.Add("Your love life . . . oh, I see misfortune. No, many misfortunes.");
            Phrases.Add("You are as strong as a horse. Your health, I've never seen anything like it.");
            Phrases.Add("You love so many, and they love you in return.");
            Phrases.Add("Your life line and love line never cross. Hmm . . .");
            Phrases.Add("Uh . . . er . . . Excuse me, are you still breathing?");
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
    
        //constructor
        //let's override some of the properties of what we inherited from magic and service here.
        public PalmReading()
        {
            this.Price = 55.00M;
            this.PercentEffective = 85;
            this.BlackMagic = false;
            this.Expertise = "medium";
            Program.AvailableServices.Add((Service)this);
            //I want to call my initializer for phrases.
            CreatePhrases();
        }

    }
}
