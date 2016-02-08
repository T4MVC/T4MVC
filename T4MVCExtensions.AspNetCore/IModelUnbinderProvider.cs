using System;

namespace Microsoft.AspNet.Mvc
{
    public interface IModelUnbinderProvider
    {
        IModelUnbinder GetUnbinder(Type routeValueType);
    }
}
