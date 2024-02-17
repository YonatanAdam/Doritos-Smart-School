namespace SmartSchool_YAS
{
    public class Student : People
    {
        private LessonsList lessonsList;

        //public LessonsList FinishedCourses
        //{
        //    get
        //    {
        //        List<Lesson> lst = this.lessonsList.FindAll(lesson => lesson.Grade > 55).ToList();
        //        return new LessonsList(lst);
        //    }
        //}
    }
}
