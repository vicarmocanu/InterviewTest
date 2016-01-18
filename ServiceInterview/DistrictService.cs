using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using InterviewModel.Controller;
using InterviewModel.Model;

namespace ServiceInterview
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DistrictService" in both code and config file together.
    public class DistrictService : IDistrictService
    {
     private static DistrictCtr districtCtr = DistrictCtr.getInstance();

        private static readonly System.Object obj1 = new System.Object();
        private static readonly System.Object obj2 = new System.Object();
        private static readonly System.Object obj3 = new System.Object();
        private static readonly System.Object obj4 = new System.Object();
        private static readonly System.Object obj5 = new System.Object();

        public void addDistrict(int districtid, int primSalePersId, string name)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 45000))
            {
                try
                {
                    districtCtr.addDistrict(districtid, primSalePersId, name);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }

        public void changePrimarySalesPerson(int districtid, int primeSalePersId)
        {

            if (System.Threading.Monitor.TryEnter(obj2, 45000))
            {
                try
                {
                    districtCtr.changePrimarySalesPerson(districtid, primeSalePersId);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }
        }

        public List<District> getAllDistricts()
        {
            List<District> districtList = new List<District>();

            if (System.Threading.Monitor.TryEnter(obj3, 45000))
            {
                try
                {
                    List<District> returnList = districtCtr.getAllDistricts();

                    if (returnList.Count != 0)
                    {
                        foreach (District districtHost in returnList)
                        {
                            District districtService = new District();

                            districtService.DistrictId = districtHost.DistrictId;
                            districtService.PrimSalePersonId = districtHost.PrimSalePersonId;
                            districtService.Name = districtHost.Name;

                            districtList.Add(districtService);
                        }
                    }
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj3);
                }
            }

            return districtList;
        }

        public List<SalePerson> getDistrictSalePersons(int districtId)
        {
            List<SalePerson> salePerson = new List<SalePerson>();

            if (System.Threading.Monitor.TryEnter(obj4, 10000))
            {
                try
                {
                    List<SalePerson> returnList = districtCtr.getDistrictSalePersons(districtId);

                    if (returnList.Count != 0)
                    {
                        foreach (SalePerson salePersonHost in returnList)
                        {
                            SalePerson serviceSalePerson = new SalePerson();

                            serviceSalePerson.Id = salePersonHost.Id;
                            serviceSalePerson.LastName = salePersonHost.LastName;
                            serviceSalePerson.FirstName = salePersonHost.FirstName;
                            serviceSalePerson.Email = salePersonHost.Email;
                            serviceSalePerson.PhoneNo = salePersonHost.PhoneNo;

                            salePerson.Add(serviceSalePerson);
                        }
                    }
                }
                catch (NullReferenceException) { }
                finally
                {
                    System.Threading.Monitor.Exit(obj4);
                }
            }
            return salePerson;
        }

        public List<Store> getStoresOnDistrict(int districtId)
        {
            List<Store> store = new List<Store>();

            if (System.Threading.Monitor.TryEnter(obj5, 10000))
            {
                try
                {
                    List<Store> returnList = districtCtr.getStoresOnDistrict(districtId);

                    if (returnList.Count != 0)
                    {
                        foreach (Store storeHost in returnList)
                        {
                            Store serviceStore = new Store();

                            serviceStore.StoreId = storeHost.StoreId;
                            serviceStore.Name = storeHost.Name;

                            store.Add(serviceStore);
                        }
                    }
                }
                catch (NullReferenceException) { }
                finally
                {
                    System.Threading.Monitor.Exit(obj5);
                }
            }
            return store;
        }
    }
}
