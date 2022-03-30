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

            int point = GetMetodInt("Enter the point: ");

            string email = GetMetodString("Enter the e-mail: ");

            string password = GetMetodString("Enter the password: ");


            User users = new User()
            {
                FullName= fullname,
                Email=email,
                Password=password,
                
            };


            int select = GetMetodInt("Seleckt: \n" +
                "1. Show info \n" +
                "2. Create new group", 1, 2);

            switch (select)
            {
                case 1:
                    users.ShowInfo();
                    break;
                    case 2:
                    Console.Clear();

            }



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

        static int GetMetodInt(string desc, int min = int.MinValue, int max = int.MaxValue)
        {
            int input;
            do
            {
                Console.Write(desc);
                input = int.Parse(Console.ReadLine());

            } while (input<=min || input>max);
            return input;
        }
    }
}
