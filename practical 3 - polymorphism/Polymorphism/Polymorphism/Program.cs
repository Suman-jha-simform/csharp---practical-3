using System;

namespace Polymorphism
{
    class Bird
    {
        /// <summary>
        /// This method prints the voice of a bird.
        /// </summary>
        /// <returns>void</returns>
        public void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }

    class Duck : Bird
    {
        /// <summary>
        /// This method prints the voice of a Duck.
        /// </summary>
        /// <returns>void</returns>
        public void Voice()
        {
            Console.WriteLine("Quack Quack");
        }

        public static void Main()
        {
            Bird myBird = new Bird();
            //Duck myDuck = new Bird();

            Bird myBird2 = new Duck();

            myBird.Voice();
            myBird2.Voice();
        }
    }
}