namespace SmartSchool_YAS
{
    internal class Lesson : BaseEntity
    {
        // private int ID
        private int lecturer;
        private int student;
        private int course;
        private int grade;


        public int Lecturer
        {
            get { return lecturer; }
            set { lecturer = value; }
        }
        public int Student
        {
            get { return student; }
            set { student = value; }
        }
        public int Course
        {
            get { return course; }
            set { course = value; }
        }
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }


    }
}
