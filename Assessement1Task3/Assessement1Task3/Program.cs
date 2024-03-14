
using System.Globalization;
using System.Reflection.Metadata;
using System.Transactions;

namespace Assessement1Task3
{
    class Programe
    {

        static void Main(string[] args)
        {


           

            string name;

            Console.Write("Hey user please enter Your name here :");
            name=Console.ReadLine( );
            Console.WriteLine   (" Welcome  "  +  name );

            // Declare an array

            int[] num = new int[10];



            
          

            for ( int i = 0; i < 10; i++ )
            {
                // read the values

                Console.Write("Enter number " + (i+1) + ":");


                num[i] = Convert.ToInt32( Console.ReadLine() );

             
                
            }
             
            // loop for change the values in array
            for ( int i = 0;i < num.Length ;i++ )
            {
                num[i] = num[i] / (i+1);
            }

            // display the new array values
            Console.WriteLine("The new values of array are : ");

            for ( int i  =0;  i< num.Length; i++ ) 
            {
                Console.Write((i+1)  + (num[i])   );
                  
            }



       
            
               















            

        }
    }
}











