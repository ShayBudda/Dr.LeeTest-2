using System;

class Car
{
    private string vin;
    private string make;
    private string model;
    private int mileage;

    // Constructor with all fields
    public Car(string vin, string make, string model, int mileage)
    {
        this.vin = vin;
        this.make = make;
        this.model = model;
        this.mileage = mileage;
    }

    // Constructor with make and model only, default mileage is 0
    public Car(string make, string model)
    {
        this.vin = Guid.NewGuid().ToString();
        this.make = make;
        this.model = model;
        this.mileage = 0;
    }

    // Method to increase the mileage
    public void Drive(int miles)
    {
        if (miles > 0)
        {
            mileage += miles;
        }
    }

    // Method to display the car's information
    public void Display()
    {
        Console.WriteLine($"VIN: {vin}");
        Console.WriteLine($"Make: {make}");
        Console.WriteLine($"Model: {model}");
        Console.WriteLine($"Mileage: {mileage}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Creating the first car with all fields
        Car car1 = new Car("1HGCM82633A004352", "Honda", "Accord", 120000);
        car1.Drive(150); // Driving the first car for 150 miles
        car1.Display();  // Displaying the first car's information

        // Creating the second car with make and model only
        Car car2 = new Car("Toyota", "Camry");
        car2.Drive(300); // Driving the second car for 300 miles
        car2.Display();  // Displaying the second car's information
    }
}
