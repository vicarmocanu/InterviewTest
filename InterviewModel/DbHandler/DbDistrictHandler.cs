using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewModel;
using InterviewModel.Model;
using System.Data;

namespace InterviewModel.DbHandler
{
    class DbDistrictHandler
    {
        private static SqlCommand dbCmd = null;
        private static SqlParameter parmSalePersonId = new SqlParameter("@salePersonId", SqlDbType.Int);
        private static SqlParameter parmDistrictId = new SqlParameter("@districtId", SqlDbType.Int);

        private static AssignedSalePerson createSecondarySalePerson(IDataReader dbReader)
        {
            AssignedSalePerson assignedSaleperson = new AssignedSalePerson();

            assignedSaleperson.SalePersonId = Convert.ToInt32(dbReader["salePersonId"].ToString());
            assignedSaleperson.DistrictId = Convert.ToInt32(dbReader["districtId"].ToString());

            return assignedSaleperson;
        }


        //Insert Assigned Sale Person
        public int assignSecondarySalePerson(int salePersonId, int districtId)
        {
            int result = -1;
            dbCmd = new SqlCommand();
            string sqlQuery = "INSERT INTO SecondarySalePerson(salePersonId, districtId) VALUES " +
                "(@salePersonId, @districtId)";
            dbCmd = DbConnection.GetDbCommand(sqlQuery);

            parmSalePersonId.Value = salePersonId;
            dbCmd.Parameters.Add(parmSalePersonId);

            parmDistrictId.Value = districtId;
            dbCmd.Parameters.Add(parmDistrictId);

            try
            {
                result = dbCmd.ExecuteNonQuery();
                dbCmd.Parameters.Clear();
                DbConnection.Close();
            }
            catch (SqlException)
            { }

            return result;
        }

        public int deleteAssignedPerson(int salePersonId)
        {
            int result = -1;
            dbCmd = new SqlCommand();
            string sqlQuery = "DELETE FROM AssignedSalesPerson WHERE salespersonId = @salePersonId";
            dbCmd = DbConnection.GetDbCommand(sqlQuery);

            parmSalePersonId.Value = salePersonId;
            dbCmd.Parameters.Add(parmSalePersonId);

            try
            {
                result = dbCmd.ExecuteNonQuery();
                dbCmd.Parameters.Clear();
                DbConnection.Close();
            }
            catch (SqlException)
            { }

            return result;
        }
    }
}
