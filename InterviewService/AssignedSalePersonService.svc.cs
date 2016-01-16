using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using InterviewModel.Controller;

namespace InterviewService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AssignedSalePersonService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AssignedSalePersonService.svc or AssignedSalePersonService.svc.cs at the Solution Explorer and start debugging.
    public class AssignedSalePersonService : IAssignedSalePersonService
    {
        private static AssignedSalePersonCtr assignedCtr = AssignedSalePersonCtr.getInstance();

        private static readonly System.Object obj1 = new System.Object();
        private static readonly System.Object obj2 = new System.Object();

        public int assignSalePerson(int salePersonId, int districtId)
        {

            int result = -1;

            if (System.Threading.Monitor.TryEnter(obj1, 45000))
            {
                try
                {
                    result = assignedCtr.assignSalePerson(salePersonId, districtId);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
            return result;
        }

        public int deleteAssignedPerson(int salePersonId)
        {
            int result = -1;

            if (System.Threading.Monitor.TryEnter(obj2, 45000))
            {
                try
                {
                    result = assignedCtr.deleteAssignedPerson(salePersonId);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }

            return result;
        }


    }
}
