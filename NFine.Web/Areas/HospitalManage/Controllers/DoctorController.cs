
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NFine.Domain.ViewModel;

namespace NFine.Web.Areas.HospitalManage.Controllers
{
    public class DoctorController : ControllerBase
    {
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(DoctorViewModel model, string permissionIds, string keyValue)
        {
           // roleApp.SubmitForm(roleEntity, permissionIds.Split(','), keyValue);
            return Success("操作成功。");
        }
    }
}
