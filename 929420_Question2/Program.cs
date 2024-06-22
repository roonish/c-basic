using System;

class SalesCalculator
{
    static void Main()
    {
        // Constants for base salary which is 1000 and rate which is 10%
        const decimal baseSalary = 1000M;
        const decimal commissionRate = 0.10M;

        // total earnings over 12 months which is 0 in begining
        decimal totalEarnings = 0M;

        //  keep track of the number of months processed
        int monthCount = 0;

        // while statement to input each salesperson’s gross sales for the past 12 month
        while (monthCount < 12)
        {
            Console.Write("Enter gross sales for month " + (monthCount + 1) + " (or type -1 to stop): ");
            string input = Console.ReadLine();

            // Stop when user type -1 and show Goodbye text
            if (input == "-1")
            {
                Console.WriteLine("Goodbye!");
                return; 
            }

            //  parsing the input
            decimal grossSales;
            bool isValidDecimal = decimal.TryParse(input, out grossSales);

            // Validating the parsed input
            if (isValidDecimal && grossSales >= 0)
            {
                // Calculate monthly earnings
                decimal monthlyEarnings = baseSalary + (commissionRate * grossSales);

                Console.WriteLine($"Earnings for month {monthCount + 1}: {monthlyEarnings}");

                // Add monthly earnings to total earnings
                totalEarnings += monthlyEarnings;

                // Increment the month counter for while loop to run only 12 times
                monthCount++;
            }
            else
            {
                // Display error message 
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        }
        // Display the total earnings for 12 months
        Console.WriteLine($"Total earnings for 12 months: {totalEarnings}");
    }
}
