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



    }
}
