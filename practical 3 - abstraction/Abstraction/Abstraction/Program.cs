using System;

namespace Abstraction
{
    class Laptop
    {
        private string brand;

        private string model;

        public string Model{
            get { return model; }
            set { model = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        /// <summary>
        /// This methods prints the details of the laptop
        /// </summary>
        /// <returns>void</returns>
        public void LaptopDetails()

        {

            Console.WriteLine("Brand: " + Brand);

            Console.WriteLine("Model: " + Model);

        }

        /// <summary>
        /// This methods prints the motherboard information of the laptop
        /// </summary>
        /// <returns>void</returns>
        private void MotherBoardInfo()

        {

            Console.WriteLine("MotherBoard Information");

        }

        public static void Main()
        {
            Laptop newLaptop = new Laptop();
            newLaptop.Model = "HP Pavillion 360 - touch";
            newLaptop.Brand = "HP";
            newLaptop.LaptopDetails();
            newLaptop.MotherBoardInfo();
        }
    }
}