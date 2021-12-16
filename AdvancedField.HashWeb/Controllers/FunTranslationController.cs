using AdvancedField.FunTranslation.Model;
using AdvancedField.HashWeb.Data;
using AdvancedField.HashWeb.IServices;
using Core.DatabaseInfrastructure;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedField.HashWeb.Controllers
{
    public class FunTranslationController : Controller
    {
        private readonly IFunTranslationService funTranslationServices;
        private readonly MiddlewareDBContext _context;
        public FunTranslationController(IFunTranslationService funTranslationServices, MiddlewareDBContext _context)
        {
            this.funTranslationServices = funTranslationServices;
            this._context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConvertString(string text)
        {
            FunTranslationResponseModel resp = funTranslationServices.GetConvertedString(text);

            if (resp != null)
            {
                _context.Add(new FunTranslationResult()
                {
                    EventCode = "FunTranslationApiResult",
                    EventTime = DateTime.Now,
                    EventType = "GET",
                    Source = JsonConvert.SerializeObject(resp)
                });
                _context.SaveChanges();
                return Json(resp.Contents.Translated);
            }
            else
            {
                _context.Add(new FunTranslationResult()
                {
                    EventCode = "FunTranslationApiResult Error",
                    EventTime = DateTime.Now,
                    EventType = "GET",
                    Source = String.Format("{0}{1}", "Request ", text)
                });
                _context.SaveChanges();
                return Json("Api is not working!");
            }

        }
    }
}
