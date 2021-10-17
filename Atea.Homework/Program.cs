using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Atea.Homework
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Welcome to Atea Homework!");
                Input input = new Input();
                Common common = new Common();
                Console.WriteLine("Please enter first argument");
                input.firstArgument = Console.ReadLine();
                Console.WriteLine("Please enter second argument");
                input.secondArgument = Console.ReadLine();
                Console.WriteLine("-------------------------------------------------");

                if (common.validateInputTypes(input))
                {

                    Entity entity = common.AddValues(input);
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("The addition of two arguments is :" + entity.sum);
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Calling API to Save in Database -- Inprogress. ");
                    Console.WriteLine(common.PostDataToApi(entity));
                }
                else
                {
                    Console.WriteLine("Arguments entered are different data types, please enter same types for addition");
                }
                Console.WriteLine("******************************************************");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exeption occured while adding arguments :" + ex.Message);
            }
        }
    }

}
