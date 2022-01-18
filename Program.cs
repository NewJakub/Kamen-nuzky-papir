using System;

namespace KamenNuzkyPapir
{
    class Program
    {
        static void Main(string[] args)
        {
            int pocetVyher = 0;

            while (true)
            {
                Random r = new Random();
                int cislo = r.Next(0, 3);

                Console.WriteLine("Kámen, nůžky, papír");
                Console.WriteLine("# = Kámen");
                Console.WriteLine("V = Nůžky");
                Console.WriteLine("- = Papír");
                Console.WriteLine();


                try
                {
                    char tah = Convert.ToChar(Console.ReadLine());

                    switch (cislo)
                    {
                        case (0)://kamen
                            if (tah == '#')
                            {
                                Console.WriteLine("Znovu! Počítač použil kámen");
                            }
                            else if (tah == '-')
                            {
                                Console.WriteLine("Vyhrál jsi! Počítač použil kámen");
                                pocetVyher += 1;
                            }
                            else if (tah == 'V')
                            {
                                Console.WriteLine("Prohrál jsi! Počítač použil kámen");
                            }

                            else
                            {
                                Console.WriteLine(tah + " není možnost, použij prosím kámen, nůžky nebo papír.");

                            }
                            break;

                        case (1)://nuzky
                            if (tah == '#')
                            {
                                Console.WriteLine("Vyhrál jsi! Počítač použil nůžky");
                                pocetVyher += 1;
                            }
                            else if (tah == '-')
                            {
                                Console.WriteLine("Prohrál jsi! Počítač použil nůžky");

                            }
                            else if (tah == 'V')
                            {
                                Console.WriteLine("Znovu! Počítač použil nůžky");

                            }

                            else
                            {
                                Console.WriteLine(tah + " není možnost, použij prosím kámen, nůžky nebo papír.");

                            }
                            break;

                        case (2)://papir
                            if (tah == '#')
                            {
                                Console.WriteLine("Prohrál jsi! Počítač použil papír");
                            }
                            else if (tah == '-')
                            {
                                Console.WriteLine("Znovu! Počítač použil papír");
                            }
                            else if (tah == 'V')
                            {
                                Console.WriteLine("Vyhrál jsi! Počítač použil papír");
                                pocetVyher += 1;
                            }
                            else
                            {
                                Console.WriteLine(tah + " není možnost, použij prosím kámen, nůžky nebo papír.");

                            }

                            break;


                    }
                    Console.WriteLine();
                    Console.WriteLine("Už jsi vyhrál " + pocetVyher + "krát!");
                    Console.WriteLine();
                    Console.WriteLine("Pro pokračování zmáčkni klávesu");

                    Console.ReadKey();
                    Console.Clear();

                }

                catch
                {

                    Console.WriteLine("Použij kámen, nůžky nebo papír.");
                    Console.WriteLine("Pro pokračování zmáčkni klávesu");

                    Console.ReadKey();
                    Console.Clear();

                }
            }
        }
    }
}
