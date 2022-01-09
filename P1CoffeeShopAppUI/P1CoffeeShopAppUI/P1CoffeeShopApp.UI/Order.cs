using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1CoffeeShopApp.UI
{

    public class Order
    {
        //field for adding total coffees together.
        private decimal orderTotal;

        public Order()
        {
            orderTotal = 0;
        }



        public void Ordering()
        {
            //Logic, Call methods in order of how i need them!
            welcomeMessage();       //First


            //Want to give user total after every order
            itemSold("Small Coffee", 2m);
            coffeeCartTotal();
            itemSold("Medium Coffee", 4m);
            coffeeCartTotal();
            itemSold("Large Coffee", 8m);
            coffeeCartTotal();

            displayGoodbyeMessage();    //Last        
        }


        //Diplay options
        private void welcomeMessage()
        {
            string s = "\n" + "Welcome to the coffee shop." +
                        "****This is the menu****." +
                        "  Small Coffee $2.  Medium Coffee $4.  Large Coffee $8. ";
            s = s.Replace(".", ".\n");
            //Console.WriteLine("*********************************************");
            Console.WriteLine(s);
            //Console.WriteLine("Please press enter to continue");
            //Console.ReadLine();
        }
        //Console.WriteLine("1.Small Coffee@2.Medium Coffee@3Large Coffee");
        //Console.WriteLine("**********************************************");


        private void itemSold(string coffeeSize, decimal price)
        {
            Console.WriteLine($"Would you like to order {coffeeSize} for {price:C2} (y/n)");
            string response = Console.ReadLine().ToUpper();
            if (response.StartsWith("Y"))
            {


                Console.WriteLine("How many coffees would you like?");
                string numItems = Console.ReadLine();


                try
                {
                    int quantity = Convert.ToInt32(numItems);
                    //This is the calculation
                    decimal totalCoffee = price * quantity;
                    orderTotal += totalCoffee;

                    Console.WriteLine($"{quantity} x {coffeeSize}s is {totalCoffee:C2}");

                }

                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please try again");
                    itemSold(coffeeSize, price);///Recursion used to ask again 

                    return;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input, please try again");
                    itemSold(coffeeSize, price);///Recursion used to ask again 
                    return;
                }
            }
            else
            {
                Console.WriteLine("Oh you dont want any coffee?");
            }


        }
        private void coffeeCartTotal()
        {
            Console.WriteLine($"Current total is {orderTotal:C2}!");
        }


        private static void displayGoodbyeMessage()
        {

            Console.WriteLine("Have a wonderul day");
            Console.WriteLine("Goodbybe");
            Console.ReadLine();
        }

    }
}