using System;

namespace PalindromeFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitflag = false;

            while (exitflag != true)
            {
                Console.WriteLine("************************************");
                Console.WriteLine("Yapmak isteginiz aksiyon icin tuşa basiniz (p: Palindrome, f: Factorial, q:Quit) ");
                string action = Console.ReadLine();

                // Switch-Case (which action will be implemeted according to user)
                switch (action)
                {
                    case "p":
                        Console.WriteLine("Lütfen kelime giriniz: ");
                        string sentence = Console.ReadLine();
                        isPalindorme(sentence);
                        break;

                    case "f":

                        Console.WriteLine("Lütfen Sayi giriniz: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        int fac = factorial(number);
                        Console.WriteLine("Faktöriyel sonucu: " + fac + "\n");
                        break;


                    case "q":
                        exitflag = true;
                        break;

                    default:
                        Console.WriteLine("Yalnis tusa bastiniz tekrar deneyiniz !! ");
                        break;
                }

            }

            //Methods
            void isPalindorme(string sentence)
            {
                if (sentence.Length >= 2)
                {

                    for (int i = 0; i < (sentence.Length) / 2; i++)
                    {

                        if (sentence[i] != sentence[sentence.Length - i - 1])
                        {

                            Console.WriteLine("Girdiğiniz kelime palindrom değildir.\n");
                            return;
                        }

                    }
                    Console.WriteLine("Girdiğiniz kelime palindromdur. \n");
                }

                else
                {
                    Console.WriteLine("Girdiginiz kelime en az 2 karakterli olmalidir \n");

                }
            }


            static int factorial(int number)
            {
                if (number == 0)
                {

                    return 1;
                }
                int result = 1;
                int i = number;

                while (number / i != number)
                {

                    result = result * i;
                    i--;
                }
                return result;
            }
        }
    }
}
