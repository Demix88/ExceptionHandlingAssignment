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
            Console.WriteLine("===============Welcome===============");
            try
            {
                bool ValidAge = false;
                int YourAge = 0;
                while (!ValidAge)
                {
                    Console.WriteLine("Please type in your age");
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
                Console.WriteLine("Positive Values only\n No Zeroes");
                Console.ReadLine();


            }
            catch (Exceptions.ZeroException)
            {
                Console.WriteLine("Your age can't be zero");
                Console.ReadLine();
                

            }
            catch (Exceptions.TooBigException)
            {
                Console.WriteLine("That is not possible!!!Are you a vampire?");
                Console.ReadLine();
                
            }
            catch (Exception)
            {
                Console.WriteLine("Error!Please check your values!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("===============GoodBye===============");
            Console.ReadLine();
        }
        


        }
    }

