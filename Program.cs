using System;
/* Q.1: Create an app that calculates the total amount based on the type of customer and subtotal amount. 
 * Submitted by: Jorich Ponio - C0818858
 */
namespace CmrTypeTotalAmount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose customer type [R / C]:");      
            Console.Write("Input your Choice: "); //User input for the customer type R or C
            String choice = Console.ReadLine(); //Store chosen option into the choice var

            double sub_total=0, discount_percent = 0.0, discount_amount = 0.0, total_amount = 0.0;

            switch (choice) //Begin switch for the chosen option
            {
                case "R":
                    Console.WriteLine("You have entered: R");
                    Console.Write("Enter the subtotal Amount: "); //User input for the subtotal value
                    sub_total = double.Parse(Console.ReadLine()); //store the value in the sub_total variable

                    //If the Subtotal is greater than or equal to 250,discount is: 25%.
                    if (sub_total >= 250)
                        discount_percent = 0.25;
                    else //If Subtotal is greater than or equal to 100 and less than 250, discount is: 10%.
                    {
                        if (sub_total >= 100 && sub_total < 250)
                            discount_percent = 0.10;
                        else
                            discount_percent = 0.00; //default value is zero if no condition is met;
                    }
                    discount_amount = sub_total * discount_percent; //Calculate discount
                    total_amount = sub_total - discount_amount; //Caculate the total Amount less the discount
                    break;

                case "C":
                    Console.WriteLine("You have entered: C");

                    Console.Write("Enter the subtotal Amount: "); //User input for the subtotal value
                    sub_total = double.Parse(Console.ReadLine()); //store the value in the sub_total variable
                    //If the Subtotal is greater than or equal to 250,discount is: 30%.
                    if (sub_total >= 250)
                        discount_percent = 0.30;
                    else //If Subtotal is greater than or equal to 100 and less than 250, discount is: 20%.
                    {
                        if (sub_total >= 100 && sub_total < 250)
                            discount_percent = 0.20;
                        else
                            discount_percent = 0.00; //default value is zero if no condition is met;
                    }
                    discount_amount = sub_total * discount_percent; //Calculate discount
                    total_amount = sub_total - discount_amount; //Calculate the total Amount less the discount
                    break;

                default:
                    Console.WriteLine("Invalid Input. Please try again!"); //If invalid input, show msg
                    break;
            }
            //DISPLAY OUTPUT
            Console.WriteLine("\n****************************************\n");
            Console.WriteLine("Customer Type    : {0}", choice); 
            Console.WriteLine("Subtotal Amount  : {0}", sub_total.ToString("C"));
            Console.WriteLine("Discount in %    : {0}", discount_percent.ToString("P0"));
            Console.WriteLine("Discounted Amount: {0}", discount_amount.ToString("C"));
            Console.WriteLine("Total Amount     : {0}", total_amount.ToString("C"));
            Console.WriteLine("\n****************************************\n");
        }
    }
}