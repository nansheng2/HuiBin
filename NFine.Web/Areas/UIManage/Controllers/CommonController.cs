using NFine.Application.SystemManage;
using NFine.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.UIManage.Controllers
{
    public class CommonController : ControllerBase
    {
        ItemsDetailApp itemsDetailApp = new ItemsDetailApp();
        //
        // GET: /UIManage/Common/

        public void GetNationality()
        {

            var itemsDetailList = itemsDetailApp.GetItemList("Language");

            if (itemsDetailList != null && itemsDetailList.Any())
            {
                foreach (var info in itemsDetailList)
                {

                }
            }

        }
    }
}
