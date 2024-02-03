using System;

namespace InlamingListUppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nameLoop = true;
            List<string> names = new List<string>();

            Console.WriteLine("Skriv in olika namn som du vill skriva bak och fram. Skriv en tom rad för att avsluta inmatnings stadiet och få resultat");
            while (nameLoop != false)
            {
                
                string userInput = Console.ReadLine();
                
                if (string.IsNullOrEmpty(userInput))
                {
                    nameLoop = false;

                }
                else
                {
                    names.Add(userInput);

                }

            }
            Console.Clear();

            for (int i = 0; i < names.Count; i++)
            {
                for (int j = names[i].Length -1; j >= 0; j--)
                {
                    Console.Write(names[i][j]);

                }
                Console.WriteLine();

            }
            Console.ReadKey();


        }

    }

}