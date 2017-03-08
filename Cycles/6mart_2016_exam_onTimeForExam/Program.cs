using System;


namespace _6mart_2016_exam_onTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            int totalExamMinutes = minutesExam + hourExam * 60;
            int totalArrivalMinutes = minutesArrival + hourArrival * 60;

            if (totalArrivalMinutes > totalExamMinutes) Console.WriteLine("Late");
            else if ((totalArrivalMinutes <= totalExamMinutes) && (Math.Abs(totalExamMinutes - totalArrivalMinutes) <= 30)) Console.WriteLine("On Time");
            else Console.WriteLine("Early");

            if (totalExamMinutes != totalArrivalMinutes)
            {
                if (totalArrivalMinutes > totalExamMinutes)
                {
                    int lateDifference = totalArrivalMinutes - totalExamMinutes;
                    if (lateDifference > 59) Console.WriteLine($"{(lateDifference) / 60}:{((lateDifference) % 60):00} hours after the start");
                    else Console.WriteLine($"{ ((lateDifference) % 60):##} minutes after the start");
                }
                else
                {
                    int earlyDifference = totalExamMinutes - totalArrivalMinutes;
                    if (earlyDifference > 59) Console.WriteLine($"{(earlyDifference) / 60}:{((earlyDifference) % 60):00} hours before the start");
                    else Console.WriteLine($"{ ((earlyDifference) % 60):##} minutes before the start");

                }
            }
        }
    }
}
