using System;

namespace lab02
{
    public class Program
    {
        //ATM should do the following
        // 1. view balance 
        // 2. Withdraw money 
        // 3. Add money 
        // 4. Keep propmting user until they choose exit
        // 5. have tests 

        public static double Balance = 2000;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your ATM");

            //These are setting up the switch and responses so you can move through the UI
            bool action = true;
            while (action)
            {
                Console.WriteLine("Please select one of the following. 1. 2. 3. 4. ");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit ATM");

                Int32.TryParse(Console.ReadLine(), out int number);

                double value;
                switch (number)
                {
                    case 1:
                        //this case handles all my balance checking
                        Console.WriteLine($"Your current balance at this time is {Balance}");

                        break;

                    case 2:
                        //this case is for widthdrawing it uses my method down below
                        Console.WriteLine("How much are you widthdrawing?");
                        double.TryParse(Console.ReadLine(), out value);

                        Withdraw(value);

                        break;

                    case 3:
                        //Case 3 is for depositing it uses the method deposit to track and handle what you see.
                        Console.WriteLine("How much are you depositing?");
                        double.TryParse(Console.ReadLine(), out value);
                        Console.WriteLine(Deposit(value) ? "Deposit was succesful" : "Invalid amount");

                        break;

                    default:
                        //this is just a stop and exit basically. I added a call for balance here as well to recap what you were doing. 
                        //I wanted it to simulate that final ATM screen you see in the real world. One last balance summary. 
                        Console.WriteLine($"Your final balance is {Balance}. Thank you please have a nice day.");
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static string Withdraw(double amount)
            //This is a basic two part if statement that keeps track of the balance and how much you are withdrawing.
            //It stops you from going into the negative or using invalid numbers.
        {
            if (amount > Balance)
            {
                Console.WriteLine($"Amount is larger than your balance of {Balance}");
                return $" here is the {Balance}";
            }
            if (amount <= 0)
            {
                Console.WriteLine("You are trying to withdraw an invalid amount of money.");
                return "invalid amount";
            }

            Balance -= amount;

            Console.WriteLine($"Withdraw successful transaction complete. Remaining balance is {Balance}");
            return "successful";
           

            
        }
        public static bool Deposit(double amount)
            // A one part if statement that checks if the depositing ammount is correct or not. 
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }
    }
}
