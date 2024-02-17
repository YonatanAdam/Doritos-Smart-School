using SmartSchool_YAS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Reflection;

namespace ViewModel
{
    public abstract class BaseDB
    {
        private string connectionString;
        protected OleDbConnection connection;
        protected OleDbCommand command;
        protected OleDbDataReader reader;

        protected abstract BaseEntity newEntity();

        protected abstract BaseEntity CreateModel(BaseEntity entity);

        private static string Path()
        {
            string[] arguments = Environment.GetCommandLineArgs();
            string s;
            if (arguments.Length == 1)
            {
                s = arguments[0];
            }
            else
            {
                s = arguments[1];
                s = s.Replace("/Service:", "");
            }
            string[] ss = s.Split('\\');
            int x = ss.Length - 4;
            ss[x] = "ViewModel";
            ss[x + 1] = ""; // לבדוק!!
            Array.Resize(ref ss, x + 2);

            string str = string.Join("\\", ss);
            return str;
        }


        public BaseDB()
        {
            if (connectionString == null)
            {
                connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path() + "YonatanDB2.accdb;Persist Security Info=True";
            }
            connection = new OleDbConnection(connectionString);
            command = new OleDbCommand();
        }
        protected List<BaseEntity> Select()
        {
            List<BaseEntity> list = new List<BaseEntity>();

            try
            {
                command.Connection = connection;
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    BaseEntity entity = newEntity();
                    list.Add(CreateModel(entity));
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message + "\nSQL" + command.CommandText);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return list;
        }

    }
}
