namespace C_Sharp_Enum_Struct_Nullable.Models
{
    internal class Student : User
    {
        public int Point { get; set; }


        public Student(string fullname, int point)
        {
            FullName= fullname;
            Point= point;
        }


    }
}
