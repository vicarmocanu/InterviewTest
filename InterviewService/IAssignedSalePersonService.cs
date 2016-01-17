using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace InterviewService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAssignedSalePersonService" in both code and config file together.
    [ServiceContract]
    public interface IAssignedSalePersonService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "assignSalePerson", BodyStyle = WebMessageBodyStyle.Wrapped)]
        int assignSalePerson(int salePersonId, int districtId);

        [OperationContract]
        [WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, RequestFormat =WebMessageFormat.Json, UriTemplate = "deleteAssignedPerson/?salePersonId={salePersonId}")]
        int deleteAssignedPerson(int salePersonId);
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
