using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface IRandomPhrase
    {

        Random Rnd { get; set; }
        List<string> Phrases { get; set; }
        void CreatePhrases();
        //void CreatePhrases(string phrase);
        string GetPhrase();

    }
}
