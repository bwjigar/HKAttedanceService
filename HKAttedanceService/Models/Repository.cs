using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HKAttedanceService.Models
{
    public static class Repository
    {
        public static CommonResponse TransferDataSQLToORA()
        {
            IFormatProvider theCultureInfo = new System.Globalization.CultureInfo("en-GB", true);
            CommonResponse resp = new CommonResponse();
            try
            {
                Database db = new Database();
                List<IDbDataParameter> para;
                para = new List<IDbDataParameter>();
                DataTable dt = db.ExecuteSP("TransferAttendanceDetail_Ora", para.ToArray(), false);

                if (dt != null && dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["Msg"].ToString() == "Success")
                    {
                        resp.Message = "Attendance Transfer Successfully";
                        resp.Status = "1";
                    }
                    else
                    {
                        resp.Message = "Something Went Wrong.";
                        resp.Error = dt.Rows[0]["Msg"].ToString();
                        resp.Status = "0";
                    }
                }
                else
                {
                    resp.Message = "Something Went Wrong.";
                    resp.Error = "Data Not Found";
                    resp.Status = "0";
                }
                return resp;
            }
            catch (Exception ex)
            {
                resp.Message = "Something Went Wrong.";
                resp.Error = ex.Message.ToString();
                resp.Status = "0";
            }
            return resp;
        }
        public static CommonResponse TransferDataSQLToORA7Days()
        {
            IFormatProvider theCultureInfo = new System.Globalization.CultureInfo("en-GB", true);
            CommonResponse resp = new CommonResponse();
            try
            {
                Database db = new Database();
                List<IDbDataParameter> para;
                para = new List<IDbDataParameter>();
                DataTable dt = db.ExecuteSP("TransferAttendanceDetail_7Days_Ora", para.ToArray(), false);

                if (dt != null && dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["Msg"].ToString() == "Success")
                    {
                        resp.Message = "Attendance Transfer Successfully";
                        resp.Status = "1";
                    }
                    else
                    {
                        resp.Message = "Something Went Wrong.";
                        resp.Error = dt.Rows[0]["Msg"].ToString();
                        resp.Status = "0";
                    }
                }
                else
                {
                    resp.Message = "Something Went Wrong.";
                    resp.Error = "Data Not Found";
                    resp.Status = "0";
                }
                return resp;
            }
            catch (Exception ex)
            {
                resp.Message = "Something Went Wrong.";
                resp.Error = ex.Message.ToString();
                resp.Status = "0";
            }
            return resp;
        }
    }
}