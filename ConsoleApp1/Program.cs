class Task
{
    void centimeters() // From meters to centimeters
    {
        Console.WriteLine("From meters to centimeters:\n");

        Console.WriteLine("Enter meters");
        int meters = int.Parse(Console.ReadLine());
        int centimeters = meters * 100;

        Console.WriteLine("meters to centimeters: " + centimeters);
    }

    void kilometers() // From meters to km
    {
        Console.WriteLine("From meters to km:\n");

        Console.WriteLine("Enter meters");
        int meters = int.Parse(Console.ReadLine());
        double kilometers = (double)meters / 1000;

        Console.WriteLine("meters to kilometers: " + kilometers);
    }

    static void Main(string[] args)
    {
        Task task = new Task();
        task.centimeters();
        task.kilometers();
    }
}