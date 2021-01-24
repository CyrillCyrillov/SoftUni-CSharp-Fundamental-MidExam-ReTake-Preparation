using System;


namespace Task01_Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentsNumbers = double.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double additionalBonus = double.Parse(Console.ReadLine());

            double maxBonusPoint = 0;
            int attendancesLectures = 0;

            for (int i = 1; i <= studentsNumbers; i++)
            {
                int nextStudentInfo = int.Parse(Console.ReadLine());
                double nextBonusPoints = Math.Round(nextStudentInfo / lecturesCount * (5 + additionalBonus));

                if(nextBonusPoints > maxBonusPoint)
                {
                    maxBonusPoint = nextBonusPoints; ;
                    attendancesLectures = nextStudentInfo;
                }
            }
            
            Console.WriteLine($"Max Bonus: {maxBonusPoint}.");
            Console.WriteLine($"The student has attended {attendancesLectures} lectures.");
        }
    }
}
