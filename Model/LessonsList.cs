using System.Collections.Generic;
using System.Linq;

namespace SmartSchool_YAS
{
    internal class LessonsList : List<Lesson>
    {
        public LessonsList() { }

        public LessonsList(IEnumerable<Lesson> list) : base(list) { }
        public LessonsList(IEnumerable<BaseEntity> list) : base(list.Cast<Lesson>().ToList()) { }

        public List<Lesson> OrderByGrade()
        {
            if (Count > 0)
            {
                return this.OrderBy(item => item.Grade).ToList();
            }
            return null;
        }
    }
}
