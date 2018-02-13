namespace Quiz_Beginners
{
    class CSharpBasics
    {
MessageBox.Show("Width: " + img.Width + ", Height: " + img.Height);
        
        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        /// 

    }

       class Program   
       {       
           static void Main(string[] args)       
           {            
               int i, number, fact;            
            Console.WriteLine("Enter the Number");           
               number = int.Parse(Console.ReadLine());            
               fact = number;            
               for (i = number - 1; i >= 1; i--)            
               {               
                   fact = fact * i;           
               }            
               Console.WriteLine("\nFactorial of Given Number is: "+fact);            
               Console.ReadLine();
           }
       }
        /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        /// </summary>
        /// 



class programreverse
{   
 public static string Reverse( string s )
 {
       Char temp = num;    
      char[] charArray = 
s.ToCharArray();    Array.Reverse( charArray 
);    return new string( charArray );}
            while (num > 0)        
        {            remainder = num % 10;            
         reverse = reverse * 10 + remainder;            
         num /= 10;        
        }        
        Console.WriteLine("Given number is = {0}", temp);       
        Console.WriteLine("Its reverse is  = {0}", reverse);       
        if (temp == reverse)           
            Console.WriteLine("string to reverse \n");        
        else            
            Console.WriteLine("reversed string\n");       
        Console.ReadLine();    }}
        /// <summary>
        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
        /// </summary>
                     ///
               Class hypen
               {
                       public static void Main() 
               {
if (var ="5-6-7-8-9" )                       
    Console.WriteLine("consecutive \n");                
               else                       
                   Console.WriteLine("non-consecutive \n");               
          Console.ReadLine(); 
           }
       }


        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        /// 



    }
}
