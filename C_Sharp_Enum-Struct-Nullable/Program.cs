using C_Sharp_Enum_Struct_Nullable.Models;
using System;
using System.Text.RegularExpressions;

namespace C_Sharp_Enum_Struct_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string fullname = GetMetodString("Enter the fullname: ");

            string email = GetMetodString("Enter the e-mail: ");

            string password = GetMetodString("Enter the password: ");


            User users = new User()
            {
                FullName= fullname,
                Email=email,
                Password=password,
            };

            users.ShowInfo();

            Console.WriteLine(users.PasswordChecker(password));
        }
        static string GetMetodString(string desc, int min = int.MinValue, int max = int.MaxValue)
        {
            string input;
            do
            {
                Console.Write(desc);
                input = Console.ReadLine();

            } while (input.Length<min || input.Length>max);
            return input;
        }
    }
}
