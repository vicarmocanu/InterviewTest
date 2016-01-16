using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewModel.Model
{
    class AssignedSalePerson
    {
        private int salePersonId;
        private int districtId;

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

        public AssignedSalePerson() { }
    }
}
