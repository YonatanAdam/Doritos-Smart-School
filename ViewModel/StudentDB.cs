using SmartSchool_YAS;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ViewModel
{
    public class StudentDB : PeopleDB
    {
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Student student = entity as Student;
            base.CreateModel(student);
            return student;
        }

        protected override BaseEntity newEntity()
        {
            return new Student() as BaseEntity;
        }

        public StudentsList SelectAll()
        {
            command.CommandText = "SELECT *, PeopleTbl.ID as ID FROM (PeopleTbl " + "INNER JOIN StudentTbl ON PeopleTbl.ID = StudentTbl.ID)";
            StudentsList studentsList = new StudentsList(base.Select());
            return studentsList;
        }

        public StudentsList SelectByName(string firstName, string lastName)
        {
            command.CommandText = string.Format($"SELECT *, PeopleTbl.ID as ID FROM (PeopleTbl " +
                "INNER JOIN StudentsTbl ON PeopleTbl.ID = StudentTbl.ID) " +
                "WHERE FirstName='{0}' AND LastName='{1}'", firstName,lastName);

            List<Student> studentsList = base.Select().Cast<Student>().ToList();
            
            return new StudentsList(studentsList);
        }

        public Student SelectById(int id)
        {
            command.CommandText = "SELECT *, PeopleTbl.ID as ID FROM (PeopleTbl " +
                "INNER JOIN StudnetTbl ON PeopleTbl.ID = StudentTbl.ID) " +
                $"WHERE PeopleTbl.ID={id}";

            List<BaseEntity> studentsList = base.Select();
            if (studentsList.Count == 1)
            {
                return studentsList[0] as Student;
            }

            return null;
        }
    }
}
