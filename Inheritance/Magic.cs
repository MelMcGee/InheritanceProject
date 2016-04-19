using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Magic:Service
    {
        //what is at the base of a magical item?
        //in our base class, let's say that they all have good or bad magic. In this case, let's just say it's black magic, or just magic.
        //now, we have to decide what kind of datatype we want to use to store it. 
            //Since there are only 2 values, it would be very efficient to use a bool
        //property
        public virtual bool BlackMagic { get; set; }

        //how about another property that gives us the effectiveness of this magical item?
        public virtual int PercentEffective { get; set; }

        //let's make sure all of them have a name!
        public override string Name { get; set; }

        //let's throw in the level of expertise the fortune teller needs to use this item
        protected virtual string Expertise { get; set; }

        public override decimal Price { get; set; }
        public override string Result { get; set; }

        //How about a  work -- "make it go now" method?
        public virtual void Work()
        {
            Console.WriteLine("Let me pull out my {0}", this.Name);
        }
        //What about a Show method for sharing the results -- showing the magical object to the user?
        public virtual void Show()
        {
            Console.WriteLine("Oh, my. The {0} told me, yes, your future.", this.Name);
            Console.WriteLine(this.Result);
        }
        public virtual void StateEffectiveness()
        {
            Console.WriteLine("In case you're wondering, this method is {2} percent effective.", this.Name, this.Result, this.PercentEffective);
        }
    }
}

//other considerations: do we ever need to call this class on it's own, or will it always be called by
//another class that inherits from it? That's a good indicator of when to use virtual versus abstract. You *could* call anything in a
//virtual method, and can override it in a child class. You can't use anything directly if the class is abstract.




//I think it would be weird for a fortune teller to say, I will use my magical item. Instead, I can see them saying
//let me use my crystal ball or tarot cards.  
//this would lead me to making this class either abstract, or to create an interface.
//to determine which of those to choose, ask yourself if there are any default methods that need to be run in this class.
//at this point, we'll say yes, and choose an abstract class over an interface.