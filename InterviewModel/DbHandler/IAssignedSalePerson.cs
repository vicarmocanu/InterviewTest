using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewModel.DbHandler
{
    interface IAssignedSalePerson
    {
        int assignSalePerson(int salePersonId, int districtId);
        int deleteAssignedPerson(int salePersonId);
    }
}
