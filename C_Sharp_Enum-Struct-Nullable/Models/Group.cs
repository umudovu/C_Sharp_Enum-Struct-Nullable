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
                if (!(value>4 || value<19))
                {
                    System.Console.WriteLine("Student limit can be a minimum of 5 and a maximum of 18");
                    return;
                }
                _studentlimit = value;
            }
        }


        private Student[] _students = new Student[_studentlimit];

        public Student Students
        {
            get
            {
                return _students[_studentlimit];
            }
            set
            {
                for (int i = 0; i < _studentlimit; i++)
                {
                    _students[i]=new Student(FullName, Point);
                }
            }
        }

        public Group(string fullname, int point, int groupno, int studentlimit) : base(fullname, point)
        {
            GroupNo = groupno;
            StudentLimit = studentlimit;
        }

    }
}
