using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveHundredFifth = new Building("500 5th Avenue N");
            Building NineteenTwentyTwo = new Building(" 1922 b 14th ave n");
            Building TwoTwoFourTwo = new Building("2242 tired of coding circle")
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

         public double Depth {get; set;}

         public double Volume(){
             return Width * Depth * (3 * stories);
         }

         public Building(string address){
             _address = address;
         }

         public void Construct() {
             _dateConstructed = DateTime.Now;
         }

         public void Purchase(string newOwner) {
             _owner = newOwner;
         }



    }


}
