using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using InterviewModel.Controller;

namespace InterviewServices
{
    public class DistrictService : IDistrictService
    {
        private static DistrictCtr districtCtr = DistrictCtr.getInstance();

        public void addDistrict(int districtid, int primSalePersId, string name)
        {
            
                    districtCtr.addDistrict(districtid, primSalePersId, name);
        }

        public void changePrimarySalesPerson(int districtid, int primeSalePersId)
        {

                    districtCtr.changePrimarySalesPerson(districtid, primeSalePersId);
        }

        public List<District> getAllDistricts()
        {
            List<District> districtList = new List<District>();

            List<InterviewModel.Model.District> returnList = districtCtr.getAllDistricts();

            if (returnList.Count != 0)
            {
                foreach (InterviewModel.Model.District districtHost in returnList)
                {
                    District districtService = new District();

                    districtService.DistrictId = districtHost.DistrictId;
                    districtService.PrimSalePersId = districtHost.PrimSalePersId;
                    districtService.Name = districtHost.Name;

                    districtList.Add(districtService);
                }
            }
            return districtList;
        }

        public List<SalePerson> getDistrictSalePersons(int districtId)
        {
            List<SalePerson> salePerson = new List<SalePerson>();

            List<InterviewModel.Model.SalePerson> returnList = districtCtr.getDistrictSalePersons(districtId);

                    if (returnList.Count != 0)
                    {
                        foreach (InterviewModel.Model.SalePerson salePersonHost in returnList)
                        {
                            SalePerson serviceSalePerson = new SalePerson();

                            serviceSalePerson.Id = salePersonHost.Id;
                            serviceSalePerson.LastName = salePersonHost.LastName;
                            serviceSalePerson.FirstName = salePersonHost.FirstName;
                            serviceSalePerson.Email = salePersonHost.Email;
                            serviceSalePerson.UserName = salePersonHost.UserName;
                            serviceSalePerson.Pass = salePersonHost.Pass;
                            serviceSalePerson.PhoneNo = salePersonHost.PhoneNo;

                            salePerson.Add(serviceSalePerson);
                        }
                }
            return salePerson;
        }

        public List<Store> getStoresOnDistrict(int districtId)
        {
            List<Store> store = new List<Store>();

            List<InterviewModel.Model.Store> returnList = districtCtr.getStoresOnDistrict(districtId);

            if (returnList.Count != 0)
            {
                foreach (InterviewModel.Model.Store storeHost in returnList)
                {
                    Store serviceStore = new Store();

                    serviceStore.StoreId = storeHost.StoreId;
                    serviceStore.Name = storeHost.Name;

                    store.Add(serviceStore);
                }
            }
            return store;
        }
       
    }
}

