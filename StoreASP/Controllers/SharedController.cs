using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace StoreASP.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        public JsonResult UploadImage()
        {   
            JsonResult result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            try
            {
                var file = Request.Files[0];
                var filename = Guid.NewGuid() + Path.GetExtension(file.FileName);
                var path = Path.Combine(Server.MapPath("~/PublicFront/CategoryImage"), filename);  // şəkil hara yüklənəcək
                file.SaveAs(path);
                result.Data = new { Success = true, ImageUrl = string.Format("/PublicFront/CategoryImage/{0}", filename) };
            }
            catch (Exception ex)
            {
                result.Data = new { success = false, Message = ex.Message };  // hazır formada mesaj göndərir
            }
            return result; 
        }
    }
}