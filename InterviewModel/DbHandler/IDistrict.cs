using InterviewModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewModel.DbHandler
{
    interface IDistrict
    {
        void addDistrict(District district);
        List<District> getAllDistricts();
        void changePrimarySalesPerson(int districtid, int primeSalePersId);
        List<SalePerson> getDistrictSalePersons(int districtId);
        List<Store> getStoresOnDistrict(int districtId);
    }
}
