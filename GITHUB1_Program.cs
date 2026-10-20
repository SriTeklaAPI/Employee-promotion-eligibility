using System;

namespace CSharpLearning
{
    class EmployeePromotionEligibility
    {
        static void Main()
        {
            Console.WriteLine("Enter Employe Age  : ");
            bool IsValid1 = Int32.TryParse(Console.ReadLine(), out int Age);

        
            Console.WriteLine("Enter Employe Experience in Years : ");
            bool IsValid2 = Int32.TryParse(Console.ReadLine(), out int Exp);

            Console.WriteLine("Enter Employe Rating Enter 1 to 5 : ");
            bool IsValid3 = Int32.TryParse(Console.ReadLine(), out int Rating);

            Console.WriteLine("How many Projected completed : ");
            bool IsValid4 = Int32.TryParse(Console.ReadLine(), out int Pro);

            if(IsValid1 && IsValid2 && IsValid3 && IsValid4)
            {
                if (Age <18 || Exp <0 || Pro <0 || (Rating <1 || Rating >5))
                {
                    Console.WriteLine("Invalid Input1");
                }
                else
                {
                    if(Age >=28 &&Exp >=6 && Rating >=4 && Pro >= 10)
                    {
                        Console.WriteLine("Senior Promotion eligible");
                    }
                    else if(Age >=24 && Exp >=3 && Rating >= 3 && Pro >= 5)
                    {
                        Console.WriteLine("Mid-Level Position");
                    }
                    else if(Exp >= 1 && Rating >=2 && Pro >= 2)
                    {
                        Console.WriteLine("Junior Promotion");
                    }
                    else
                    {
                        Console.WriteLine("Promotion not eligible : \nhard work pathathu smart work venum");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

    }
}