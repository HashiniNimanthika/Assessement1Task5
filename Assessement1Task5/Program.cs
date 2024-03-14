using System.ComponentModel.Design;

namespace Assessement1Task5
{
    class Program
    {

        static void Main()
        {
            int mathMarks; int physicsMarks; int chemistryMarks; int computerScienceMarks;
            double avarageMarks;
            char grade;

            // Ask marks from user
            Console.Write("Hey student ! please enter your Mathematics marks here (out of 100) : ");
            mathMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your Physics marks here (out of 100) : ");
            physicsMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your chemistryMarks here (out of 100) : ");
            chemistryMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("please enter your Computer Science marks here (out of 100) : ");
            computerScienceMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Avarage Marks :" + (mathMarks + physicsMarks + chemistryMarks + computerScienceMarks)/4);
            avarageMarks = Convert.ToDouble(Console.ReadLine());


           
             
                if ( avarageMarks >= 80)
                {
                    Console.WriteLine("Your Grade is : " + 'A');
                }
                else if (avarageMarks >= 70)
                {
                    Console.WriteLine("Your Grade is : " + 'B');
                }
                else if (avarageMarks >= 60)
                {
                    Console.WriteLine("Your Grade is :" + 'C');
                }
                else if (avarageMarks >= 50)

                {
                    Console.WriteLine("Your Grade is : " + 'D');
                }
                else
                {
                    Console.WriteLine("Your Grade is : " + 'F');
                }
      
            Console.WriteLine("Your grade is :" );
            grade = Convert.ToChar(Console.ReadLine());
            
            


            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent! Your grade is 'A'");
                    break;

                case 'B':
                    Console.WriteLine("Good your grade is 'B'");
                    break;
                case 'C':
                    Console.WriteLine("Satisfactory! Your Grade is 'c'");
                    break;
                case 'D':
                    Console.WriteLine("Pass! Your Grade is 'D'");
                    break;
                default:
                    Console.WriteLine("Fail! Your grade is 'F'");
                    break;
            }








        }
    }   
}