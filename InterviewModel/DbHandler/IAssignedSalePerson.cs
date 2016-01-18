using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewModel.DbHandler
{
    interface IAssignedSalePerson
    {
        void assignSalePerson(int salePersonId, int districtId);
        void deleteAssignedPerson(int salePersonId);
    }
}
