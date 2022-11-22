using System;

namespace Exercitiu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti propozitia:");

            char[] caractere = Console.ReadLine().ToCharArray();
            int vocale = 0;
            int consoane = 0;
            int index = 0;

            while (index < caractere.Length)
            {
                if (Char.IsLetter(caractere[index]))
                {
                    switch (caractere[index])
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            vocale++;
                            break;
                        default:
                            consoane++;
                            break;
                    }
                }
                index++;
            }

            Console.WriteLine("Numarul de caractere este {0}", caractere.Length);
            Console.WriteLine("Numarul de consoane este {0}", consoane);
            Console.WriteLine("Numarul de vocale este {0}", vocale);

            Console.ReadLine();
        }
    }
}