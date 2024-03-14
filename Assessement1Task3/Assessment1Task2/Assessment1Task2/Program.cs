namespace Assessement1Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            

            Console.Write("Hey user please enter a number you want to find the factors for : ");
            num= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The factors of" +num+ "are :");



            for (int i = 1; i<= num; i ++)
            {

                if ( num % i == 0)
                {

                    Console.WriteLine(i ) ; 
                    
                }






            }



            Console.WriteLine();


        }


    }
}