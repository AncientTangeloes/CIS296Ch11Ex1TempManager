using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.Linq;
using TempManager.Models;

namespace TempManager.Controllers
{
    public class ValidationController : Controller
    {
        private TempManagerContext context;
        public ValidationController(TempManagerContext ctx) => context = ctx;

        public JsonResult CheckDate(string date)
        {
            DateTime dateInput = DateTime.Parse(date);
            var dateCheck = context.Temps.Where(t => t.Date == dateInput).ToList();

            if (dateCheck.Count == 0)
            {
                return Json(true);
            }
            else
            {
                return Json($"{date} already has temps recorded.");
            }
        }
    }
}
