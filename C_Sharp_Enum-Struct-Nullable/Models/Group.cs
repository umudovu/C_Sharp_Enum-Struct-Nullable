using C_Sharp_Enum_Struct_Nullable.Helper;

namespace C_Sharp_Enum_Struct_Nullable.Models
{
    internal class Group : Student
    {
        public int GroupNo { get; set; }

        private static int _studentlimit;

        public int StudentLimit
        {
            get
            {
                return _studentlimit;
            }
            set
            {
                if (value>4 || value<19)
                {
                    _studentlimit = value;
                }
                else
                {
                    System.Console.WriteLine("Student limit can be a minimum of 5 and a maximum of 18");
                }
            }
        }


        public Student[] Students;

        public void AddStudents(Student stu)
        {
            if (Students.Length==_studentlimit)
            {
                Students=new Student[Students.Length];
            }
        }



        public Group(string fullname, int point, int groupno, int studentlimit) : base(fullname, point)
        {
            GroupNo = groupno;
            StudentLimit = studentlimit;
        }


        public bool CheckGroupNo(string groupno)
        {
            bool result = false;
            for (int i = 0; i < groupno.Length; i++)
            {
                if (groupno.Length>=5 && groupno.FirstTwo()==true && groupno.LastThree()==true)
                {
                    result=true;
                }
            }
            return result;
        }

        public Student[] GetAllStudents()
        {
            return new Student[Students.Length];
        }



    }
}
