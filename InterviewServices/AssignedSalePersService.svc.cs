using InterviewModel.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InterviewServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AssignedSalePersService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AssignedSalePersService.svc or AssignedSalePersService.svc.cs at the Solution Explorer and start debugging.
    public class AssignedSalePersService : IAssignedSalePersService
    {
        private static AssignedSalePersonCtr assignedCtr = AssignedSalePersonCtr.getInstance();

        public void assignSalePerson(int salePersonId, int districtId)
        {
           
                    assignedCtr.assignSalePerson(salePersonId, districtId);
        }

        public void deleteAssignedPerson(int salePersonId)
        {

                    assignedCtr.deleteAssignedPerson(salePersonId);
        }
    }
}
