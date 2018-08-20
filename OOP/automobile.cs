using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class automobile
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        private decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    price = 0;

                }
                else
                {
                    price = value;
                }


            }

        }

        public int NumberofTires { get; set; }

        public void Display()
        {
            Console.WriteLine("Make: " + Make);
            Console.WriteLine("Price:" + Price);
            Console.WriteLine("Year: " + Year);

        }
    }
}
