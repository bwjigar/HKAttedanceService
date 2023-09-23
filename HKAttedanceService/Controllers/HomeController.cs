using HKAttedanceService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HKAttedanceService.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult TransferAttendance()
        {
            CommonResponse CR = new CommonResponse();
            try
            {
                CR = Repository.TransferDataSQLToORA();
                CR = Repository.TransferDataSQLToORA7Days();
                return Json(CR, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                CR.Message = "Something Went Wrong.";
                CR.Error = ex.Message.ToString();
                CR.Status = "0";
                return Json(CR, JsonRequestBehavior.AllowGet);
            }
        }
    }
}