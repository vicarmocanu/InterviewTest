using InterviewModel.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceInterview
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AssignedSalePersonService" in both code and config file together.
    public class AssignedSalePersonService : IAssignedSalePersonService
    {
        private static AssignedSalePersonCtr assignedCtr = AssignedSalePersonCtr.getInstance();

        private static readonly System.Object obj1 = new System.Object();
        private static readonly System.Object obj2 = new System.Object();

        public void assignSalePerson(int salePersonId, int districtId)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 45000))
            {
                try
                {
                    assignedCtr.assignSalePerson(salePersonId, districtId);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }

        public void deleteAssignedPerson(int salePersonId)
        {


            if (System.Threading.Monitor.TryEnter(obj2, 45000))
            {
                try
                {
                    assignedCtr.deleteAssignedPerson(salePersonId);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }

        }
    }
}
