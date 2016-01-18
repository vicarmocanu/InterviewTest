using InterviewModel.DbHandler;
using InterviewModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewModel.Controller
{
    public class AssignedSalePersonCtr
    {
        private static AssignedSalePersonCtr instance = null;

        public static AssignedSalePersonCtr getInstance()
        {
            if (instance == null)
            {
                instance = new AssignedSalePersonCtr();
            }
            return instance;
        }

        public AssignedSalePersonCtr() { }

        public void assignSalePerson(int salePersonId, int districtId)
        {
            IAssignedSalePerson _dbAssignedSalePerson = new DbAssignedSalePersonHandler();

            AssignedSalePerson assignedSale = new AssignedSalePerson();
            assignedSale.SalePersonId = salePersonId;
            assignedSale.DistrictId = districtId;
        }

        public void deleteAssignedPerson(int salePersonId)
        {
            IAssignedSalePerson _dbAssignedSalePerson = new DbAssignedSalePersonHandler();
            _dbAssignedSalePerson.deleteAssignedPerson(salePersonId);
        }
    }
}
