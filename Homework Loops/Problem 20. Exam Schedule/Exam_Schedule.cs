using System;

class Exam_Schedule
{
    static void Main()
    {
        int startHour = int.Parse(Console.ReadLine());
        int startMinute = int.Parse(Console.ReadLine());
        string partOfTheDay = Console.ReadLine().ToUpper();
        int durationHour = int.Parse(Console.ReadLine());
        int durationMin = int.Parse(Console.ReadLine());

        int sumHour = 0;
        int sumMin = 0;
        sumHour = startHour + durationHour;
        sumMin = startMinute + durationMin;
        if (sumHour == 12 && partOfTheDay == "PM" )
        {
            
            
                Console.WriteLine("{0:00}(noon):{1:00}:AM", sumHour, sumMin);
            
            
        }
        else
        {
            if (sumHour <= 12 && partOfTheDay == "PM")
            {
                if (sumMin >= 60)
                {
                    sumHour += 1;
                    sumMin -= 60;
                    Console.WriteLine("{0:00}:{1:00}:AM", sumHour, sumMin);
                }
                else
                {
                    Console.WriteLine("{0:00}:{1:00}:PM", sumHour, sumMin);
                }
            }
            else if (sumHour <= 12 && partOfTheDay == "AM")
            {
                if (sumMin >= 60)
                {
                    sumHour += 1;
                    sumMin -= 60;
                    Console.WriteLine("{0:00}:{1:00}:PM", sumHour, sumMin);
                }
                else
                {
                    Console.WriteLine("{0:00}:{1:00}:AM", sumHour, sumMin);
                }
            }
            else if (sumHour > 12 && partOfTheDay == "AM")
            {
                if (sumMin >= 60)
                {

                    sumHour -= 11;
                    sumMin -= 60;
                    Console.WriteLine("{0:00}:{1:00}:PM", sumHour, sumMin);
                }
                else
                {
                    sumHour -= 12;
                    Console.WriteLine("{0:00}:{1:00}:PM", sumHour, sumMin);
                }
            }
            else
            {
                if (sumMin >= 60)
                {

                    sumHour -= 11;
                    sumMin -= 60;
                    Console.WriteLine("{0:00}:{1:00}:AM", sumHour, sumMin);
                }
                else
                {
                    sumHour -= 12;
                    Console.WriteLine("{0:00}:{1:00}:AM", sumHour, sumMin);
                }
            }
        }

    }
}

