using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Nokia elevenHundred = new Nokia("33600",99,"Cingular", "Nokia's dee-de-de, dee-de-de, deeeee");
            elevenHundred.DisplayInfo();
            System.Console.WriteLine(elevenHundred.Ring());
            System.Console.WriteLine(elevenHundred.Unlock());

            Galaxy s8 = new Galaxy("s8",70,"US Cellular", "Aqua: Nuh, nuh-nuh-nuh-nuh, Nuh");
            s8.DisplayInfo();
            System.Console.WriteLine(s8.Ring());
            System.Console.WriteLine(s8.Unlock());
           
        }
    }
}

