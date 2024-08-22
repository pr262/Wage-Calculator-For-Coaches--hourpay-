using System;
// Hej Josef, om du läser detta så är detta programmet till för att räkna ut min lön så att jag slipper använda hjärnan!
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Input Days Worked:");
        int daysWorked = int.Parse(Console.ReadLine());

        Console.WriteLine("How long is one group:");
        int groupLength = int.Parse(Console.ReadLine());

        Console.WriteLine("Number of groups per day");
        int groups = int.Parse(Console.ReadLine());

        Console.WriteLine("Input Wage:");
        double wage = double.Parse(Console.ReadLine());


        double Time = groupLength *= groups;
        double TotalTime = Time *= daysWorked;
        double TimeHour = TotalTime / 60;
        double TotalWage = wage * TimeHour;

        Console.WriteLine($"Total wage: {TotalWage}");

        

        

        
    }
}
