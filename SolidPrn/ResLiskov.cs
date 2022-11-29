using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrn
{
    public abstract class Restaurant
    {
        public abstract string GetRating();
    }
    public class BerbequeNation : Restaurant
    {
        public override string GetRating()
        {
            return " *** ";
        }
    }
    public class Toit : Restaurant
    {
        public override string GetRating()
        {
            return " ***** ";
        }
    }
    class ResLiskov
    {
        public void Rating()
        {
            Restaurant myRestaurant = new BerbequeNation();
            Console.WriteLine(myRestaurant.GetRating());
            myRestaurant = new Toit();
            Console.WriteLine(myRestaurant.GetRating());
        }
    }
}
