using System;

namespace Assignment2_JorichPonio_c0818858
{
    internal class ParkingCharges
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PARKING CHARGES");

            Console.Write("How many cars were parked Today? "); //Get the total number of cars you want to cacluate the charges
            int numOfCars = Int32.Parse(Console.ReadLine());

            if (numOfCars < 1) //validate user input for the number of cars
            {
                Console.WriteLine("Please enter at least 1 to proceed!");
            }

            double[] hours = new double[numOfCars];
            double hrsParked = 0.0;
            double paymentDue = 0.0;

            for (int i = 0; i < numOfCars; i++)
            {
                Console.Write("Enter Total Parking Hours for Car {0}: ", (i + 1)); //Get the total of hours per car parked
                hours[i] = double.Parse(Console.ReadLine());
                //validate user input for the hours parked 
                if (hours[i] == 0 || hours[i] > 24)
                {
                    Console.WriteLine("Please enter a valid hour range between 1-24");
                    continue;
                }

            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Car # \t\t Hours Parked \t Due");
            for (int i = 0; i < numOfCars; i++)
            {
                Console.Write("{0} \t\t  {1} \t\t {2}\n", i + 1, hours[i], calculateCharges((int)hours[i]));  //invoking the method and return the value per car
                hrsParked += hours[i];
                paymentDue += calculateCharges((int)hours[i]);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Total: \t\t  {0} \t\t {1}", hrsParked, paymentDue); //display total number of hours parked and the dues
            Console.WriteLine("-----------------------------------------");
        }

        static double calculateCharges(int hours)
        {
            double fee = 2;
            double addfee = 0.5;
            double charge;

            if (hours <= 3)
                return fee; //default parking fee min 3 hrs
            else
            {
                charge = addfee * (hours - 3) + fee; //additional charge of .50 on top of the 3 hrs mininum
                if (charge > 10) //max amount to be paid
                    return 10;
                else
                    return charge; //return charge amount
            }
        }

    }
}