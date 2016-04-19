using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        public static List<Service> AvailableServices { get; set; } = new List<Service>();
        static void Main(string[] args)
        {
            //our game will start here
            //let's create some Magic services
            FortuneTeller fortuneTeller = new FortuneTeller();
            CrystalBall crystalBall = new CrystalBall();
            PalmReading palmReading = new PalmReading();
            fortuneTeller.Greet(); //say hi
            do
            {

                fortuneTeller.ListServices();
                int selection = int.Parse(Console.ReadLine());
                //get service at the index of their num - 1.
                Magic selectedService = (Magic)AvailableServices[0]; //NOTE, b/c this is a Magic, not a specific child, we'll get Magic's implementations below.
                try
                {
                     selectedService = (Magic)AvailableServices[selection - 1];
                }
                catch(Exception e)
                {
                    //Console.WriteLine(e.Message);
                    Console.WriteLine("Since I didn't understand your response, I'm just going to start with a {0}", selectedService);
                }
                fortuneTeller.StartService(selectedService); //talk about the service that's being performed
                selectedService.Work(); //run it (do the service)
                selectedService.Show(); //display it (state results of the service)
                selectedService.StateEffectiveness(); //state effectiveness of service.
                fortuneTeller.PlayAgain();
            } while (Console.ReadLine()=="Y");
            
            
            fortuneTeller.Farewell(); //say goodbye.
        }
    }
}
