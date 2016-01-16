using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InterviewService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AssignedSalePersonService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AssignedSalePersonService.svc or AssignedSalePersonService.svc.cs at the Solution Explorer and start debugging.
    public class AssignedSalePersonService : IAssignedSalePersonService
    {
        public int assignSalePerson(int salePersonId, int districtId)
        {

        }

        public int deleteAssignedPerson(int salePersonId)
        {

        }
    }
}
