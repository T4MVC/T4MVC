using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace T4MVCHostMvcApp.Controllers
{
    public class UnbindModel {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class BaseEntity {
        public int Id { get; set; }
    }

    public class UserEntity : BaseEntity {
        public string Login { get; set; }
    }

    public class AnotherChildEntity : BaseEntity {
        public string Name { get; set; }
    }
    public interface IComplexModel { }

    public class ComplexModel : IComplexModel {
        public BaseEntity One { get; set; }
        public BaseEntity Two { get; set; }
        public string Three { get; set; }
    }

    public class ComplexModelWithEnumerable : IComplexModel {
        public BaseEntity[] One { get; set; }
        public string String { get; set; }
        public List<int> Ints { get; set; }
    }

    public class UnbindModelUnbinder : IModelUnbinder<UnbindModel> {
        public void UnbindModel(RouteValueDictionary routeValueDictionary, string routeName, UnbindModel routeValue) {
            if (routeValue != null)
                routeValueDictionary.Add(routeName, routeValue.Id);
        }
    }
    public class BaseEntityUnbinder : IModelUnbinder<BaseEntity> {
        public void UnbindModel(RouteValueDictionary routeValueDictionary, string routeName, BaseEntity routeValue) {
            if (routeValue != null)
                routeValueDictionary.Add(routeName, routeValue.Id);
        }
    }

    public class UserEntityUnbinder : IModelUnbinder<UserEntity> {
        public void UnbindModel(RouteValueDictionary routeValueDictionary, string routeName, UserEntity routeValue) {
            if (routeValue != null)
                routeValueDictionary.Add(routeName, routeValue.Login);
        }
    }

    public partial class ModelUnbinderController : Controller
    {

        public virtual ActionResult TestUnbindModel(UnbindModel model) {
            return View();
        }
        public virtual ActionResult TestBaseClass(BaseEntity entity) {
            return View();
        }
        public virtual ActionResult TestChildClass1(UserEntity user) {
            return View();
        }
        public virtual ActionResult TestChildClass2(AnotherChildEntity child) {
            return View();
        }
        public virtual ActionResult TestComplexModel(ComplexModel model) {
            return View();
        }
        public virtual ActionResult TestComplexModelWithEnumerable(ComplexModelWithEnumerable model) {
            return View();
        }
        public virtual ActionResult ParameterlessAction() {
            return View();
        }
    }
}
