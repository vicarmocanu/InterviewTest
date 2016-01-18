using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<District> getAllDistricts();
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

        public int PrimSalePersonId
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
