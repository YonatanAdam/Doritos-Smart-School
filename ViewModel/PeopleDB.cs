using SmartSchool_YAS;

namespace ViewModel
{
    public class PeopleDB : BaseDB
    {
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            People people = entity as People;
            people.Id = (int)reader["ID"];
            people.FirstName = reader["FirstName"].ToString();
            people.LastName = reader["LastName"].ToString();
            people.Telephone = (int)reader["Telephone"];
            int city = (int)reader["City"];
            people.City = CityDB.SelectById(city);
            return people;
        }

        protected override BaseEntity newEntity()
        {
            return new People() as BaseEntity;
        }
    }
}
