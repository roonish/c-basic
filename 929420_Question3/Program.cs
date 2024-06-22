using System;
using System.IO;

class PositionCalculator
{
    static void Main()
    {
        // Create a text file to write data
        //Its under 929420_Question3\bin\Debug\net8.0\positions_calculator.txt
        string filePath = "positions_calculator.txt";

        // Write header to the file
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Time\tPosition");

            // Loop from t=0.0 to t=20.0 seconds
            for (double t = 0.0; t <= 20.0; t++)
            {
                // Calculate position using calculatePosition method
                double position = calculatePosition(t);

                // Display time and position
                Console.WriteLine($"Time: {t:F1}\tPosition: {position:F1}");

                // Write time and position to the file
                writer.WriteLine($"{t:F1}\t{position:F1}");
            }
        }

        Console.WriteLine("Data written to particle_positions.txt file.");
    }

    // Method to calculate position of the particle
    static double calculatePosition(double time)
    {
        return 4.0 - 2.0 * time;
    }
}
