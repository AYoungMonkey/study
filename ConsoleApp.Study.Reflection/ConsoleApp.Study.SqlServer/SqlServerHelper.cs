using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using ConsoleApp.Study.Interface;
using ConsoleApp.Study.Model;

namespace ConsoleApp.Study.SqlServer
{
    public class SqlServerHelper : IDBHelper
    {
        public static string Customers = ConfigurationManager.ConnectionStrings["Customers"].ToString();
        public SqlServerHelper()
        {
            Console.WriteLine("{0}被构造", this.GetType().Name);
        }

        public void Query()
        {
            Console.WriteLine("{0} Query", this.GetType().Name);
        }

        /// <summary>
        /// 数据库查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Company Find(int id)
        {
            string sql = @"SELECT * FROM dbo.Company WHERE Id =" + id;

            Type type = typeof(Company);
            object oCompany = Activator.CreateInstance(type);

            using (SqlConnection connection = new SqlConnection(Customers))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read()) // 开始读取
                {
                    //Console.WriteLine(Reader["Id"].ToString());
                    //Console.WriteLine(Reader["Name"].ToString());

                    foreach (PropertyInfo prop in type.GetProperties())
                    {
                        //if (prop.Name.Equals("Id"))
                        //{
                        //    prop.SetValue(oCompany, Reader["Id"], null);
                        //}
                        //else if (prop.Name.Equals("Name"))
                        //{
                        //    prop.SetValue(oCompany, Reader["Name"], null);
                        //}
                        prop.SetValue(oCompany, Reader[prop.Name], null);
                    }
                }
            }
            return oCompany as Company;
        }
        /// <summary>
        /// 泛型方法
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static T Find<T>(int id) where T : BaseModel
        {

            Type type = typeof(T);
            object oCompany = Activator.CreateInstance(type);
            List<string> propNames = type.GetProperties().Select(o => $"[{o.Name}]").ToList();
            string props = string.Join(",", propNames);
            string sql = $"SELECT { props } FROM { $"[{type.Name}]" } WHERE Id =" + id;

            using (SqlConnection connection = new SqlConnection(Customers))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read()) // 开始读取
                {
                    

                    foreach (PropertyInfo prop in type.GetProperties())
                    {
                        prop.SetValue(oCompany, Reader[prop.Name], null);
                    }
                }
            }
            return (T)oCompany;
        }
    }
}
