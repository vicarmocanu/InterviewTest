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
    class DbSalePersonHandler
    {
        private static SqlCommand dbCmd = null;
        private static SqlParameter parmDistrictId = new SqlParameter("@districtId", SqlDbType.Int);
        private static SqlParameter parmPrimeSalePersId = new SqlParameter("@primeSalePersId", SqlDbType.Int);
        private static SqlParameter parmName = new SqlParameter("@name", SqlDbType.NVarChar, 50);

        private static SqlParameter parmId = new SqlParameter("@id", SqlDbType.Int);
        private static SqlParameter parmLastName = new SqlParameter("@lastName", SqlDbType.NVarChar, 50);
        private static SqlParameter parmFirstName = new SqlParameter("@firstName", SqlDbType.NVarChar, 50);
        private static SqlParameter parmUserName = new SqlParameter("@userName", SqlDbType.NVarChar, 50);
        private static SqlParameter parmPass = new SqlParameter("@pass", SqlDbType.NVarChar, 50);
        private static SqlParameter parmEmail = new SqlParameter("@email", SqlDbType.NVarChar, 50);
        private static SqlParameter parmPhoneNo = new SqlParameter("@phoneNo", SqlDbType.Int);

        //create a reservation object based on the data reader
        private static SalePerson createSalePerson(IDataReader dbReader)
        {
            SalePerson salePerson = new SalePerson();

            salePerson.Id = Convert.ToInt32(dbReader["id"].ToString());
            salePerson.LastName = dbReader["lastName"].ToString();
            salePerson.FirstName = dbReader["firstName"].ToString();
            salePerson.UserName = dbReader["userName"].ToString();
            salePerson.Pass = dbReader["pass"].ToString();
            salePerson.Email = dbReader["email"].ToString();
            salePerson.PhoneNo = Convert.ToInt32(dbReader["phoneNo"].ToString());

            return salePerson;
        }

        //needs to go to district !!!!
        public List<SalePerson> getDistrictSalePersons(int districtId)
        {
            List<SalePerson> returnList = new List<SalePerson>();

            dbCmd = new SqlCommand();
            string sqlQuery = "SELECT Saleperson.id, SalePerson.lastName, SalePerson.firstName, SalePerson.email, SalePerson.phoneNo FROM SalePersons" +
                "JOIN SecondarySalePerson ON SalePerson.id = SecondarySalePerson.salePersonId" +
                "JOIN District ON SecondarySalePerson.districtId = District.districtId" +
                "WHERE District.districtId = @districtId";
            dbCmd = DbConnection.GetDbCommand(sqlQuery);

            parmDistrictId.Value = districtId;
            dbCmd.Parameters.Add(parmDistrictId);

            IDataReader dbReader;
            dbReader = dbCmd.ExecuteReader();

            while (dbReader.Read())
            {
                SalePerson salesPerson = new SalePerson();

                salesPerson.Id = Convert.ToInt32(dbReader["id"].ToString());
                salesPerson.LastName = dbReader["lastName"].ToString();
                salesPerson.FirstName = dbReader["firstName"].ToString();
                salesPerson.Email = dbReader["email"].ToString();
                salesPerson.PhoneNo = Convert.ToInt32(dbReader["phoneNo"].ToString());

                returnList.Add(salesPerson);

            }

            dbCmd.Parameters.Clear();
            DbConnection.Close();

            return returnList;

        }
    }
}
