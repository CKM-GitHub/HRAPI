﻿using CKM_CommonFunction;
using CKM_DataLayer;
using HRAPI_Model;
using System.Data.SqlClient;

namespace Staff_BL
{
    public class StaffBL
    {
        CKMDL cKMDL;
        FileFunction ff;
        public StaffBL()
        {
            cKMDL = new CKMDL();
            ff = new FileFunction();
        }
        public string GetStaffLogin(StaffModel staffModel)
        {
            staffModel.Sqlprms = new SqlParameter[2];
            staffModel.Sqlprms[0] = new SqlParameter("@LoginName", staffModel.LoginName);
            staffModel.Sqlprms[1] = new SqlParameter("@EmployeeName", staffModel.Password);
            return cKMDL.SelectJson("Staff_LoginSelect", ff.GetConnectionWithDefaultPath("HRAPI"), staffModel.Sqlprms);
        }
    }
}