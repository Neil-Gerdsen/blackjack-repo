using System;
using System.Collections.Generic;
using System.Text;

namespace oopTest.classes
{
    public class Card
    {


        public string Suit { get; set; }
        public string Rank { get; set; }
        public int Value { get; set; }

        public string Image
        {
            get { return $"{Rank}_of_{Suit}.png"; }
        }



        //public string Suit { get; set; }
        //public string Rank { get; set; }

        //public int Value
        //{
        //    get
        //    {
        //        return Rank switch
        //        {
        //            "2" => 2,
        //            "3" => 3,
        //            "4" => 4,
        //            "5" => 5,
        //            "6" => 6,
        //            "7" => 7,
        //            "8" => 8,
        //            "9" => 9,
        //            "10" => 10,
        //            "jack" => 10,
        //            "queen" => 10,
        //            "king" => 10,
        //            "ace" => 11, // of 1 afhankelijk van je spel
        //            _ => 0
        //        };
        //    }
        //}
    }
}
