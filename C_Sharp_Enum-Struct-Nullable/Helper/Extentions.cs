using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Enum_Struct_Nullable.Helper
{
    public static class Extentions
    {
        public static bool Character(this string password)
        {
            bool result = true;
            if (password.Length<8)
            {
                result = false;
            }
            else
            {
                result=true;
            }
            return result;
        }

        public static bool IsUpper(this string password)
        {
            bool result = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password[i])==true)
                {
                    result=true;
                }

            }
            return result;
        }

        public static bool IsLower(this string password)
        {
            bool result = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsLower(password[i])==true)
                {
                    result=true;
                }

            }
            return result;
        }

        public static bool IsNumber(this string password)
        {
            bool result = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsNumber(password[i])==true)
                {
                    result=true;
                }

            }
            return result;
        }
    }
}
