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
    class DbDistrictHandler : IDistrict
    {
        private static SqlCommand dbCmd = null;
        private static SqlParameter parmDistrictId = new SqlParameter("@districtId", SqlDbType.Int);
        private static SqlParameter parmPrimeSalePersId = new SqlParameter("@primeSalePersId", SqlDbType.Int);
        private static SqlParameter parmName = new SqlParameter("@name", SqlDbType.NVarChar, 50);

        private static District createDistrict(IDataReader dbReader)
        {
            District district = new District();

            district.DistrictId = Convert.ToInt32(dbReader["districtId"].ToString());
            district.PrimSalePersId = Convert.ToInt32(dbReader["primSalePersId"].ToString());
            district.Name = dbReader["name"].ToString();

            return district;
        }

        //Insert a new District
        public void addDistrict(District district)
        {
            dbCmd = new SqlCommand();
            string sqlQuery = "INSERT INTO District VALUES " +
                "(@districtId, @primSalePersId, @name)";
            dbCmd = DbConnection.GetDbCommand(sqlQuery);

            parmDistrictId.Value = district.DistrictId;
            dbCmd.Parameters.Add(parmDistrictId);

            parmPrimeSalePersId.Value = district.PrimSalePersId;
            dbCmd.Parameters.Add(parmPrimeSalePersId);

            parmName.Value = district.Name;
            dbCmd.Parameters.Add(parmName);

            try
            {
                dbCmd.Parameters.Clear();
                DbConnection.Close();
            }
            catch (SqlException)
            {

            }
        }

        //Show all Districts
        public List<District> getAllDistricts() // dafq is wrong here?
        {
            List<District> returnList = new List<District>();

            dbCmd = new SqlCommand();
            string sqlQuery = "SELECT * FROM District";
            dbCmd = DbConnection.GetDbCommand(sqlQuery);

            IDataReader dbReader;
            dbReader = dbCmd.ExecuteReader();

            while (dbReader.Read())
            {
                District district = new District();

                district = createDistrict(dbReader);
                returnList.Add(district);

            }

            dbCmd.Parameters.Clear();
            DbConnection.Close();

            return returnList;

        }

        //Change Primary Sale Person
        public void changePrimarySalesPerson(int districtid, int primeSalePersId)
        {
            dbCmd = new SqlCommand();

            string sqlQuery = "UPDATE District SET primSalePersId = @primeSalePersId WHERE districtID = @districtId";
            dbCmd = DbConnection.GetDbCommand(sqlQuery);

            parmDistrictId.Value = districtid;
            dbCmd.Parameters.Add(districtid);

            parmPrimeSalePersId.Value = primeSalePersId;
            dbCmd.Parameters.Add(primeSalePersId);

            try
            {
                dbCmd.Parameters.Clear();
                DbConnection.Close();
            }
            catch (SqlException)
            { }
        }

        //All district Sales Persons
        public List<SalePerson> getDistrictSalePersons(int districtId)
        {
            List<SalePerson> returnList = new List<SalePerson>();

            dbCmd = new SqlCommand();
            string sqlQuery = "SELECT SalesPerson.id, SalesPerson.lastName, SalesPerson.firstName, SalesPerson.userName, SalesPerson.pass, SalesPerson.email, SalesPerson.phoneNo FROM SalesPerson JOIN AssignedSalePerson ON SalesPerson.id = AssignedSalePerson.salePersonId JOIN District ON AssignedSalePerson.districtId = District.districtId WHERE District.districtId = @districtId ";
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
                salesPerson.UserName = dbReader["userName"].ToString();
                salesPerson.Pass = dbReader["pass"].ToString();
                salesPerson.Email = dbReader["email"].ToString();
                salesPerson.PhoneNo = Convert.ToInt32(dbReader["phoneNo"].ToString());

                returnList.Add(salesPerson);

            }

            dbCmd.Parameters.Clear();
            DbConnection.Close();

            return returnList;

        }

        //Get all district Stores
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
                store.StoreId = Convert.ToInt32(dbReader["storeId"].ToString());
                store.DistrictId = Convert.ToInt32(dbReader["districtId"].ToString());
                store.Name = dbReader["name"].ToString();

                returnList.Add(store);
            }

            dbCmd.Parameters.Clear();
            DbConnection.Close();

            return returnList;
        }


    }
}
