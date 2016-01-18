using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace InterviewServices
{
    [ServiceContract]
    public interface IDistrictService
    {
        [OperationContract]
        [WebInvoke(Method = "POST",ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "addDistrict/?districtId={districtId}&primarySalepersonId={primarySalePersonId}/{name}", BodyStyle = WebMessageBodyStyle.Wrapped)]
        void addDistrict(int districtId, int primarySalePersonId, string name);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAllDistricts/", ResponseFormat = WebMessageFormat.Json)] //DAFQ!?
        List<District> getAllDistricts();

        [OperationContract]
        [WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json, UriTemplate = "changePrimarySalePerson/?districtId={districtId}&?primeSalePersId={primeSalePersId}", BodyStyle = WebMessageBodyStyle.Bare)] // dafq?
        void changePrimarySalesPerson(int districtId, int primeSalePersId);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "getDistrictSalePersons/?districtid={districtId}")] //OKY
        List<SalePerson> getDistrictSalePersons(int districtId);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "getStoresOnDistrict/?districtid={districtId}")] //OKY
        List<Store> getStoresOnDistrict(int districtId);
    }

    [DataContract]
    public class District
    {
        private int districtId;
        private int primSalePersonId;
        private string name;

        [DataMemberAttribute]
        public int DistrictId
        {
            get
            {
                return districtId;
            }

            set
            {
                districtId = value;
            }
        }

        [DataMemberAttribute]
        public int PrimSalePersId
        {
            get
            {
                return primSalePersonId;
            }

            set
            {
                primSalePersonId = value;
            }
        }

        [DataMemberAttribute]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }

    [DataContract]
    public class SalePerson
    {
        private int id;
        private string lastName;
        private string firstName;
        private string userName;
        private string pass;
        private string email;
        private int phoneNo;

        [DataMemberAttribute]
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        [DataMemberAttribute]
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        [DataMemberAttribute]
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        [DataMemberAttribute]
        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        [DataMemberAttribute]
        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        [DataMemberAttribute]
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        [DataMemberAttribute]
        public int PhoneNo
        {
            get
            {
                return phoneNo;
            }

            set
            {
                phoneNo = value;
            }
        }
    }

    [DataContract]
    public class Store
    {
        private int storeId;
        private int districtId;
        private string name;

        [DataMemberAttribute]
        public int StoreId
        {
            get
            {
                return storeId;
            }

            set
            {
                storeId = value;
            }
        }

        [DataMemberAttribute]
        public int DistrictId
        {
            get
            {
                return districtId;
            }

            set
            {
                districtId = value;
            }
        }

        [DataMemberAttribute]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}