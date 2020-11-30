using System;

namespace InheritanceClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Cessna myCessna = new Cessna()
            {
                MainColor = "white"
            };
            Ram myRam = new Ram()
            {
                MainColor = "Silver"
            };
            Tesla myTesla = new Tesla()
            {
                MainColor = "Burgundy"
            };
            Zero myZero = new Zero()
            {
                MainColor = "Black"
            };

            myCessna.Drive();
            myCessna.Turn("left");
            myCessna.Stop();

            myRam.Drive();
            myRam.Turn("right");
            myRam.Stop();

            myTesla.Drive();
            myTesla.Turn("left");
            myTesla.Stop();

            myZero.Drive();
            myZero.Turn("right");
            myZero.Stop();


        }
    }
}
