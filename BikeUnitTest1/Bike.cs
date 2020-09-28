using System;
using System.Diagnostics.CodeAnalysis;

namespace BikeUnitTest1
{
    public class Bike
    {
        public int Id { get; set; }

        private string _color;

        public string Color
        {
            get { return _color; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                if (value.Length >= 1)
                {
                    _color = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
        }

        private int _gear;

        public int Gear
        {
            get { return _gear; }
            set
            {
                if (value >= 3 && value <= 32)
                {
                    _gear = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
        }
        private int _price;

        public int Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
        }

        public Bike(int id, string color, int gear, int price)
        {
            Id = id;
            Color = color;
            Gear = gear;
            Price = price;
        }

    }
}
