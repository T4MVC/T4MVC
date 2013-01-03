using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Mvc
{
    public interface IModelUnbinderProvider
    {
        IModelUnbinder GetUnbinder(Type routeValueType);
    }
}
