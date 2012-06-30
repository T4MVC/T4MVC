using System;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace T4MVCHostMvcApp.Tests {

    [TestClass()]
    public class ModelUnbindersTests {
        private ModelUnbinders _target;

        [TestInitialize()]
        public void Setup() {
            _target = new ModelUnbinders();
        }

        public class TestUnbinder : IModelUnbinder {
            public void UnbindModel(RouteValueDictionary routeValueDictionary, string routeName, object routeValue) {
            }
        }
        public class TestUnbinder2 : IModelUnbinder<BaseClass> {
            public void UnbindModel(RouteValueDictionary routeValueDictionary, string routeName, BaseClass routeValue) {
                throw new System.NotImplementedException("qq");
            }
        }
        public class BaseClass { }
        public class Child1 : BaseClass { }
        public class Child2 : BaseClass { }

        [TestMethod()]
        public void NoUnbinders_ReturnNull() {
            Assert.IsNull(_target.FindUnbinderFor(typeof(BaseClass)));
        }

        [TestMethod()]
        public void OneUnbinder() {
            var unbinder = new TestUnbinder();
            _target.Add(typeof(BaseClass), unbinder);
            Assert.AreSame(unbinder, _target.FindUnbinderFor(typeof(BaseClass)));
            Assert.IsNull(_target.FindUnbinderFor(typeof(Child1)));
        }

        [TestMethod()]
        public void BaseClassUnbinder() {
            var unbinder = new TestUnbinder();
            _target.Add(typeof(BaseClass), unbinder, true);
            Assert.AreSame(unbinder, _target.FindUnbinderFor(typeof(BaseClass)));
            Assert.AreSame(unbinder, _target.FindUnbinderFor(typeof(Child1)));
        }

        [TestMethod()]
        public void OverridingUnbinder() {
            var unbinder1 = new TestUnbinder();
            var unbinder2 = new TestUnbinder();
            _target.Add(typeof(BaseClass), unbinder1, true);
            _target.Add(typeof(Child1), unbinder2, true);
            Assert.AreSame(unbinder1, _target.FindUnbinderFor(typeof(BaseClass)));
            Assert.AreSame(unbinder2, _target.FindUnbinderFor(typeof(Child1)));
            Assert.AreSame(unbinder1, _target.FindUnbinderFor(typeof(Child2)));
        }

        [TestMethod()]
        public void OverridingUnbinder2() {
            var unbinder1 = new TestUnbinder();
            var unbinder2 = new TestUnbinder();
            _target.Add(typeof(BaseClass), unbinder1, true);
            _target.Add(typeof(Child1), unbinder2);
            Assert.AreSame(unbinder1, _target.FindUnbinderFor(typeof(BaseClass)));
            Assert.AreSame(unbinder2, _target.FindUnbinderFor(typeof(Child1)));
            Assert.AreSame(unbinder1, _target.FindUnbinderFor(typeof(Child2)));
        }

        [TestMethod()]
        public void OverridingUnbinder3_InTheOtherOrder() {
            var unbinder1 = new TestUnbinder();
            var unbinder2 = new TestUnbinder();
            _target.Add(typeof(Child1), unbinder2);
            _target.Add(typeof(BaseClass), unbinder1, true);
            Assert.AreSame(unbinder1, _target.FindUnbinderFor(typeof(BaseClass)));
            Assert.AreSame(unbinder2, _target.FindUnbinderFor(typeof(Child1)));
            Assert.AreSame(unbinder1, _target.FindUnbinderFor(typeof(Child2)));
        }

        [TestMethod()]
        public void GenericUnbinder() {
            var unbinder2 = new TestUnbinder2();
            _target.Add(unbinder2);
            var unbinder = _target.FindUnbinderFor(typeof(BaseClass));
            try {
                unbinder.UnbindModel(null, "", null);
            }
            catch (NotImplementedException ex) {
                Assert.AreEqual("qq", ex.Message);
                return;
            }
            Assert.Fail("TestUnbinder2 wasn't called");
        }

        [TestMethod()]
        public void GenericUnbinder_BaseClass() {
            var unbinder2 = new TestUnbinder2();
            _target.Add(unbinder2, true);
            var unbinder = _target.FindUnbinderFor(typeof(Child1));
            try {
                unbinder.UnbindModel(null, "", null);
            }
            catch (NotImplementedException ex) {
                Assert.AreEqual("qq", ex.Message);
                return;
            }
            Assert.Fail("TestUnbinder2 wasn't called");
        }
    }
}