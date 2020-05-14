using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveHundredFifth = new Building("500 5th Avenue N", "Your Mom"){
                Width= 13.3,
                Height= 432,
                stories = 33,
                Depth = 22
            };
            Building NineteenTwentyTwo = new Building(" 1922 b 14th ave n", "Steve Brownlee"){
                Width= 19.3,
                Height= 324,
                stories = 2,
                Depth = 22
            };
            Building TwoTwoFourTwo = new Building("2242 tired of coding circle", "I don't care"){
                Width= 199.3,
                Height= 3432,
                stories = 44,
                Depth = 22
            };


            FiveHundredFifth.Construct();
            NineteenTwentyTwo.Construct();
            TwoTwoFourTwo.Construct();

            FiveHundredFifth.Purchase("Your other mom");
            NineteenTwentyTwo.Purchase("Someone rich");
            TwoTwoFourTwo.Purchase("Mr. Moneybags");

            FiveHundredFifth.BuildingReport();
            NineteenTwentyTwo.BuildingReport();
            TwoTwoFourTwo.BuildingReport();



        }
    }

    public class Building
    {
        private string _designer {get; set;}
        private DateTime _dateConstructed {get; set;}

        private string _address {get; set;}

        private string _owner {get; set;}

        public int stories {get; set;}

         public double Width {get; set;}

        public double Height {get; set;}
         public double Depth {get; set;}

         public double Volume(){
             double totalVolume = Width * Depth * (3 * stories);
             return totalVolume;
         }

         public Building(string address, string designer){
             _address = address;
             _designer = designer;
         }

         public void Construct() {
             _dateConstructed = DateTime.Now;
         }

         public void Purchase(string newOwner) {
             _owner = newOwner;
         }

        public void BuildingReport(){
            Console.WriteLine(this._address);
            Console.WriteLine("----------------");
            Console.WriteLine($"Designed by: {this._designer}");
            Console.WriteLine($"Constructed on: {this._dateConstructed}");
            Console.WriteLine($"Owned By: {this._owner}");
            Console.WriteLine(Volume());
            Console.WriteLine(" ");

        }


    }


}
