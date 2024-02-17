using System.Collections.Generic;
using System.Linq;

namespace SmartSchool_YAS
{
    public class StudentsList : List<Student>
    {
        public StudentsList() { }

        public StudentsList(IEnumerable<Student> list) : base(list) { }
        public StudentsList(IEnumerable<BaseEntity> list) : base(list.Cast<Student>().ToList()) { }
    }
}
