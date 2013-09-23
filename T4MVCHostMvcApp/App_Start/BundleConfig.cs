using System.Diagnostics.CodeAnalysis;
using System.Web.Optimization;

namespace T4MVCHostMvcApp.App_Start
{
    public static class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        [SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle(Links.Bundles.Content.Styles).Include(
                Links.Bundles.Content.Assets.Site_css
                ));

        }
    }
}

namespace Links
{
    public static partial class Bundles
    {
        public static partial class Content
        {
            public const string Styles = "~/content/styles";
        }
    }
}