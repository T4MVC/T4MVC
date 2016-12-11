using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T4MVCHostMvcApp.Controllers
{
    /*
     * NimbleText template:
     
[RoutePrefix( "controller-$0" )]
public class Ctrl$0Controller : Controller
{
    [Route( "items-list" )]
    public ActionResult Index()
    {
        return View();
    }

    [Route( "item-details/{id:long}" )]
    public ActionResult Details( long id )
    {
        return View();
    }

    [HttpGet]
    [Route( "create-item" )]
    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [Route( "create-item" )]
    public ActionResult Create( string data )
    {
        return View();
    }
    
    [HttpGet]
    [Route( "edit-item/{id:long}" )]
    public ActionResult Edit( long id )
    {
        return View();
    }

    [HttpPost]
    [Route( "edit-item/{id:long}" )]
    public ActionResult Edit( long id, string data )
    {
        return View();
    }
    
    [HttpGet]
    [Route( "delete-item/{id:long}" )]
    public ActionResult Delete( long id )
    {
        return View();
    }
    
    [HttpGet]
    [Route( "other-action" )]
    public ActionResult OtherAction( long id )
    {
        return View();
    }
}


*/
    [RoutePrefix( "controller-1" )]
    public partial class Ctrl1Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-2" )]
    public partial class Ctrl2Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-3" )]
    public partial class Ctrl3Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-4" )]
    public partial class Ctrl4Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-5" )]
    public partial class Ctrl5Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-6" )]
    public partial class Ctrl6Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-7" )]
    public partial class Ctrl7Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-8" )]
    public partial class Ctrl8Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-9" )]
    public partial class Ctrl9Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-10" )]
    public partial class Ctrl10Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-11" )]
    public partial class Ctrl11Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-12" )]
    public partial class Ctrl12Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-13" )]
    public partial class Ctrl13Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-14" )]
    public partial class Ctrl14Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-15" )]
    public partial class Ctrl15Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-16" )]
    public partial class Ctrl16Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-17" )]
    public partial class Ctrl17Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-18" )]
    public partial class Ctrl18Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-19" )]
    public partial class Ctrl19Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-20" )]
    public partial class Ctrl20Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-21" )]
    public partial class Ctrl21Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-22" )]
    public partial class Ctrl22Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-23" )]
    public partial class Ctrl23Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-24" )]
    public partial class Ctrl24Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-25" )]
    public partial class Ctrl25Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-26" )]
    public partial class Ctrl26Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-27" )]
    public partial class Ctrl27Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-28" )]
    public partial class Ctrl28Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-29" )]
    public partial class Ctrl29Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-30" )]
    public partial class Ctrl30Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-31" )]
    public partial class Ctrl31Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-32" )]
    public partial class Ctrl32Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-33" )]
    public partial class Ctrl33Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-34" )]
    public partial class Ctrl34Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-35" )]
    public partial class Ctrl35Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-36" )]
    public partial class Ctrl36Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-37" )]
    public partial class Ctrl37Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-38" )]
    public partial class Ctrl38Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-39" )]
    public partial class Ctrl39Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-40" )]
    public partial class Ctrl40Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-41" )]
    public partial class Ctrl41Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-42" )]
    public partial class Ctrl42Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-43" )]
    public partial class Ctrl43Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-44" )]
    public partial class Ctrl44Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-45" )]
    public partial class Ctrl45Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-46" )]
    public partial class Ctrl46Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-47" )]
    public partial class Ctrl47Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-48" )]
    public partial class Ctrl48Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-49" )]
    public partial class Ctrl49Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-50" )]
    public partial class Ctrl50Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-51" )]
    public partial class Ctrl51Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-52" )]
    public partial class Ctrl52Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-53" )]
    public partial class Ctrl53Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-54" )]
    public partial class Ctrl54Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-55" )]
    public partial class Ctrl55Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-56" )]
    public partial class Ctrl56Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-57" )]
    public partial class Ctrl57Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-58" )]
    public partial class Ctrl58Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-59" )]
    public partial class Ctrl59Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-60" )]
    public partial class Ctrl60Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-61" )]
    public partial class Ctrl61Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-62" )]
    public partial class Ctrl62Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-63" )]
    public partial class Ctrl63Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-64" )]
    public partial class Ctrl64Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-65" )]
    public partial class Ctrl65Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-66" )]
    public partial class Ctrl66Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-67" )]
    public partial class Ctrl67Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-68" )]
    public partial class Ctrl68Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-69" )]
    public partial class Ctrl69Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-70" )]
    public partial class Ctrl70Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-71" )]
    public partial class Ctrl71Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-72" )]
    public partial class Ctrl72Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-73" )]
    public partial class Ctrl73Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-74" )]
    public partial class Ctrl74Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-75" )]
    public partial class Ctrl75Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-76" )]
    public partial class Ctrl76Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-77" )]
    public partial class Ctrl77Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-78" )]
    public partial class Ctrl78Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-79" )]
    public partial class Ctrl79Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-80" )]
    public partial class Ctrl80Controller : Controller
    {
        [Route( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Route( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [Route( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [Route( "other-action" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }

    [RoutePrefix( "controller-81" )]
    public partial class Ctrl81Controller : Controller
    {
        [AutoNamedRoute( "items-list" )]
        public virtual ActionResult Index()
        {
            return View();
        }

        [AutoNamedRoute( "item-details/{id:long}" )]
        public virtual ActionResult Details( long id )
        {
            return View();
        }

        [HttpGet]
        [AutoNamedRoute( "create-item" )]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        // cannot use in POST the same route name as in GET because we will have duplicated route names
        //[AutoNamedRoute( "create-item" )]
        [Route( "create-item" )]
        public virtual ActionResult Create( string data )
        {
            return View();
        }

        [HttpGet]
        [AutoNamedRoute( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id )
        {
            return View();
        }

        [HttpPost]
        //[AutoNamedRoute( "edit-item/{id:long}" )]
        [Route( "edit-item/{id:long}" )]
        public virtual ActionResult Edit( long id, string data )
        {
            return View();
        }

        [HttpGet]
        [AutoNamedRoute( "delete-item/{id:long}" )]
        public virtual ActionResult Delete( long id )
        {
            return View();
        }

        [HttpGet]
        [AutoNamedRoute( "other-action/{id:long}" )]
        public virtual ActionResult OtherAction( long id )
        {
            return View();
        }
    }
}