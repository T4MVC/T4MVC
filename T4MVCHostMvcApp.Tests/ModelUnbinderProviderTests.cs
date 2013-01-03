using System;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace T4MVCHostMvcApp.Tests {

    [TestClass()]
    public class ModelUnbinderProvidersTests {
        private ModelUnbinderProviders _target;

        [TestInitialize()]
        public void Setup() {
            _target = new ModelUnbinderProviders();
        }

        public class GenericClass<T> {
            public T Property { get; set; }
        }
        public class GenericClassUnbinder<T> : IModelUnbinder, IModelUnbinder<GenericClass<T>>
        {
            public void UnbindModel(RouteValueDictionary routeValueDictionary, string routeName, object routeValue) {
                UnbindModel(routeValueDictionary, routeName, routeValue as GenericClass<T>);
            }

            public void UnbindModel(RouteValueDictionary routeValueDictionary, string routeName, GenericClass<T> routeValue) {
                if (routeValue != null) {
                    routeValueDictionary[routeName] = routeValue.Property.ToString();
                }
            }
        }
        public class GenericUnbinderProvider : IModelUnbinderProvider {
            public IModelUnbinder GetUnbinder(Type routeValueType) {
                return routeValueType.IsGenericType && routeValueType.GetGenericTypeDefinition() == typeof(GenericClass<>)
                    ? (IModelUnbinder)Activator.CreateInstance(typeof(GenericClassUnbinder<>).MakeGenericType(routeValueType.GetGenericArguments()[0]))
                    : null;
            }
        }
        
        [TestMethod()]
        public void NoUnbinders_ReturnNull() {
            Assert.IsNull(_target.FindUnbinderFor(typeof(GenericClass<int>)));
        }

        [TestMethod()]
        public void GenericClassUnbinder_ReturnGenericUnbinder() {
            var unbinderProvider = new GenericUnbinderProvider();
            _target.Add(unbinderProvider);
            Assert.IsInstanceOfType(_target.FindUnbinderFor(typeof(GenericClass<int>)), typeof(GenericClassUnbinder<int>));
        }

    }
}