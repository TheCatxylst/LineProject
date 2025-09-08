using System;
using System.Linq;

namespace LineProject
{
    internal class Child
    {
        public static void Main()
        {
            int choice = 3;
            /*
            Use 1, 2, or 3
            I was going to add more but I don't know wjat I wanted to say
            and commented multiple lines so this text is here to take up space
            */


            //Btw both take the same time to build
            // Pretty cool


            if (choice == 1)
            {
                // Normal code
                // 9 lines
                // 7 discounting spaces
                Console.WriteLine("Please enter your password\n");

                Console.WriteLine("You have the ability to save the children in my basement");
                Console.WriteLine("Be a good person\n");

                Console.WriteLine("Password: ");
                string password1 = Console.ReadLine();

                Console.WriteLine($"\nThanks for the password, it is {password1}");
                Console.WriteLine("Your local ip is probably 192.168.1.1");
            }
            else if (choice == 2)
            {
                // This is how alphas write code
                // 3 lines
                Console.WriteLine("Please enter your password: \n\nYou have the ability to save the children in my basement\nBe a good person\n\nPassword: ");
                string password2 = Console.ReadLine();
                Console.WriteLine($"\nThanks for the password, it is {password2}\nYour local ip is probably 192.168.1.1");

            }
            else if (choice == 3)
            {
                int i = 0;

                int a = 1;
                int b = 2;
                int c = 3;

                string letter_a = a.ToString();
                string letter_b = b.ToString();
                string letter_c = c.ToString();

                for (i = 0; i <= 9; i++)
                {
                    if (a == 1 & i < 1)
                    {
                        Console.Write(letter_a);
                        continue;
                    }
                    else if (b == 2 & i < 2)
                    {
                        Console.Write(letter_b);
                        continue;
                    }
                    if (c == 3 & i < 3)
                    {
                        Console.Write(letter_c);
                    }
                    else
                    {
                        Console.Write("r");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}
