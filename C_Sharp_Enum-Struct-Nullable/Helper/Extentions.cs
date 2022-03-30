using C_Sharp_Enum_Struct_Nullable.Models;
using System;

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

        public static bool FirstTwo(this string groupno)
        {
            bool result = false;

            if (Char.IsUpper(groupno[0])==true && Char.IsUpper(groupno[1])==true)
            {
                result=true;
            }


            return result;
        }

        public static bool LastThree(this string groupno)
        {
            bool result = false;
            if (Char.IsNumber(groupno[2])==true && Char.IsNumber(groupno[3])==true && Char.IsNumber(groupno[4])==true)
            {
                result=true;
            }
            return result;
        }


        


    }
}
