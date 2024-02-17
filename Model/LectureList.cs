using SmartSchool_YAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LectureList : List<Lecture>
    {
        public LectureList() { }
        public LectureList(IEnumerable<Lecture> list) : base(list) { }
        public LectureList(IEnumerable<BaseEntity> list) : base(list.Cast<Lecture>().ToList()) { }
    }
}
