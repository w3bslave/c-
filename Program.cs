using System;
/* Q2: Creating a BMI Calculator; 
 * Submitted by: Jorich Ponio - C0818858
 */
namespace bmiCalculatorJorichP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi = 0; //set default value for bmi to 0; 
            Console.WriteLine("------------- Body Mass Index Calculator -------------");
            Console.Write("Enter your weight (kg)   :  "); //user input for the weight;
            double body_weight = double.Parse(Console.ReadLine());  //store value to body_weight;

            Console.Write("Enter your height (m)    :  ");//user input for the height;
            double body_height = double.Parse(Console.ReadLine()); //store value to body_weight;

            bmi = body_weight / (body_height * body_height); //calucluate bmi 
            Console.WriteLine("Your Body Mass Index is  : {0}",bmi.ToString("n2")); //dispkay bmi

            //Display BMI Chart
            Console.WriteLine("\tBody Index Mass Chart");
            Console.WriteLine("CLASSSIFICATION\t\tBMI Category (kg/m20)");
            Console.WriteLine("Underweight\t\t<18.5");
            Console.WriteLine("Normal Weight\t\t18.5 - 24.9");
            Console.WriteLine("Overweight\t\t25.0 - 29.9");
            Console.WriteLine("Obese class I\t\t30.0 - 34.9");
            Console.WriteLine("Obese class II\t\t35.0 - 39.9");
            Console.WriteLine("Obese class III\t\t>=40.0");
        }
    }
}
