using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance
{
    public static class DataService
    {
        public static List<CategoryClass> getAllCategory()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["HomeDBConnectionString"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }
                return db.Query<CategoryClass>("select categoryId, name from Category ORDER BY name ASC").ToList();
            }
        }

        public static List<PartClass> getPartByCategoryID(int cID)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["HomeDBConnectionString"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }
                return db.Query<PartClass>("getPartByCategoryID", new { categoryId = cID }, 
                        commandType:CommandType.StoredProcedure).ToList();
            }
        }
    }
}
