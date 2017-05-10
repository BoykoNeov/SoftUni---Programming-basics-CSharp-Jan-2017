using System;


namespace WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int workersNumber = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            int totalWorkHoursAvailable = workersNumber * workDays *8;
            int totalHoursLeft = totalWorkHoursAvailable - hoursNeeded;

            if (totalHoursLeft >= 0)
            {
                Console.WriteLine($"{totalHoursLeft} hours left");
            }
            else
            {
                totalHoursLeft = totalHoursLeft * -1;
                Console.WriteLine($"{totalHoursLeft} overtime");
                Console.WriteLine($"Penalties: {totalHoursLeft * workDays}");
            }
        }
    }
}
