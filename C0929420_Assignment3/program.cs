using System;

namespace Assignment3
{
   public class Address
    {
        // data fields
        private string street;
        private string municipality;
        private string region;
        private string postalCode;

        //  no arg constructor
        public Address()
        {
            this.street = "N/A";
            this.municipality = "N/A";
            this.region = "N/A";
            this.postalCode = "N/A";
        }

        // Constructor with parameters
        public Address(string street, string municipality, string region, string postalCode)
        {
            this.street = street;
            this.municipality = municipality;
            this.region = region;
            this.postalCode = postalCode;
        }

        // Properties
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string Municipality
        {
            get { return municipality; }
            set { municipality = value; }
        }

        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        // ToString method
        public override string ToString()
        {
            return $"Street: {street}\nCity: {municipality}\nState: {region}\nZipCode: {postalCode}";
        }
    }

    //New class Residence that has Address object in data fields
    public class Residence
    {
        // Data fields
        private double price;
        private double squareFeet;
        private int yearBuilt;
        private Address address;

        // No-arg constructor
        public Residence()
        {
            price = 0.0;
            squareFeet = 0.0;
            yearBuilt = 0;
            address = new Address();
        }

        // Constructor with parameters
        public Residence(double price, double squareFeet, int yearBuilt, Address address)
        {
            this.price = price;
            this.squareFeet = squareFeet;
            this.yearBuilt = yearBuilt;
            this.address = address;
        }

        // Properties
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double SquareFeet
        {
            get { return squareFeet; }
            set { squareFeet = value; }
        }

        public int YearBuilt
        {
            get { return yearBuilt; }
            set { yearBuilt = value; }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        // CalculateCommission method
        public double CalculateCommission()
        {
            return price * 0.028;
        }

        // ToString method
        public override string ToString()
        {
            return $"Price: ${price}\nSquare Feet: {squareFeet}\nYear Built: {yearBuilt}\nAddress:\n{address}\nCommission: ${CalculateCommission()}";
        }
    }

    // A test program for the Address class and recidence class to demonstrates the both class
    class AddressRecidencePrompt
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the street name
            Console.Write("Enter the street name: ");
            string street = Console.ReadLine();

            // Prompt the user to enter the municipality name
            Console.Write("Enter the municipality name: ");
            string municipality = Console.ReadLine();

            // Prompt the user to enter the region name
            Console.Write("Enter the region name: ");
            string region = Console.ReadLine();

            // Prompt the user to enter the postal code
            Console.Write("Enter the postal code: ");
            string postalCode = Console.ReadLine();

            // Create an instance called stringAddress of type Address with the entered data
            Address stringAddress = new Address(street, municipality, region, postalCode);

            // Prompt the user to enter the price
            Console.Write("Enter the price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the square feet
            Console.Write("Enter the square feet: ");
            double squareFeet = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the year built
            Console.Write("Enter the year built: ");
            int yearBuilt = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the Residence class with the entered data (including the address data)
            Residence residence = new Residence(price, squareFeet, yearBuilt, stringAddress);

            // Display the information about the residence using ToString()
            Console.WriteLine("\nThe entered residence information is:");
            Console.WriteLine(residence);
            //used to protect console from terminating once code has been completed executing
            Console.ReadKey();
        }
    }
}