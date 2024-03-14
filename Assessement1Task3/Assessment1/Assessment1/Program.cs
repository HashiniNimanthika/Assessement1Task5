namespace Assessment1
{
    class Programme
    {
        static void Main(string[] args)
        {
           //Declares the variables
            
            int sum = 0;
            string name;

            Console.Write("Hey user ! please enter your name here :");
            name = Console.ReadLine();
            Console.WriteLine("welcome " +  name +"!");

             //  for loop for control 

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) 
                {
                    sum= sum+i;
                }

            }

            Console.WriteLine("The sum of all multiples of   3 and 5 between  1 to 100 is :" + sum);







        }



    }







}       
    

