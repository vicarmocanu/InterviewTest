using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewModel.Model
{
    public class District
    {
        private int districtId;
        private int primSalePersId;
        private string name;

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

        public int PrimSalePersId
        {
            get
            {
                return primSalePersId;
            }

            set
            {
                primSalePersId = value;
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

        public District() { }
    }
}
