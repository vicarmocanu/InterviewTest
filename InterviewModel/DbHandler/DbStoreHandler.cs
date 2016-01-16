using InterviewModel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewModel.DbHandler
{
    class DbStoreHandler
    {
        private static SqlCommand dbCmd = null;
        private static SqlParameter parmStoreId = new SqlParameter("@storeId", SqlDbType.Int);
        private static SqlParameter parmDistrictId = new SqlParameter("@districtId", SqlDbType.Int);
        private static SqlParameter parmName = new SqlParameter("@name", SqlDbType.NVarChar, 50);

        private static Store createStore(IDataReader dbReader)
        {
            Store store = new Store();

            store.StoreId = Convert.ToInt32(dbReader["storeId"].ToString());
            store.DistrictId = Convert.ToInt32(dbReader["districtId"].ToString());
            store.Name = dbReader["name"].ToString();

            return store;
        }

        public List<Store> getStoresOnDistrict(int districtId)
        {
            List<Store> returnList = new List<Store>();

            dbCmd = new SqlCommand();
            string sqlQuery = "SELECT * FROM Store WHERE districtId = @districtId";
            dbCmd = DbConnection.GetDbCommand(sqlQuery);

            parmDistrictId.Value = districtId;
            dbCmd.Parameters.Add(parmDistrictId);

            IDataReader dbReader;
            dbReader = dbCmd.ExecuteReader();

            while (dbReader.Read())
            {
                Store store = new Store();
                store = createStore(dbReader);
                returnList.Add(store);
            }

            dbCmd.Parameters.Clear();
            DbConnection.Close();

            return returnList;
        }
    }
}
