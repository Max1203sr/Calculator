class Task
{
    void liters() // From grams to liters
    {
        Console.WriteLine("From grams to liters\n");

        Console.WriteLine("Enter grams");

        int grams = int.Parse(Console.ReadLine());

        double liters = (double)grams / 1000;

        Console.WriteLine("grams to liter: " + liters);
    }

    void gallons() // From liters to gallons
    {
        Console.WriteLine("From liters to gallons\n");

        Console.WriteLine("Enter liters");

        int liters = int.Parse(Console.ReadLine());

        double gallons = (double)liters / 3.785;

        Console.WriteLine("liters to gallons: " + gallons);
    }


    static void Main(string[] args)
    {
        Task task = new Task();
        task.liters();
        task.gallons();
    }
}