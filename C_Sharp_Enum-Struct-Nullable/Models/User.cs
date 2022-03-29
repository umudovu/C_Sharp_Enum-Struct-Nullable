using C_Sharp_Enum_Struct_Nullable.Helper;
using C_Sharp_Enum_Struct_Nullable.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Enum_Struct_Nullable.Models
{
    internal class User:IAccount
    {
        private static int Id;


        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }



        public User()
        {
            Id++;
        }

        public bool PasswordChecker(string password)
        {
            bool result;
            if (password.Character()==false || password.IsUpper()==false || password.IsLower()==false || password.IsNumber()==false)
            {
                result = false;
            }
            else
            {
                result=true;
            }
            return result;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"User Id: {Id} \n" +
                $"User Fullname: {FullName} \n" +
                $"User email: {Email}");
        }
    }
}
