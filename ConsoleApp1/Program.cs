class Task
{
    void degrees() // Celsius to degrees
    {
        Console.WriteLine("Celsius to degrees\n");

        Console.WriteLine("Celsius");

        double Celsius = int.Parse(Console.ReadLine());

        double degrees = (Celsius * 9 / 5) + 32;

        Console.WriteLine("Celsius to degrees: " + degrees);
    }


    static void Main(string[] args)
    {
        Task task = new Task();
        task.degrees();
    }
}