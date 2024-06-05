class Program
{
    static void Main()
    {
        // 2d Array to store classmates information
        // 5 classmates and 4 attributes: First Name, Last Name, GPA, DOB
        string[,] classmates = new string[5, 4]; 
        double[] gpas = new double[5];

        // Loop to get input from the user
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Enter details for classmate {i + 1}:");

            // Using Write so that the input can be added in the same line rather than in new line
            Console.Write("First Name: ");
            classmates[i, 0] = Console.ReadLine();

            Console.Write("Last Name: ");
            classmates[i, 1] = Console.ReadLine();

            Console.Write("Last Term GPA: ");
            classmates[i, 2] = Console.ReadLine();
            gpas[i] = Convert.ToDouble(classmates[i, 2]);

            Console.Write("Date of Birth (MM/DD/YYYY): ");
            classmates[i, 3] = Console.ReadLine();

            Console.WriteLine();
        }

        // Print all classmates details
        Console.WriteLine("Classmates Details:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Classmate {i + 1}: {classmates[i, 0]} {classmates[i, 1]}, GPA: {classmates[i, 2]}, DOB: {classmates[i, 3]}");
        }

        // Find the highest GPA and corresponding student
        // Assuming index 0 has the highest gpa and checking it with all other element of list and assigning highest index to higestIndex variable
        double highestGPA = gpas[0];
        int highestIndex = 0;
        for (int i = 1; i < 5; i++)
        {
            if (gpas[i] > highestGPA)
            {
                highestGPA = gpas[i];
                highestIndex = i;
            }
        }

        Console.WriteLine($"\nStudent with the highest GPA: {classmates[highestIndex, 0]} {classmates[highestIndex, 1]} with a GPA of {highestGPA}");

        // Calculate the average GPA
        double totalGPA = 0;
        for (int i = 0; i < 5; i++)
        {
            totalGPA += gpas[i];
        }
        double averageGPA = totalGPA / 5;
        Console.WriteLine($"Average GPA: {averageGPA}");

        // Print the current date and time
        Console.WriteLine($"Current Date and Time: {DateTime.Now}");
    }
}
