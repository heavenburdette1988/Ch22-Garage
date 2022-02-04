using System;

namespace ch22Garage
{

    class Program
    {
        static void Main(string[] args)
        {

            // Questions
            //Would it make since to split up electric vehicles and gas vehicles 
             
            Zero blueZero = new Zero()
            {
                MainColor = "Midnight Blue"
            };

            Zero blackZero = new Zero()
            {
                MainColor = "Black"
            };

            Tesla burgundyTesla = new Tesla()
            {
                MainColor = "Burgundy"
            };
            Cessna whiteCessna = new Cessna()
            {
                MainColor = "White"
            };

            Ram silverRam = new Ram()
            {
                MainColor = "Silver"
            };



            blueZero.Drive();
            blackZero.Drive();
            burgundyTesla.Drive();
            silverRam.Drive();
            whiteCessna.Drive();

            // Zero fxs = new Zero ();
            // Tesla modelS = new Tesla ();
            // Cessna mx410 = new Cessna();

            // fxs.Drive();
            // modelS.Drive();


        }

    }
}









