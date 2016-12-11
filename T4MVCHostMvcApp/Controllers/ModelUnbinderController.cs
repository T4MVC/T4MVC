﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using System.Web.Routing;

namespace T4MVCHostMvcApp.Controllers
{
    public class UnbindModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class BaseEntity
    {
        public int Id { get; set; }
    }

    public class UserEntity : BaseEntity
    {
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Login")]
        public string Login { get; set; }
    }

    public class AnotherChildEntity : BaseEntity
    {
        public string Name { get; set; }
    }
    [SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces")]
    public interface IComplexModel { }

    public class ComplexModel : IComplexModel
    {
        public BaseEntity One { get; set; }
        public BaseEntity Two { get; set; }
        public string Three { get; set; }
    }

    public class ComplexModelWithEnumerable : IComplexModel
    {
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public BaseEntity[] One { get; set; }
        public string String { get; set; }
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Ints"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public List<int> Ints { get; set; }
    }

    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Unbinder")]
    public class UnbindModelUnbinder : IModelUnbinder<UnbindModel>
    {
        [SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
        public void UnbindModel(RouteValueDictionary routeValueDictionary, string routeName, UnbindModel routeValue)
        {
            if (routeValue != null)
                routeValueDictionary.Add(routeName, routeValue.Id);
        }
    }
    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Unbinder")]
    public class BaseEntityUnbinder : IModelUnbinder<BaseEntity>
    {
        [SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
        public void UnbindModel(RouteValueDictionary routeValueDictionary, string routeName, BaseEntity routeValue)
        {
            if (routeValue != null)
                routeValueDictionary.Add(routeName, routeValue.Id);
        }
    }

    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Unbinder")]
    public class UserEntityUnbinder : IModelUnbinder<UserEntity>
    {
        [SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
        public void UnbindModel(RouteValueDictionary routeValueDictionary, string routeName, UserEntity routeValue)
        {
            if (routeValue != null)
                routeValueDictionary.Add(routeName, routeValue.Login);
        }
    }

    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Unbinder")]
    public partial class ModelUnbinderController : Controller
    {

        public virtual ActionResult TestUnbindModel(UnbindModel model)
        {
            return View();
        }
        public virtual ActionResult TestBaseClass(BaseEntity entity)
        {
            return View();
        }
        public virtual ActionResult TestChildClass1(UserEntity user)
        {
            return View();
        }
        public virtual ActionResult TestChildClass2(AnotherChildEntity child)
        {
            return View();
        }
        public virtual ActionResult TestComplexModel(ComplexModel model)
        {
            return View();
        }
        public virtual ActionResult TestComplexModelWithEnumerable(ComplexModelWithEnumerable model)
        {
            return View();
        }
        public virtual ActionResult ParameterlessAction()
        {
            return View();
        }
    }
}
