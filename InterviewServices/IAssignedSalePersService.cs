using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace InterviewServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAssignedSalePersService" in both code and config file together.
    [ServiceContract]
    public interface IAssignedSalePersService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "assignSalePerson/?salePersonId={salePersonid}&districtId={districtId}", BodyStyle = WebMessageBodyStyle.Wrapped)]
        void assignSalePerson(int salePersonId, int districtId);

        [OperationContract]

        [WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "deleteAssignedPerson/?salePersonId={salePersonId}")]
        void deleteAssignedPerson(int salePersonId);
    }

    [DataContract]
    public class AsssignedSalePerson
    {
        private int salePersonId;
        private int districtId;

        [DataMemberAttribute]
        public int SalePersonId
        {
            get
            {
                return salePersonId;
            }

            set
            {
                salePersonId = value;
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
    }
}