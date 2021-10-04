using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using TP4.EF.Logic;
using TP4.EF.MVC.Models;

namespace TP4.EF.MVC.Controllers
{
    public class BreakingBadController : Controller
    {
        // GET: Simpsons
        public async Task<ActionResult> Index()
        {   
            var breakingBadAPI = new BreakingBadAPILogic();
            var listBreakingBad = await breakingBadAPI.getBreakingBad();
            List<BreakingBadView> breakingBad = (from item in listBreakingBad
                                              let apiView = new BreakingBadView
                                        {
                                            name = item.name,
                                            //occupation = item.occupation,
                                            nickname = item.nickname,
                                            img = item.img 
                                        }
                                        select apiView).ToList();
            return View(breakingBad);
        }
    }
}