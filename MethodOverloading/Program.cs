using System.ComponentModel;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine(Add(5, 7, true));    
            Console.WriteLine(Add(-6, 3, true));    
        }
        public static int Add(int x, int y) 
        {
            return (x + y);
        }
        public static decimal Add(decimal x, decimal y)
        {
            return (x + y);
        }
        public static string Add(int x, int y, bool isTrue)
        {
            var sum = x+y;
            var response = "";
            if(isTrue)
            {
                
                if(sum == 1)
                {
                    response = $"{sum} dollar.";
                }
                else
                {
                    response = $"{sum} dollars.";
                }
            }
            return response;
        }
     
    }
}
