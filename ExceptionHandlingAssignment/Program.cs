using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    internal class Program

    {

        static void Main(string[] args)

        {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("===============Welcome===============");
            try
            {
                bool ValidAge = false;
                int YourAge = 0;
                while (!ValidAge)
                {
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please type in your age");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    ValidAge = int.TryParse(Console.ReadLine(), out YourAge);
                    if (!ValidAge) throw new Exception();

                }
                if (YourAge == 0)
                {
                    throw new Exceptions.ZeroException();
                }
                if (YourAge < 0)
                {
                    throw new Exceptions.NegativeException();
                }
                if (YourAge > 150)
                {
                    throw new Exceptions.TooBigException();
                }

                string CurrentDate = DateTime.Now.ToString("yyyy");
                Double DateOfBirth = Convert.ToDouble(CurrentDate) - YourAge;
                Console.WriteLine("You are " + YourAge + " years old.\nYour Date Of Birth is : " + DateOfBirth);
                
            }

            catch (Exceptions.NegativeException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Positive Values only\n No Zeroes");
                Console.ReadLine();


            }
            catch (Exceptions.ZeroException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your age can't be zero");
                Console.ReadLine();
                

            }
            catch (Exceptions.TooBigException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is not possible!!!Are you a vampire?");
                Console.ReadLine();
                
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!Please check your values!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("===============GoodBye===============");
            Console.ReadLine();
        }
    }
}
