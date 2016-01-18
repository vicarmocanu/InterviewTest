using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using InterviewModel.Controller;

namespace TestServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private static readonly System.Object obj3 = new System.Object();
        private static DistrictCtr districtCtr = DistrictCtr.getInstance();

        public List<District> getAllDistricts()
        {
            List<District> districtList = new List<District>();

            if (System.Threading.Monitor.TryEnter(obj3, 45000))
            {
                try
                {
                    List<InterviewModel.Model.District> returnList = districtCtr.getAllDistricts();

                    if (returnList.Count != 0)
                    {
                        foreach (InterviewModel.Model.District districtHost in returnList)
                        {
                            District districtService = new District();

                            districtService.DistrictId = districtHost.DistrictId;
                            districtService.PrimSalePersonId = districtHost.PrimSalePersId;
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
    }
}
