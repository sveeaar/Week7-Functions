using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime;
            //programm palub kasutajal sisestada number 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnimi tagurpidi;
            //kui kasutaja sisestab '2', siis kuvatakse kasutaja eesnime esimene täht;
            //kui kasutaja sisestab '3', siis kuvatakse kasutaja eesnime pikkus;

            Console.WriteLine("Sisestage oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisestage number '1', '2' või '3'.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            GetUserNameData(userName, userNumber);


        }
        public static void GetUserNameData(string userInput, int userNumber)
        {
            if(userNumber == 1)
            {
                for (int i = userInput.Length - 1; i >= 0; i--)
                {
                    Console.Write(userInput[i]);
                }
            }
            else if(userNumber == 2)
            {
                Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
            }
            else
            {
                Console.WriteLine($"Sinu eesnimi on {userInput.Length} sümbolit pikk.");
            }
            
                
            
        }
    }
}
