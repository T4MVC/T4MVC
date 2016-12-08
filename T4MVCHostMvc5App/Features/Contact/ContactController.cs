using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T4MVCHostMvc5App.Features.Contact
{
    public partial class ContactController : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}
