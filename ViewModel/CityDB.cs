using Model;
using SmartSchool_YAS;

namespace ViewModel
{
    public class CityDB : BaseDB
    {
        static private CityList list = null;

        
        public CityList selectAll()
        {
            command.CommandText = "SELECT * FROM CityTbl";
            list = new CityList(Select());
            return list;
        }

        public static City SelectById(int id)
        {
            if (list == null)
            {
                CityDB db = new CityDB();
                list = db.selectAll();
            }

            City city = list.Find(item => item.Id == id);
            return city;
        }

        protected override BaseEntity newEntity()
        {
            return new City() as BaseEntity;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            City city = entity as City;
            city.Id = (int)reader["ID"];
            city.CityName = reader["CityName"].ToString();
            return city;
        }
    }
}
