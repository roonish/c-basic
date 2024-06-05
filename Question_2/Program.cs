class AirportParking
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Airport Parking System");
        // Asking user to choose the type of parking
        Console.WriteLine("Please choose the type of parking:");
        Console.WriteLine("1. Long-Term Parking");
        Console.WriteLine("2. Short-Term Parking");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CalculateLongTermParking();
                break;
            case 2:
                CalculateShortTermParking();
                break;
            default:
                Console.WriteLine("Invalid choice. Please run the program again.");
                break;
        }
    }

    static void CalculateLongTermParking()
    {
        Console.WriteLine("You choose Long-Term Parking.");
        Console.Write("Enter the number of days parked: ");
        int days = int.Parse(Console.ReadLine());
        const int oneTimeFee = 25;
        const int dailyRate = 40;
        int totalCharge = oneTimeFee + (dailyRate * days);
        Console.WriteLine($"Total Long-Term Parking charge: ${totalCharge}");
    }

    static void CalculateShortTermParking()
    {
        Console.WriteLine("You choose Short-Term Parking.");
        Console.Write("Enter the number of hours parked: ");
        int hours = int.Parse(Console.ReadLine());

        if (hours > 24)
        {
            Console.WriteLine("For parking durations longer than 24 hours, please consider using Long-Term Parking.");
            return;
        }

        const int firstHourRate = 4;
        const int additionalHourRate = 3;
        const int maxDailyCharge = 40;

        int totalCharge = 0;

        if (hours <= 1)
        {
            totalCharge = firstHourRate;
        }
        else
        {
            totalCharge = firstHourRate + ((hours - 1) * additionalHourRate);
        }

        // if the price is greater than 40, only charge 40 as total charge
        if (totalCharge > maxDailyCharge)
        {
            totalCharge = maxDailyCharge;
        }

        Console.WriteLine($"Total Short-Term Parking charge: ${totalCharge}");
    }
}
