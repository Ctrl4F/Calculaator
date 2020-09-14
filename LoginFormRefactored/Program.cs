using System;

namespace LoginFormRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            string Login;
            string Password;
            Console.WriteLine("Login");
            Login = Console.ReadLine();
            Console.WriteLine("Password");
            Password = Console.ReadLine();
            if (Login == "admin" && Password == "pass1234")
            {
                Console.WriteLine("welcome, admin");
            }
            else
            {
                Console.WriteLine("Login failed. Try again.");
            }
        }
    }
}
