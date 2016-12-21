using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;

namespace Hospital.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //Response.Redirect("");
            //Response.RedirectLocation = "";
            return View("../View1");
        }
        public ActionResult GetqueryStr()
        {
            string name = Request.QueryString.Get("namecc"); //获取不到form表单中的值,但是可以获取到超链接中的参数
            string name1 = Request["name"];
            string namecc = Request["namecc"];     //这种方式既可以获得超链接中的参数也可以获取 form表单中的参数
            string age=Request["age"];
            string list=Request["list"];
            string[] arr = list.Split(',');
            ViewData["_arr"] = arr;
            int[] cc = new int[7];
            ArrayList alist = new ArrayList(); // 如果写在return后面就会出现检测到无法访问的代码。
            alist.Add("1");
            return View("../cctest");
           
        }

    }
}
