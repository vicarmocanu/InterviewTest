﻿using InterviewModel.DbHandler;
using InterviewModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewModel.Controller
{
    public class DistrictCtr
    {
        private static DistrictCtr instance = null;

        public static DistrictCtr getInstance()
        {
            if (instance == null)
            {
                instance = new DistrictCtr();
            }
            return instance;
        }

        public DistrictCtr() { }

        public void addDistrict(int districtid, int primSalePersId, string name)
        {

            IDistrict _dbDistrict = new DbDistrictHandler();

            District district = new District();

            district.DistrictId = districtid;
            district.PrimSalePersId = primSalePersId;
            district.Name = name;

           _dbDistrict.addDistrict(district);

        }

        public List<District> getAllDistricts()
        {

            IDistrict _dbDistrict = new DbDistrictHandler();

            List<District> retunrList = new List<District>();

            return retunrList;

        }

        public void changePrimarySalesPerson(int districtid, int primeSalePersId)
        {

            IDistrict _dbDistrict = new DbDistrictHandler();
            District district = new District();

            district.DistrictId = districtid;
            district.PrimSalePersId = primeSalePersId;

            _dbDistrict.changePrimarySalesPerson(districtid, primeSalePersId);
        }

        public List<SalePerson> getDistrictSalePersons(int districtId)
        {

            IDistrict _dbDistrict = new DbDistrictHandler();
            return _dbDistrict.getDistrictSalePersons(districtId);

        }

        public List<Store> getStoresOnDistrict(int districtId)
        {

            IDistrict _dbDistrict = new DbDistrictHandler();
            return _dbDistrict.getStoresOnDistrict(districtId);

        }
    }
}
