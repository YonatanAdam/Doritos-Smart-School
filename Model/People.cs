using Model;

namespace SmartSchool_YAS
{
    public class People : BaseEntity
    {
        // private int id;
        private string firstName;
        private string lastName;
        private City city;
        private int telephone;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public City City
        {
            get { return city; }
            set { city = value; }
        }
        public int Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
    }
}
